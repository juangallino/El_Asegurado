using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_PagoPoliza
    {
        public int idPoliza { get; set; }
        public int NroCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime UltimoPago { get; set; }
        public Decimal ImportePago { get; set; }

        public string DatosVehiculo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<dto_Cuota> CuotasPendientes { get; set; }
        public string Patente { get; set; }
    }
}
