using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace DAO
{
    public class DAODomicilio
    {

        public Domicilio Get(int id)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Domicilio domicilio = new Domicilio();
                domicilio = db.Domicilios.Find(id);
                return domicilio;
            }

        }
    }
}
