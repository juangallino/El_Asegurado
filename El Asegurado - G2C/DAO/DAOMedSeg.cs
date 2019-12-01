using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace DAO
{
    public  class DAOMedSeg
    {
       public MedidaSeguridad get(int id) {
            var db = new DBEntities_TP();
            var ms = new MedidaSeguridad();
           ms = db.MedidaSeguridads.Find(id);
           return ms;
        }
       
    }
}
