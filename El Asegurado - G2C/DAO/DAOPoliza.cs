using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using DTO;

namespace DAO
{
    public class DAOPoliza
    {

        public Poliza GetPoliza(int idPoliza)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Polizas
                            .Where(p => p.id == idPoliza)
                            .Include(p => p.Cliente)       //Entidad Relacionada 
                            .Include(p => p.PolizaCuotas)  //Entidad Relacionada
                            .FirstOrDefault();
                    
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Poliza GetPolizaPorNroPoliza(decimal NroPolizaSuc, decimal NroPoliza, decimal NroPolizaSec)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Polizas
                            .Where(p => p.NroPolizaSuc == NroPolizaSuc)
                            .Where(p => p.NroPoliza == NroPoliza)
                            .Where(p => p.NroPolizaSec == NroPolizaSec)
                            .Include(p => p.Cliente)       //Entidad Relacionada 
                            .Include(p => p.PolizaCuotas)  //Entidad Relacionada
                            .FirstOrDefault();

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void GuardarPoliza(Poliza p)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    //Sentencias para que vincule las instancias persistidas en la BD y no cree una nueva
                    db.Entry(p.Localidad).State = System.Data.Entity.EntityState.Unchanged;
                    db.Entry(p.Cliente).State = System.Data.Entity.EntityState.Unchanged;
                    db.Entry(p.Vehiculo).State = System.Data.Entity.EntityState.Unchanged;
                    db.Entry(p.TipoCobertura).State = System.Data.Entity.EntityState.Unchanged;
                    db.Entry(p.EstadoPoliza).State = System.Data.Entity.EntityState.Unchanged;

                    db.Polizas.Add(p);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool VerificarPolizaActiva(string patente, string nroMotor, string nroChasis)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    int cantPolizasVigentes = db.Polizas.AsNoTracking().Where(p => p.patente == patente &&
                                                                                   p.nroMotor == nroMotor &&
                                                                                   p.nroChasis == nroChasis).
                                                                Where(p => p.fechaFinVigencia > DateTime.Today).
                                                                Count();
                    
                    if (cantPolizasVigentes == 0)
                        return true;
                    else
                        if (cantPolizasVigentes > 0)
                        throw new Exception("Existe una póliza vigente para la patente, motor o chasis indicados");
                    else
                        throw new Exception("Error en la Base de Datos al intentar recuperar póliza.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Vehiculo GetVehiculo(int idVehiculo)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Vehiculoes.Find(idVehiculo);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Modelo GetModelo(int idModelo)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Modeloes.Find(idModelo);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Marca GetMarca(int idmarca)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    
                    return db.Marcas.Find(idmarca);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoCobertura GetTipoCobertura(int idTipoCobertura)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.TipoCoberturas.Find(idTipoCobertura);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<PolizaCuota> GetCuotas(int idPoliza)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.PolizaCuotas.AsNoTracking().Where(p => p.idPoliza == idPoliza).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<PolizaMedidaSeguridad> GetMedidasSeguridad(int idPoliza)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.PolizaMedidaSeguridads.AsNoTracking().Where(p => p.idPoliza == idPoliza).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /* public List<Poliza> ConsultaBuscarPolizasPorNumero(string nroPolizaBusqueda)
         {
             try
             {
                 using (DBEntities_TP db = new DBEntities_TP())

                 {
                    // return db.Polizas.Find(nroPolizaBusqueda);


                 }
             }
             catch (Exception e)
             {
                 throw new Exception(e.Message);
             }
         }*/

        /* public List<Poliza> ConsultaBuscarPolizas(dto_busquedaPoliza dtoBP)
         {
             try
             {
                 using (DBEntities_TP db = new DBEntities_TP())
                 {

                     var aux = db.Polizas.AsNoTracking().Where(p => (dtoBP.nroPoliza == "" || p.NroPoliza.ToString() == dtoBP.nroPoliza) &&
                                                                 (dtoBP.nombreCliente == "" || (p.Cliente.Persona.nombre.Contains(dtoBP.nombreCliente) || p.Cliente.Persona.apellido.Contains(dtoBP.nombreCliente))) &&
                                                                  (dtoBP.idestado == 0 || p.EstadoPoliza.id == dtoBP.idestado) &&
                                                                  (dtoBP.idmarca == 0 || p.Vehiculo.Modelo.Marca.id == dtoBP.idmarca) &&
                                                                  (dtoBP.idmodelo == 0 || p.Vehiculo.Modelo.id == dtoBP.idmodelo)&&
                                                                  (dtoBP.fdesde == null || p.fechaFinVigencia >= dtoBP.fdesde) &&
                                                                  (dtoBP.fhasta == null || p.fechaFinVigencia <= dtoBP.fhasta)).ToList();

                     return aux;

                 }
             }
             catch (Exception e)
             {
                 throw new Exception(e.Message);
             }
         }*/
        public List<Poliza> ConsultaBuscarPolizas(decimal nroPoliza)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    /*var consulta = from t in db.Polizas
                                   where t.NroPoliza == nroPoliza
                                   select t;
                    return consulta.ToList();*/

                    return db.Polizas
                           .Where(p => p.NroPoliza == nroPoliza)
                           .Include(p => p.Cliente)                         //Entidad Relacionada 
                           .Include(p => p.Cliente.Persona)                 //Entidad Relacionada
                           .Include(p => p.Cliente.Persona.TipoDocumento)   //Entidad Relacionada
                           .Include(p => p.PolizaCuotas)                    //Entidad Relacionada
                           .ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<PolizaCuota> GetCuotasPendientes(int idPoliza)
        {
            List<PolizaCuota> cuotasPendientes = new List<PolizaCuota>();
           
            try
            {
                using(DBEntities_TP db = new DBEntities_TP())
                {
                    var consulta = from t in db.v_PagoCuota
                                 where t.idPoliza == idPoliza
                                 where t.FechaRecibo == null
                                 select t;
                    foreach(v_PagoCuota cuota in consulta)
                    {
                        PolizaCuota cuotaPendiente = new PolizaCuota();
                        cuotaPendiente.fechaVencimiento = cuota.fechaVencimiento;
                        cuotaPendiente.id = cuota.id;
                        cuotaPendiente.idPoliza = idPoliza;
                        cuotaPendiente.importeRecargo = cuota.importeRecargo;
                        cuotaPendiente.importeDescuento = cuota.importeDescuento;
                        cuotaPendiente.importeCuota = cuota.importeCuota;
                        cuotaPendiente.nroCuota = cuota.nroCuota;
                        cuotasPendientes.Add(cuotaPendiente);
                    }
                }
                return cuotasPendientes;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public decimal AsignarNroPoliza(decimal NroSuc)
        {
            try
            {
                using(DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Polizas.Where(p=> p.NroPolizaSuc == NroSuc)
                                     .Select(w => w.NroPoliza)
                                     .DefaultIfEmpty(0).Max() + 1;
                    
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
