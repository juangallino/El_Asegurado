//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PolizaRenovacionHijo
    {
        public int id { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public int idSexo { get; set; }
        public int idEstadoCivil { get; set; }
        public int idPolizaRenovacion { get; set; }
    
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual PolizaRenovacion PolizaRenovacion { get; set; }
        public virtual Sexo Sexo { get; set; }
    }
}
