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
    
    public partial class ValorFactorAutoScoringHist
    {
        public int id { get; set; }
        public int idValorFactorAutoscoring { get; set; }
        public decimal valorPorcentual { get; set; }
        public int idUsuario { get; set; }
        public System.DateTime FechaModificacion { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual ValorFactorAutoScoring ValorFactorAutoScoring { get; set; }
    }
}
