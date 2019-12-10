using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    //Sentencias para que vincule las instancias persistidas en la BD y no cree una nueva
                    db.Entry(p.PolizaCuota).State = System.Data.Entity.EntityState.Unchanged;
                    db.Entry(p.Usuario).State = System.Data.Entity.EntityState.Unchanged;
                    
                    db.PolizaReciboes.Add(p);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }
    }
}
