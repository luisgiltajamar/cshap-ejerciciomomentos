//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcMomentos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Momento = new HashSet<Momento>();
        }
    
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<Momento> Momento { get; set; }
    }
}
