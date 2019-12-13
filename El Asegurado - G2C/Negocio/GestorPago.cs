using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Data;
using DTO;

namespace Negocio
{
    static class Constants
    {
        public const double RECARGO = 0.005;
        public const double DESCUENTO = 0.015;
    }
    public class GestorPago
    {
        public dto_PagoPoliza cargarPolizaParaPagar(decimal NroPolizaSuc, decimal NroPoliza, decimal NroPolizaSec)
        {
            dto_PagoPoliza dtoPagoPoliza = new dto_PagoPoliza();
            GestorPoliza gestorPoliza = new GestorPoliza();
            DAOExtra dAOExtra = new DAOExtra();
            DAOCliente dAOCliente = new DAOCliente();
            Poliza poliza = new Poliza();
            
            poliza = gestorPoliza.BuscarPoliza(NroPolizaSuc, NroPoliza, NroPolizaSec);
            if (poliza == null)
            {
                throw new Exception("Póliza Inexistente.");
            }
            if (dAOExtra.GetEstadoPoliza(poliza.idEstadoPoliza).nombre.Trim() != "Vigente") 
            {
                throw new Exception("Póliza No Vigente.");
            }
            List<dto_Cuota> dtoCuota= new List<dto_Cuota>();
            List<PolizaCuota> cuotas = poliza.PolizaCuotas.ToList();
            var ultimoPago = GetUltimoPago(poliza.PolizaCuotas);

            dtoCuota = CalcularCuotasPendientes(cuotas);
            dtoPagoPoliza.ApellidoCliente = dAOCliente.GetPersona(poliza.Cliente.idPersona).apellido;
            dtoPagoPoliza.NombreCliente = dAOCliente.GetPersona(poliza.Cliente.idPersona).nombre;
            dtoPagoPoliza.NroCliente = Convert.ToInt32(dAOCliente.Get(poliza.idCliente).NroCliente);
            
            dtoPagoPoliza.DatosVehiculo = poliza.datosVehiculo;
            dtoPagoPoliza.Patente = poliza.patente;
            dtoPagoPoliza.CuotasPendientes = dtoCuota;
            
            dtoPagoPoliza.FechaFin = poliza.fechaFinVigencia;
            dtoPagoPoliza.FechaInicio = poliza.fechaInicioVigencia;
            dtoPagoPoliza.idPoliza = poliza.id;
            dtoPagoPoliza.UltimoPago = ultimoPago.Item1.GetValueOrDefault();
            dtoPagoPoliza.ImportePago = ultimoPago.Item2;
            
            
            return dtoPagoPoliza;

        }

        public List<dto_Cuota> CalcularCuotasPendientes(List<PolizaCuota> cuotas)
        {
            List<dto_Cuota> dtoCuota = new List<dto_Cuota>();
            
                  
            foreach(var cuota in cuotas)
            {
                if (cuota.idPolizaRecibo == null)
                {
                dto_Cuota dtoCuotaAux = new dto_Cuota();
                dtoCuotaAux.IdCuota = cuota.id; 
                dtoCuotaAux.ImporteCuota = cuota.importeCuota.GetValueOrDefault();
                dtoCuotaAux.ImporteDescuento = CalcularDescuento(cuota.fechaVencimiento, cuota.importeCuota.GetValueOrDefault());
                dtoCuotaAux.ImporteRecargo = CalcularRecargo(cuota.fechaVencimiento, cuota.importeCuota.GetValueOrDefault());
                dtoCuotaAux.ImporteTotalCuota = dtoCuotaAux.ImporteCuota + dtoCuotaAux.ImporteDescuento + dtoCuotaAux.ImporteRecargo;
                dtoCuotaAux.NroCuota = cuota.nroCuota;
                dtoCuotaAux.FechaVencimiento = cuota.fechaVencimiento;
                
                dtoCuota.Add(dtoCuotaAux);

                }

            }
            return dtoCuota;
        }

        //Calcula el recargo diario aplicado a las cuotas vencidas
        public decimal CalcularRecargo(DateTime fechaVencimiento, decimal importeCuota)
        {
            DateTime hoy = DateTime.Now;
            decimal recargo = 0;
            decimal factor = new decimal(Constants.RECARGO);
            int diasMora = hoy.Subtract(fechaVencimiento).Days;
            
            if (diasMora > 0)   //Cuota vencida
            {
                recargo = factor * diasMora * importeCuota;
            }
            return recargo;
        }

