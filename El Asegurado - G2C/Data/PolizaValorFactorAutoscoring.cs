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
    
    public partial class PolizaValorFactorAutoscoring
    {
        public int id { get; set; }
        public int idValorFactorAutoscoring { get; set; }
        public int idPoliza { get; set; }
        public decimal ValorPorcentual { get; set; }
    
        public virtual Poliza Poliza { get; set; }
    }
}
