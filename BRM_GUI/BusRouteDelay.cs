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
    
    public partial class BusRouteDelay
    {
        public int delayId { get; set; }
        public int busRouteId { get; set; }
        public System.DateTime timeStartDelay { get; set; }
        public System.DateTime timeEndDelay { get; set; }
        public Nullable<System.DateTime> atCreate { get; set; }
        public Nullable<System.DateTime> atUpdate { get; set; }
    
        public virtual BusRoute BusRoute { get; set; }
        public virtual Delay Delay { get; set; }
    }
}
