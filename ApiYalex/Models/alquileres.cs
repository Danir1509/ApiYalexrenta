//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiYalex.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class alquileres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alquileres()
        {
            this.contratos = new HashSet<contratos>();
        }
    
        public int id_alquiler { get; set; }
        public int id_cliente { get; set; }
        public decimal costoalquiler { get; set; }
        public string estado { get; set; }
        public int id_vehiculo { get; set; }
        public string inicio_alquiler { get; set; }
        public string finalizacion_alquiler { get; set; }
    
        public virtual clientes clientes { get; set; }
        public virtual vehiculo vehiculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contratos> contratos { get; set; }
    }
}
