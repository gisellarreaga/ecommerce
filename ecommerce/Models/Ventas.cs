//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        public int Id { get; set; }
        public Nullable<int> Fk_Producto { get; set; }
        public Nullable<int> Fk_Usuario { get; set; }
        public Nullable<System.DateTime> Fecha_Compra { get; set; }
        public Nullable<System.DateTime> Fecha_Entrega_Maxima { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<System.DateTime> Direccion_Entrega { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
