using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class dto_busquedaPoliza
    {
        public decimal NroCliente { get; set; }
        public decimal NroPoliza { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public string TipoDoc { get; set; }
        public decimal NroDoc { get; set; }
        public DateTime UltimoPago { get; set; }
        public decimal MontoUltimoPago { get; set; }

    }
}
