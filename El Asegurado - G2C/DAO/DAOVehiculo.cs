using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Data;


namespace DAO
{
    public class DAOVehiculo
    {
        public Vehiculo Get(int id)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                var vehiculo = new Vehiculo();
                vehiculo = db.Vehiculoes.Find(id);
                return vehiculo;
            }
        }
        public void GuardarVehiculo(Vehiculo vehiculo)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                db.Vehiculoes.Add(vehiculo);
                db.SaveChanges();
            }

        }


    }
}
