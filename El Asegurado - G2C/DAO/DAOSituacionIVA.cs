using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace DAO
{
    public class DAOSituacionIVA
    {
        public SituacionIVA Get(int id)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                SituacionIVA sitIVA = new SituacionIVA();
                sitIVA = db.SituacionIVAs.Find(id);
                return sitIVA;
            }

        }
    }
}
