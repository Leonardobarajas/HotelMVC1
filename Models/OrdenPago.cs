//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdenPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenPago()
        {
            this.DetalleOrdenPago = new HashSet<DetalleOrdenPago>();
            this.TransaccionesOrdenPago = new HashSet<TransaccionesOrdenPago>();
        }
    
        public int IdOrdenPago { get; set; }
        public System.DateTime FechaHora { get; set; }
        public decimal Total { get; set; }
        public short IdEstado { get; set; }
    
        public virtual CEstados CEstados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleOrdenPago> DetalleOrdenPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaccionesOrdenPago> TransaccionesOrdenPago { get; set; }
    }
}