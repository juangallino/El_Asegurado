using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Data;


namespace DAO
{
    public class DAOExtra
    {
        public List<TipoCobertura> BuscarCoberturas()
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                return db.TipoCoberturas.AsNoTracking().ToList();
            }
        }

        public List<Localidad> BuscarLocalidad(int IdProvincia)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {

                return db.Localidads.AsNoTracking().Where(p => p.idProvincia == IdProvincia).OrderBy(p => p.nombre).ToList();

            }


        }

        public List<Modelo> BuscarModelos(int idMarca)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {

                return db.Modeloes.AsNoTracking().Where(p => p.idmarca == idMarca).OrderBy(p => p.nombre).ToList();

            }
        }

        public List<Provincia> BuscarProvincias()
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {

                return db.Provincias.AsNoTracking().ToList();

            }
        }

        public List<EstadoCivil> BuscarEstodosCiviles()
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {

                return db.EstadoCivils.AsNoTracking().ToList();

            }
        }

        public List<Sexo> BuscarSexos()
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {

                return db.Sexoes.AsNoTracking().ToList();

            }
        }

        public List<Marca> BuscarMarcas()
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {

                return db.Marcas.AsNoTracking().ToList();

            }
        }

        public decimal GetSumaAsegurada(int idModelo, int AñoFabricacion)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                
                var valorAsegurado = db.Vehiculoes.AsNoTracking().Where(p => p.idModelo == idModelo).Where(p => p.AñoFabricacion == AñoFabricacion).Select(p => p.valorAsegurado);
                return valorAsegurado.FirstOrDefault();


            }
        }

        public List<EstadoPoliza> BuscarEstadosPoliza()
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {

                return db.EstadoPolizas.AsNoTracking().ToList();

            }
        }
        public List<TipoDocumento> BuscarTipoDocumento()
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                return db.TipoDocumentoes.AsNoTracking().ToList();

            }
        }






    }
}
