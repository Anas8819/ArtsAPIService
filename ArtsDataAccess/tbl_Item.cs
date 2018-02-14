//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtsDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Item()
        {
            this.tbl_ItemDetail = new HashSet<tbl_ItemDetail>();
            this.tbl_Shipping = new HashSet<tbl_Shipping>();
            this.tbl_User = new HashSet<tbl_User>();
        }
    
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        public int CategoryId { get; set; }
    
        public virtual tbl_Category tbl_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ItemDetail> tbl_ItemDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Shipping> tbl_Shipping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_User> tbl_User { get; set; }
    }
}
