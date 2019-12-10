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
    public class GestorPago
    {
        public dto_PagoPoliza cargarPolizaParaPagar(int idPoliza)
        {
            dto_PagoPoliza dtoPagoPoliza = new dto_PagoPoliza();
            GestorPoliza gestorPoliza = new GestorPoliza();
            Poliza poliza = new Poliza();
            
           
            DAOExtra dAOExtra = new DAOExtra();
            DAOCliente dAOCliente = new DAOCliente();

            try
            {

            
                poliza = gestorPoliza.BuscarPoliza(idPoliza);
                if (poliza == null)
                {
                    throw new Exception("Póliza Inexistente.");
                }
                if (dAOExtra.GetEstadoPoliza(poliza.idEstadoPoliza).nombre.Trim() != "Vigente") 
                {
                    throw new Exception("Póliza No Vigente.");
                }
                List<dto_Cuota> dtoCuota= new List<dto_Cuota>();
                // dtoCuota = CalcularCuotasPendientes(poliza.PolizaCuotas);

                Cliente cliente = dAOCliente.Get(poliza.idCliente);
                Persona persona = dAOCliente.GetPersona(cliente.idPersona);
                dtoPagoPoliza.ApellidoCliente = persona.apellido;
                dtoPagoPoliza.NombreCliente = persona.nombre;
                dtoPagoPoliza.NroCliente = Convert.ToInt32(poliza.idCliente);
                dtoPagoPoliza.UltimoPago = DateTime.Today;
                dtoPagoPoliza.ImportePago = 1000;
                    //dtoCuota[0].ImporteCuota + dtoCuota[0].ImporteDescuento + dtoCuota[0].ImporteRecargo;
            
                dtoPagoPoliza.DatosVehiculo = poliza.datosVehiculo;
                dtoPagoPoliza.CuotasPendientes = dtoCuota;
                dtoPagoPoliza.FechaFin = poliza.fechaFinVigencia;
                dtoPagoPoliza.FechaInicio = poliza.fechaInicioVigencia;
                dtoPagoPoliza.NroPoliza = Convert.ToInt32(poliza.NroPoliza);

                    return dtoPagoPoliza;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }


        }

        private List<dto_Cuota> CalcularCuotasPendientes(ICollection<PolizaCuota> polizaCuotas)
        {
            List<dto_Cuota> dtoCuota = new List<dto_Cuota>();
            dto_Cuota dtoCuotaAux = new dto_Cuota();
            DAOPoliza dAOPoliza = new DAOPoliza();

            foreach(var cuota in polizaCuotas)
            {
                //if la cuota no está pagada
                dtoCuotaAux.IdCuota = cuota.id; 
                dtoCuotaAux.ImporteCuota = cuota.importeCuota.GetValueOrDefault();
                dtoCuotaAux.ImporteDescuento = CalcularDescuento(cuota.fechaVencimiento, cuota.importeCuota.GetValueOrDefault());
                dtoCuotaAux.ImporteRecargo = CalcularRecargo(cuota.fechaVencimiento, cuota.importeCuota.GetValueOrDefault());
                dtoCuotaAux.NroCuota = cuota.nroCuota;
                dtoCuotaAux.FechaVencimiento = cuota.fechaVencimiento;
                dtoCuota.Add(dtoCuotaAux);
            }
            return dtoCuota;
        }

        private decimal CalcularRecargo(DateTime fechaVencimiento, decimal importeCuota)
        {
            DateTime hoy = DateTime.Today;
            decimal recargo = 0;
            if(fechaVencimiento < hoy)
            {
                
            }

            return recargo;

        }

        private decimal CalcularDescuento(DateTime fechaVencimiento, decimal importeCuota)
        {
            throw new NotImplementedException();
        }
    }
}