        //Calcula la bonificación a otorgar por adelanto de cuotas. Se aplica a vencimientos mayores a 30 días.
        public decimal CalcularDescuento(DateTime fechaVencimiento, decimal importeCuota)
        {
            DateTime hoy = DateTime.Now;
            decimal descuento = 0;
            decimal factor = new decimal(Constants.DESCUENTO);
            int diferencia = fechaVencimiento.AddDays(-30).Subtract(hoy).Days;
            if (diferencia > 0) //Fecha de vencimiento posterior a 30 días
            {
                int adelanto = (diferencia/30) + 1;

                descuento = factor * adelanto * importeCuota * -1;
            }
            return descuento;
        }

        public dto_Pago RegistrarPago(List<dto_Cuota> cuotas,int idPoliza)
        {
            dto_Pago dtoPago = new dto_Pago();

            GestorPoliza gestorPoliza = new GestorPoliza();

            DAOExtra dAOExtra = new DAOExtra();
            DAOCliente dAOCliente = new DAOCliente();
            DAOPolizaRecibo dAOPolizaRecibo = new DAOPolizaRecibo();

            Poliza poliza = new Poliza();
            PolizaCuota cuotaAux = new PolizaCuota();

            try
            {
                poliza = gestorPoliza.BuscarPoliza(idPoliza);
                verificarSeleccionCuotas(cuotas.First(), poliza.PolizaCuotas.ToList());  

                PolizaRecibo polizaRecibo = new PolizaRecibo();
                var contador = 0;
                foreach (var cuota in cuotas)
                {
                    contador = cuota.NroCuota;  //se utiliza para buscar la primer cuota impaga luego de cargar las cuotas a pagar
                    PolizaCuota polizaCuota = poliza.PolizaCuotas.ElementAt(cuota.NroCuota - 1);  //getCuota(cuota.nroCuota) <-- SeqDiag
                    polizaCuota.importeDescuento = cuota.ImporteDescuento;
                    polizaCuota.importeRecargo = cuota.ImporteRecargo;
                    polizaRecibo.PolizaCuotas.Add(polizaCuota);
                }

                dAOPolizaRecibo.GuardarRecibo(polizaRecibo);

                //ActualizarPolizaEstado
                if (contador < poliza.PolizaCuotas.Count)   //hay cuotas impagas?
                {
                    cuotaAux = poliza.PolizaCuotas.ElementAt(contador); //getPrimerCuota() <- SeqDiag
                    if(cuotaAux.fechaVencimiento >= DateTime.Today)
                    {
                        poliza.EstadoPoliza = dAOExtra.GetEstadoPoliza("Vigente");
                    }
                    else
                    {
                        poliza.EstadoPoliza = dAOExtra.GetEstadoPoliza("Suspendida");
                    }
                }
                else if(cuotaAux.fechaVencimiento < DateTime.Today)
                {
                    poliza.EstadoPoliza = dAOExtra.GetEstadoPoliza("No Vigente");
                }
               


            return dtoPago;
            }
           
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void verificarSeleccionCuotas(dto_Cuota primerCuotaAPagar, List<PolizaCuota> cuotas)
        {
            foreach(var cuota in cuotas)    //getPrimerCuota() <-- SeqDiag
            {
               if (cuota.idPolizaRecibo == null)
                    if (cuota.nroCuota != primerCuotaAPagar.NroCuota)
                        throw new Exception("Existen cuotas anteriores que aún no han sido abonadas.");
            }
        }

        public (Nullable<DateTime>, decimal) GetUltimoPago(ICollection<PolizaCuota> polizaCuotas)
        {
            try
            {
                foreach (var cuota in polizaCuotas)
                {
                    if (cuota.idPolizaRecibo != null)
                    {
                        DAOPolizaRecibo dAOPolizaRecibo = new DAOPolizaRecibo();
                        PolizaRecibo polizaRecibo = dAOPolizaRecibo.Get(cuota.idPolizaRecibo);
                        return (polizaRecibo.FechaRecibo, (cuota.importeCuota + cuota.importeDescuento + cuota.importeRecargo).GetValueOrDefault());
                    }
                }
                return (null, 0);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
