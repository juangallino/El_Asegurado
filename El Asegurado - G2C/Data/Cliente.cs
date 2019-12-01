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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Polizas = new HashSet<Poliza>();
        }
    
        public int id { get; set; }
        public int idPais { get; set; }
        public decimal NroCliente { get; set; }
        public decimal AñoRegistro { get; set; }
        public string CorreoElectronico { get; set; }
        public int idPersona { get; set; }
        public int idProfesion { get; set; }
        public int idSituacionIVA { get; set; }
        public int idEstadoCliente { get; set; }
    
        public virtual EstadoCliente EstadoCliente { get; set; }
        public virtual Pai Pai { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Profesion Profesion { get; set; }
        public virtual SituacionIVA SituacionIVA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Poliza> Polizas { get; set; }
    }
}