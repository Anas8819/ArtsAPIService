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
    
    public partial class tbl_ArtistPostDetail
    {
        public int PostId { get; set; }
        public string PostImage { get; set; }
        public int ArtistPostDetailId { get; set; }
    
        public virtual tbl_ArtistPost tbl_ArtistPost { get; set; }
    }
}