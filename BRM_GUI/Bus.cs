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
    
    public partial class Bus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bus()
        {
            this.BusConnectingRoutes = new HashSet<BusConnectingRoute>();
            this.BusDelays = new HashSet<BusDelay>();
            this.BusGuides = new HashSet<BusGuide>();
            this.HandlingViolations = new HashSet<HandlingViolation>();
            this.SupportPrices = new HashSet<SupportPrice>();
        }
    
        public int busId { get; set; }
        public string taxCode { get; set; }
        public string licensePlate { get; set; }
        public Nullable<int> seats { get; set; }
        public int busDistributorId { get; set; }
        public int busTypeId { get; set; }
        public Nullable<System.DateTime> atCreate { get; set; }
        public Nullable<System.DateTime> atUpdate { get; set; }
    
        public virtual BusDistributor BusDistributor { get; set; }
        public virtual BusType BusType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusConnectingRoute> BusConnectingRoutes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusDelay> BusDelays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusGuide> BusGuides { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HandlingViolation> HandlingViolations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupportPrice> SupportPrices { get; set; }
    }
}
