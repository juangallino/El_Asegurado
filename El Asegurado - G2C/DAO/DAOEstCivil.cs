using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using DTO;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOEstCivil
    {
        public EstadoCivil Get(int id)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                EstadoCivil ec = new EstadoCivil();
                ec = db.EstadoCivils.Find(id);
                return ec;
            }

        }

    }
}
