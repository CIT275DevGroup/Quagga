//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace openTill.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public Address()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public int ZipId { get; set; }
    
        public virtual State State { get; set; }
        public virtual ZipCode ZipCode { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
