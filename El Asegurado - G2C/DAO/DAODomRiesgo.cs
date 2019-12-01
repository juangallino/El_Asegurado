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
     public class DAODomRiesgo
    {
        public Localidad Get(int id)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Localidad dom = new Localidad();
                dom = db.Localidads.Find(id);
                return dom;
            }

        }


    }
}
