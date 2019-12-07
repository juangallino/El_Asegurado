using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using Data;
using System.Windows.Forms;

namespace Negocio
{
    public class GestorExtra
    {
        public List<dto_extra> BuscarLocalidad(int IdProvincia)
        {
            DAOExtra dAOExtra = new DAOExtra();

            // return dAOExtra.BuscarLocalidad(IdProvincia);

            List<dto_extra> listaCarga = new List<dto_extra>();

            foreach (var DATO in dAOExtra.BuscarLocalidad(IdProvincia))
            {

                dto_extra dtoExtra = new dto_extra();
                dtoExtra.id = DATO.id;
                dtoExtra.nombre = DATO.nombre;
                listaCarga.Add(dtoExtra);
            }
            return listaCarga;
        }

        public List<dto_extra> BuscarModelo(int idMarca)
        {
            DAOExtra dAOExtra = new DAOExtra();
            //return dAOExtra.BuscarModelos(idMarca);

            List<dto_extra> listaCarga = new List<dto_extra>();

            foreach (var modelo in dAOExtra.BuscarModelos(idMarca))
            {

                dto_extra dto_extra = new dto_extra();
                dto_extra dtoExtra = dto_extra;
                dtoExtra.id = modelo.id;
                dtoExtra.nombre = modelo.nombre;
                listaCarga.Add(dtoExtra);
            }
            return listaCarga;
        }

        public List<dto_extra> CargarTipoCobertura(int añovehículo)
        {
            DAOExtra dAOExtra = new DAOExtra();
            
            DateTime fecha = new DateTime();
            fecha = DateTime.Today;
            List<dto_extra> listaCarga = new List<dto_extra>();
            
            //Verifico el año del vehículo. Si es mayor a 10 años, sólo muestra la cobertura Responsabilidad Civil
            if(fecha.Year - añovehículo > 10)
            {
                var DATO = dAOExtra.GetResponsabilidadCivil();
                dto_extra dtoExtra = new dto_extra
                {
                    id = DATO.id,
                    nombre = DATO.nombre
                };
                listaCarga.Add(dtoExtra);
            }
            else
            {
                foreach (var DATO in dAOExtra.BuscarCoberturas())
                {
                    dto_extra dtoExtra = new dto_extra
                    {
                        id = DATO.id,
                        nombre = DATO.nombre
                    };
                    listaCarga.Add(dtoExtra);
                }
            }            
            return listaCarga;
        }

        public List<dto_extra> CargarProvincia()
        {
            DAOExtra dAOExtra = new DAOExtra();
            // return dAOExtra.BuscarProvincias();

            List<dto_extra> listaCarga = new List<dto_extra>();

            foreach (var DATO in dAOExtra.BuscarProvincias())
            {

                dto_extra dtoExtra = new dto_extra();
                dtoExtra.id = DATO.id;
                dtoExtra.nombre = DATO.nombre;
                listaCarga.Add(dtoExtra);
            }
            return listaCarga;



        }

        public List<dto_extra> CargaMarca()
        {
            DAOExtra dAOExtra = new DAOExtra();
            // return dAOExtra.BuscarMarcas();

            List<dto_extra> listaCarga = new List<dto_extra>();

            foreach (var DATO in dAOExtra.BuscarMarcas())
            {

                dto_extra dtoExtra = new dto_extra();
                dtoExtra.id = DATO.id;
                dtoExtra.nombre = DATO.nombre;
                listaCarga.Add(dtoExtra);
            }
            return listaCarga;



        }

        public List<dto_extra> CargarEstadoCivil()
        {
            DAOExtra dAOExtra = new DAOExtra();
            //return dAOExtra.BuscarEstodosCiviles();


            List<dto_extra> listaCarga = new List<dto_extra>();

            foreach (var DATO in dAOExtra.BuscarEstodosCiviles())
            {

                dto_extra dtoExtra = new dto_extra();
                dtoExtra.id = DATO.id;
                dtoExtra.nombre = DATO.nombre;
                listaCarga.Add(dtoExtra);
            }
            return listaCarga;


        }

        public List<dto_extra> CargarSexo()
        {
            DAOExtra dAOExtra = new DAOExtra();
            // return dAOExtra.BuscarSexos();

            List<dto_extra> listaCarga = new List<dto_extra>();

            foreach (var DATO in dAOExtra.BuscarSexos())
            {

                dto_extra dtoExtra = new dto_extra();
                dtoExtra.id = DATO.id;
                dtoExtra.nombre = DATO.nombre;
                listaCarga.Add(dtoExtra);
            }
            return listaCarga;



        }

        public decimal GetSumaAsegurada(int idModelo, int añoVehiculo)
        {
            decimal sumaAsegurada = 1500000;
            //Hardcodeo

            return sumaAsegurada;
        }

        public List<DateTime> CargarListaCuotas(DateTime fechaInicioVigencia)
        {
            List<DateTime> Vencimientos = new List<DateTime>
            {
                fechaInicioVigencia.AddMonths(1),
                fechaInicioVigencia.AddMonths(2),
                fechaInicioVigencia.AddMonths(3),
                fechaInicioVigencia.AddMonths(4),
                fechaInicioVigencia.AddMonths(5),
                fechaInicioVigencia.AddMonths(6)
            };
            return Vencimientos;


        }

        public List<dto_extra> CargarEstadosPoliza()
        {
            DAOExtra dAOExtra = new DAOExtra();

            List<dto_extra> listaCarga = new List<dto_extra>();

            foreach (var DATO in dAOExtra.BuscarEstadosPoliza())
            {
                dto_extra dtoExtra = new dto_extra();
                dtoExtra.id = DATO.id;
                dtoExtra.nombre = DATO.nombre;
                listaCarga.Add(dtoExtra);
            }
            return listaCarga;
        }
        public List<dto_extra> CargarTipoDocumento()
        {
            DAOExtra dAOExtra = new DAOExtra();
            // return dAOExtra.BuscarCoberturas();

            List<dto_extra> listaCarga = new List<dto_extra>();

            foreach (var DATO in dAOExtra.BuscarTipoDocumento())
            {

                dto_extra dto_extra = new dto_extra();
                dto_extra dtoExtra = dto_extra;
                dtoExtra.id = DATO.id;
                dtoExtra.nombre = DATO.nombre;
                listaCarga.Add(dtoExtra);
            }
            return listaCarga;



        }
        public int GetNroSiniestros(int idCliente)
        {
            return new Random().Next(3);
        }
    }
}
