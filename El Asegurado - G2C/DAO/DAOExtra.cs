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
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.TipoCoberturas.AsNoTracking().ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Localidad> BuscarLocalidad(int IdProvincia)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Localidads.AsNoTracking().Where(p => p.idProvincia == IdProvincia).OrderBy(p => p.nombre).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Modelo> BuscarModelos(int idMarca)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Modeloes.AsNoTracking().Where(p => p.idmarca == idMarca).OrderBy(p => p.nombre).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Provincia> BuscarProvincias()
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Provincias.AsNoTracking().ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<EstadoCivil> BuscarEstodosCiviles()
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.EstadoCivils.AsNoTracking().ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Sexo> BuscarSexos()
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {

                    return db.Sexoes.AsNoTracking().ToList();

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Marca> BuscarMarcas()
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Marcas.AsNoTracking().ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoCobertura GetResponsabilidadCivil()
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    var ResponsabilidadCivil = db.TipoCoberturas.AsNoTracking().Where(p => p.nombre == "Responsabilidad Civil");
                    return ResponsabilidadCivil.FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public decimal GetSumaAsegurada(int idModelo, int AñoFabricacion)
        {
            try
            {
            using (DBEntities_TP db = new DBEntities_TP())
            {               
                var valorAsegurado = db.Vehiculoes.AsNoTracking().Where(p => p.idModelo == idModelo).Where(p => p.AñoFabricacion == AñoFabricacion).Select(p => p.valorAsegurado);
                return valorAsegurado.FirstOrDefault();
            }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<EstadoPoliza> BuscarEstadosPoliza()
        {
            try
            {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                return db.EstadoPolizas.AsNoTracking().ToList();
            }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public EstadoPoliza GetEstadoPoliza(string nombreEstadoPoliza)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    var estadoPoliza = db.EstadoPolizas.AsQueryable().Where(p => p.nombre == nombreEstadoPoliza).FirstOrDefault();
                    return estadoPoliza;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<TipoDocumento> BuscarTipoDocumento()
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.TipoDocumentoes.AsNoTracking().ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
