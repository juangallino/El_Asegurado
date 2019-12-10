using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using DTO;

namespace DAO
{
    public class DAOCliente
    {
        public Cliente Get(int idCliente)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Cliente cliente = new Cliente();
                cliente = db.Clientes.Find(idCliente);
                return cliente;
            }
        }

        public Persona GetPersona(int idPersona)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Persona persona = new Persona();
                persona = db.Personas.Find(idPersona);
                return persona;
            }
        }

        public Domicilio GetDomicilio(int idDomicilio)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Domicilio domicilio = new Domicilio();
                domicilio = db.Domicilios.Find(idDomicilio);
                return domicilio;
            }
        }

        public Localidad GetLocalidad(int idLocalidad)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Localidad localidad = new Localidad();
                localidad = db.Localidads.Find(idLocalidad);
                return localidad;
            }
        }

        public EstadoCliente GetEstadoCliente(string estado)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                EstadoCliente estadoCliente = db.EstadoClientes.AsNoTracking().Where(p => p.nombre == estado).FirstOrDefault();
                return estadoCliente;
            }
;

        }

        public SituacionIVA GetSituacionIVA(int idSitIVA)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                SituacionIVA situacionIVA = new SituacionIVA();
                situacionIVA = db.SituacionIVAs.Find(idSitIVA);
                return situacionIVA;
            }
        }

        public TipoDocumento GetTipoDocumento(int idTipoDoc)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                TipoDocumento tipoDocumento = new TipoDocumento();
                tipoDocumento = db.TipoDocumentoes.Find(idTipoDoc);
                return tipoDocumento;
            }
        }

        public EstadoCivil GetEstadoCivil(int idEstCivil)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                EstadoCivil estadoCivil = new EstadoCivil();
                estadoCivil = db.EstadoCivils.Find(idEstCivil);
                return estadoCivil;
            }
        }
        public Provincia GetProvincia(int idProvincia)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Provincia provincia = new Provincia();
                provincia = db.Provincias.Find(idProvincia);
                return provincia;
            }
        }

        public void SetEstadoCliente(int idCliente, int idEstado)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Cliente cliente = new Cliente();
                cliente = db.Clientes.Find(idCliente);
                cliente.idEstadoCliente = idEstado;
                db.SaveChanges();

            }
        }

        public Sexo GetSexo(int idSexo)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Sexo sexo = new Sexo();
                sexo = db.Sexoes.Find(idSexo);
                return sexo;

            }
        }

        public Profesion GetProfesion(int idProfesion)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Profesion profesion = new Profesion();
                profesion = db.Profesions.Find(idProfesion);
                return profesion;
            }
        }

        public Pai GetPais(int idPais)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Pai pais = new Pai();
                pais = db.Pais.Find(idPais);
                return pais;
            }
        }
        public List<v_Cliente> ConsultaBuscarClientes(DTO_busquedaCliente dtoBC)
        {

            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    var query = db.v_Cliente.AsNoTracking().Where(q => q.nombre.Length > 0);

                    if (dtoBC.IdCliente.Value > 0 )
                        query = query.Where(q => q.NroCliente == dtoBC.IdCliente);
                    if (dtoBC.NroDocumento > 0)
                        query = query.Where(q => q.nroDocumento == dtoBC.NroDocumento);
                    if (!string.IsNullOrWhiteSpace(dtoBC.Apellido))
                        query = query.Where(q => q.apellido.Contains(dtoBC.Apellido.ToString().Trim()));
                    
                    if (!string.IsNullOrWhiteSpace(dtoBC.Nombre))
                        query = query.Where(q => q.nombre.Contains(dtoBC.Nombre));
                    return query.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }

}






