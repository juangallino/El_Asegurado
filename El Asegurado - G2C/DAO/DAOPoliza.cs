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
    public class DAOPoliza
    {

        public Poliza GetPoliza(int idPoliza)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.Polizas.Find(idPoliza);
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
                    db.Polizas.Add(p);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+e.InnerException);
                throw new Exception(e.Message, e.InnerException);
            }

        }

        public bool VerificarPolizaActiva(string patente, string nroMotor, string nroChasis)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    int cantPolizasVigentes = db.Polizas.AsNoTracking().Where(p => p.patente == patente).
                                                                Where(p => p.nroMotor == nroMotor).
                                                                Where(p => p.nroChasis == nroChasis).
                                                                Where(p => p.fechaFinVigencia > DateTime.Today).
                                                                Count();

                    if (cantPolizasVigentes == 0)
                        return true;
                    else
                        if (cantPolizasVigentes > 0)
                        throw new Exception("Existe una póliza vigente del asociado para ese vehículo");
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

        public List<Poliza> ConsultaBuscarPolizas(dto_busquedaPoliza dtoBP)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    var aux = db.Polizas.AsNoTracking().Where(p => //(nroPoliza ==0 || p.NroPolizaSec.Tostring() == nroPoliza) &&
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
        }

        /* public EstadoPoliza GetEstado(Poliza poliza)
         {
             try
             {
                 using (DBEntities_TP db = new DBEntities_TP())
                 {
                  //   return db.EstadoPolizas.AsNoTracking().Where(p => p.Polizas == poliza);

                         }
             }
             catch (Exception e)
             {
                 throw new Exception(e.Message);
             }
         }*/
    }
}
