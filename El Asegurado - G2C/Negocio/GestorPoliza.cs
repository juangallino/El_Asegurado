using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;
using DAO;
using System.Windows.Forms;

namespace Negocio
{

    public class GestorPoliza
    {
        private Cliente clientePoliza = new Cliente();
        private readonly GestorCliente gestorCliente = new GestorCliente();
        public void GenerarPoliza(dto_poliza dtoPoliza)
        {

            try
            {
                Validar(dtoPoliza);
                Poliza poliza = new Poliza(dtoPoliza)
                {
                    idCliente = clientePoliza.id
                };
                //Agregar medidas de seguridad
                foreach (var ms in dtoPoliza.Medidas_Seguridad)
                {
                    DAOMedSeg dAOMedSeg = new DAOMedSeg();
                    PolizaMedidaSeguridad polizaMedidaSeguridad = new PolizaMedidaSeguridad();
                    MedidaSeguridad medidaSeguridad = new MedidaSeguridad();
                    medidaSeguridad = dAOMedSeg.get(ms);
                    polizaMedidaSeguridad.idMedidaSeguridad = medidaSeguridad.id;
                    polizaMedidaSeguridad.Valor = 1;
                    poliza.PolizaMedidaSeguridads.Add(polizaMedidaSeguridad); //se usa clase virtual
                }
                //Agregar hijos
                foreach (var auxhijo in dtoPoliza.Hijo)
                {
                   DAOEstCivil dAOEstCivil = new DAOEstCivil();
                    PolizaHijo hijo = new PolizaHijo
                    {
                        fechaNacimiento = auxhijo.Fecha_nac,
                        idEstadoCivil = auxhijo.IdEstadoCivil,
                        idSexo = auxhijo.IdSexo
                    };
                    poliza.PolizaHijoes.Add(hijo);  //se usa clase virtual
                }

                //Agregar cuotas 
                int nroCuota = 1;
                foreach (var fechaVenc in dtoPoliza.Vto_Pago)
                {
                    PolizaCuota polizaCuota = new PolizaCuota
                    {
                        fechaVencimiento = fechaVenc,
                        idPoliza = poliza.id,
                        importeCuota = dtoPoliza.Monto_Abonar / dtoPoliza.FormaPago,
                        nroCuota = nroCuota++
                    };
                    poliza.PolizaCuotas.Add(polizaCuota);   // Usando esta clase virtual terminamos creando una PolizaCuota
                }

                // CARGA VEHICULO
                DAOVehiculo dAOVehiculo = new DAOVehiculo();


                poliza.idVehiculo = dAOVehiculo.Get(dtoPoliza.IdVehiculo).id;
                poliza.nroMotor = dtoPoliza.NroMotor;
                poliza.nroChasis = dtoPoliza.NroChasis;
                poliza.patente = dtoPoliza.Patente;

                DAOPoliza dAOPoliza = new DAOPoliza();

                poliza.idEstadoPoliza = 1;  //Estado Generada

                //Se guarda la poliza generada

                dAOPoliza.GuardarPoliza(poliza);

                //Cambiar estado al Cliente

                gestorCliente.CambiarEstadoCliente(poliza.idCliente, dtoPoliza.Nro_Siniestros);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        internal Poliza BuscarPoliza(int idPoliza)
        {
            try
            {
                DAOPoliza dAOPoliza = new DAOPoliza();
                return dAOPoliza.GetPoliza(idPoliza);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void Validar(dto_poliza dto_Poliza) 
        {
            try
            {
                clientePoliza = gestorCliente.ValidarCliente(dto_Poliza.IdCliente);
                DAOPoliza daoPoliza = new DAOPoliza();
                if (daoPoliza.VerificarPolizaActiva(dto_Poliza.Patente, dto_Poliza.NroMotor, dto_Poliza.NroChasis))
                {
                    dto_Poliza.NroPolizaSec = 00;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public dto_poliza CargarDTOPoliza(int idPoliza)
        {
            DAOPoliza dAOPoliza = new DAOPoliza();
            DAOHijo dAOHijo = new DAOHijo();

            dto_poliza dto_Poliza = new dto_poliza();
            List<dto_hijo> dto_Hijos = new List<dto_hijo>();


            Poliza poliza = dAOPoliza.GetPoliza(idPoliza);
            Vehiculo vehiculo = dAOPoliza.GetVehiculo(poliza.idVehiculo);


            foreach (var polizaHijo in dAOHijo.GetHijos(poliza.id))
            {
                DAOCliente dAOClienteAux = new DAOCliente();        //Usa los metodos GetEstadoCivil y GetSexo
                dto_Hijos.Add(new dto_hijo
                {
                    Id = polizaHijo.id,
                    EstadoCivil = dAOClienteAux.GetEstadoCivil(polizaHijo.idEstadoCivil).nombre,
                    Sexo = dAOClienteAux.GetSexo(polizaHijo.idSexo).nombre,
                    Fecha_nac = polizaHijo.fechaNacimiento
                }); ;

            }

            Modelo modelo = dAOPoliza.GetModelo(vehiculo.idModelo);
            Marca marca = dAOPoliza.GetMarca(modelo.idmarca);
            List<DateTime> vencimientoPagos = new List<DateTime>();
            foreach (var vtoPago in dAOPoliza.GetCuotas(poliza.id))
            {
                vencimientoPagos.Add(vtoPago.fechaVencimiento);
            }
            List<int> polizaMedidaSeguridad = new List<int>();
            foreach (var medidaSeguridad in dAOPoliza.GetMedidasSeguridad(poliza.id))
            {
                polizaMedidaSeguridad.Add(medidaSeguridad.idMedidaSeguridad);
            }
            dto_Poliza.AñoVehiculo = vehiculo.AñoFabricacion;
            dto_Poliza.FechaInicioVigencia = poliza.fechaInicioVigencia;
            dto_Poliza.Hijo = dto_Hijos;
            dto_Poliza.id = poliza.id;
            dto_Poliza.IdVehiculo = poliza.idVehiculo;
            dto_Poliza.IdCliente = poliza.idCliente;
            dto_Poliza.ImporteDescuento = poliza.importeDescuento.GetValueOrDefault();
            dto_Poliza.KmPorAño = poliza.kmPorAño;
            dto_Poliza.Marca = marca.nombre;
            dto_Poliza.Medidas_Seguridad = polizaMedidaSeguridad;
            dto_Poliza.Modelo = modelo.nombre;
            dto_Poliza.Monto_Abonar = poliza.importeTotal.GetValueOrDefault();
            dto_Poliza.NroChasis = poliza.nroChasis;
            dto_Poliza.NroMotor = poliza.nroMotor;
            dto_Poliza.NroPolizaSec = poliza.NroPolizaSec;
            dto_Poliza.NroPolizaSuc = poliza.NroPolizaSuc;
            dto_Poliza.Nro_Siniestros = poliza.nroSiniestros;
            dto_Poliza.Patente = poliza.patente;
            dto_Poliza.Premio = poliza.importePremio.GetValueOrDefault();

            dto_Poliza.Suma_Asegurada = vehiculo.valorAsegurado;
            dto_Poliza.Tipo_Cobertura = poliza.idTipoCobertura;
            dto_Poliza.Vto_Pago = vencimientoPagos;

            return dto_Poliza;
        }

        public (dto_poliza, dto_cliente) BuscarDetallePolizaID(int polizaId)
        {
            //DTOs
            dto_poliza dtoPoliza = CargarDTOPoliza(polizaId);
            dto_cliente dtoCliente = gestorCliente.CargarDTOCliente(dtoPoliza.IdCliente);
            
            return (dtoPoliza, dtoCliente);
        }

        public string BuscarNombreMedida(int IdMedida)
        {
            DAOMedSeg dAOMedSeg = new DAOMedSeg();
            return dAOMedSeg.get(IdMedida).nombre;

        }

        public List<dto_ListaPolizasBuscadas> BuscarPoliza(dto_busquedaPoliza dto_BusquedaPoliza)
        {
            DAOPoliza dAOPoliza = new DAOPoliza();
            
            List<dto_ListaPolizasBuscadas> listaAux = new List<dto_ListaPolizasBuscadas>();
            
            foreach (var poliza in dAOPoliza.ConsultaBuscarPolizas(dto_BusquedaPoliza)) {

                dto_ListaPolizasBuscadas dto_Lista = new dto_ListaPolizasBuscadas
                {
                    id = poliza.id,
                    Patente = poliza.patente,
                    Cliente = poliza.idCliente.ToString()
                };
                ; //poliza.Cliente.Persona.nombre + ", " + poliza.Cliente.Persona.apellido;
                dto_Lista.Vehiculo = poliza.datosVehiculo;
                dto_Lista.Motor = poliza.nroMotor;
                dto_Lista.Chasis = poliza.nroChasis;
                dto_Lista.FechaFin = poliza.fechaFinVigencia;
                dto_Lista.FechaInicio = poliza.fechaInicioVigencia;
                dto_Lista.Estado = poliza.idEstadoPoliza.ToString();// poliza.EstadoPoliza.nombre;
                listaAux.Add(dto_Lista);
            }
            return listaAux;

        }

    }
}
