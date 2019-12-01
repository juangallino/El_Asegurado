using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_hijo
    {
        public dto_hijo()
        {
            Id = new Random().Next(1, 32000);
        }
        public int Id { get; set; }
        public int IdSexo { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_nac { get; set; }
        public int IdEstadoCivil { get; set; }
        public string EstadoCivil { get; set; }
    }
}
