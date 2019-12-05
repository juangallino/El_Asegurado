using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_ListaClientesBuscados
    {
        public int Id { get; set; }
        public decimal IdCliente { get; set; }
        public decimal AñoRegistro { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string TipoDoc { get; set; }
        public Nullable<decimal> NroDocumento { get; set; }

        }
}
