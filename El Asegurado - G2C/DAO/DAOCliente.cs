using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    Persona persona = new Persona();
                    persona = db.Personas.Find(idPersona);
                    return persona;
                }
            }
            
             catch (DbEntityValidationException e)
            {
                string mensaje = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    
                    Console.WriteLine("Entity of type \"{0}\" in the state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                        mensaje = "- Property: \"{0}\", Error: \"{1}\"" + ve.PropertyName + " " + ve.ErrorMessage;
                    }

                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                            ve.PropertyName,
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                            ve.ErrorMessage);
                        mensaje = mensaje + "- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"" + ve.PropertyName + " " +
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName) + " " + ve.ErrorMessage;
                    }
                }
               
                throw new Exception(mensaje);

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
        public int CountIninterrumpidoParaPlata(int idCliente)
        {
            try
            {
                var fecha = DateTime.Today.AddYears(-2);
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Polizas.Where(p => p.idCliente == idCliente && p.fechaInicioVigencia > fecha).Count();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}






