//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerClient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LIDDesignType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIDDesignType()
        {
            this.LIDs = new HashSet<LID>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public string BMPType { get; set; }
    
        public virtual BMPType BMPType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LID> LIDs { get; set; }
    }
}
