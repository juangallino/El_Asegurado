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
    
    public partial class PolizaCuota
    {
        public int id { get; set; }
        public int idPoliza { get; set; }
        public int nroCuota { get; set; }
        public System.DateTime fechaVencimiento { get; set; }
        public Nullable<decimal> importeCuota { get; set; }
        public Nullable<decimal> importeRecargo { get; set; }
        public Nullable<decimal> importeDescuento { get; set; }
        public Nullable<int> idPolizaRecibo { get; set; }
    
        public virtual Poliza Poliza { get; set; }
        public virtual PolizaRecibo PolizaRecibo { get; set; }
    }
}
