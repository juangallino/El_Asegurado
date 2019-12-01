using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace DAO
{
  public class DAOHijo
    {
        public PolizaHijo get(int id)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.PolizaHijoes.Find(id);                
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<PolizaHijo> GetHijos(int idPoliza)
        {
            try
            {
                using (DBEntities_TP db = new DBEntities_TP())
                {
                    return db.PolizaHijoes.AsNoTracking().Where(p => p.idPoliza == idPoliza).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }



        }
    }
}
