//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiExamen.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Area
    {
        public Area()
        {
            this.Empleadoes = new HashSet<Empleado>();
        }
    
        public int IdArea { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Empleado> Empleadoes { get; set; }
    }
}
