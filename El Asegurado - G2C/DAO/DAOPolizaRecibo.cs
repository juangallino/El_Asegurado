using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DAO
{
    public class DAOPolizaRecibo
    {
        public  bool GuardarRecibo(PolizaRecibo p)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    int contador = 0;
                    foreach(var cuota in p.PolizaCuotas)
                    {
                        db.Entry(p.PolizaCuotas.ElementAt(contador++)).State = System.Data.Entity.EntityState.Modified;
                    }

                    db.PolizaReciboes.Add(p);

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }

        public PolizaRecibo Get(object idPolizaRecibo)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                    return db.PolizaReciboes.Find(idPolizaRecibo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            };
        }

        public decimal GetNroRecibo()
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                    return db.PolizaReciboes.Select(x => x.NroRecibo).DefaultIfEmpty(0).Max() + 1;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            };
        }
    }
}
