using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace DAO
{
    public class DAOprofesion
    {

        public Profesion Get(int id)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Profesion profesion = new Profesion();
                profesion = db.Profesions.Find(id);
                return profesion;
            }
        }
    }
}