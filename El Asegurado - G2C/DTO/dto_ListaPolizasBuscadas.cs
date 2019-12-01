using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_ListaPolizasBuscadas
    {
        public int id { get; set; }
        public int PolizaNumero { get; set; }
        public string Cliente { get; set; }
        public string Vehiculo { get; set; }
        public string Patente { get; set; }
        public string Motor { get; set; }
        public string Chasis { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }       
       
    }
}
