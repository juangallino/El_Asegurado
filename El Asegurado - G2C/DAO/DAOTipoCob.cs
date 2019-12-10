using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Data;

namespace DAO
{
    public class DAOTipoCob
    {
        public TipoCobertura Get(int tipoCobertura)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                var tc = new TipoCobertura();
                tc = db.TipoCoberturas.Find(tipoCobertura);
                return tc;
            }
        }
        public TipoCobertura GetNombre(int idTipoCobertura)
        {
            using (DBEntities_TP db = new DBEntities_TP())
            {
                var tc = new TipoCobertura();
                tc = db.TipoCoberturas.Find(idTipoCobertura);
                return tc;
            }
        }


    }
}
