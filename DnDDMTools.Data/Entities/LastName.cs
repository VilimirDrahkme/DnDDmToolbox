//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DnDDMTools.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class LastName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LastName()
        {
            this.WholeNames = new HashSet<WholeName>();
        }
    
        public int Id { get; set; }
        public string LastName1 { get; set; }
        public int RaceId { get; set; }
        public Nullable<int> GenderId { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Race Race { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WholeName> WholeNames { get; set; }
    }
}
