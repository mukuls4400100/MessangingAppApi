//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessangingAppApi1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ChannelId { get; set; }
        public string UserName { get; set; }
        public System.DateTime CreatedAt { get; set; }
    }
}