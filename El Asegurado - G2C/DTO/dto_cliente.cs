using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class dto_cliente
    {
        public int IdCliente { get; set; }
        public decimal AñoRegistro { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string TipoDoc { get; set; }
        public decimal NroDocumento { get; set; }
        public decimal NroCuil { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_nac { get; set; }
        public string Calle { get; set; }
        public decimal NumeroDomicilio { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public decimal CodPostal { get; set; }
        public string SituacionIVA { get; set; }
        public string Email { get; set; }
        public string EstadoCivil { get; set; }
        public string Profesion { get; set; }
    }
}
