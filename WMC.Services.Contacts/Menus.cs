//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMC.Services.Contacts
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menus
    {
        public int MenuId { get; set; }
        public Nullable<int> ParentMenuId { get; set; }
        public Nullable<int> ActionId { get; set; }
        public string MenuName { get; set; }
        public int PageRank { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public int CreateUserId { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}