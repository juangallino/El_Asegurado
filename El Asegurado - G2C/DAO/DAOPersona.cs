using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace DAO
{
    public class DAOPersona
    {
        public Persona Get(int id)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                Persona persona = new Persona();
                persona = db.Personas.Find(id);
                return persona;
            }
;

        }
    }
}
