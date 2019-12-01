using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace DAO
{
    public class DAOModelo
    {
        public Modelo Get(int id)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Modelo mod = new Modelo();
                mod = db.Modeloes.Find(id);
                return mod;
            }
        }

        
    }
}
