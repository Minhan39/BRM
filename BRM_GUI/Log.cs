//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BRM_GUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int logID { get; set; }
        public int userID { get; set; }
        public string body { get; set; }
        public Nullable<System.DateTime> atCreate { get; set; }
    
        public virtual User User { get; set; }
    }
}
