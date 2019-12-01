using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class dto_busquedaPoliza
    {
    
     public string nroPoliza { get; set; }
        public string nombreCliente { get; set; }
        public int idestado { get; set; }
        public int idmarca{ get; set; }
        public int idmodelo { get; set; }
        public DateTime fdesde { get; set; }
        public DateTime fhasta { get; set; }
}
}
