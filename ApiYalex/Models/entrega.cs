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
    
    public partial class entrega
    {
        public int id_entrega { get; set; }
        public string kilometraje { get; set; }
        public string descripestado_entrega { get; set; }
        public string descripestado_devolucion { get; set; }
        public byte[] imagenestado_entrega { get; set; }
        public byte[] imagenestado_devolucion { get; set; }
        public string fecha_entrega { get; set; }
        public string fecha_devolucion { get; set; }
        public int id_cliente { get; set; }
        public int id_empleado { get; set; }
        public int id_vehiculo { get; set; }
        public int id_contrato { get; set; }
    
        public virtual clientes clientes { get; set; }
        public virtual contratos contratos { get; set; }
        public virtual empleado empleado { get; set; }
        public virtual vehiculo vehiculo { get; set; }
    }
}
