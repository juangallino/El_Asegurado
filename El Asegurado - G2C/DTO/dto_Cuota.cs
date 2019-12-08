using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_Cuota
    {
        public int IdCuota { get; set; }
        public int NroCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal ImporteCuota { get; set; }
        public decimal ImporteRecargo { get; set; }
        public decimal ImporteDescuento { get; set; }
    }
}
