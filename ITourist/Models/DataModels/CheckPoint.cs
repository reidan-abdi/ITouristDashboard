//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITourist.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckPoint
    {
        public CheckPoint()
        {
            this.CheckIns = new HashSet<CheckIn>();
        }
    
        public int Id { get; set; }
        public double AverageTime { get; set; }
        public int RouteId { get; set; }
        public int PlaceId { get; set; }
    
        public virtual ICollection<CheckIn> CheckIns { get; set; }
        public virtual Place Place { get; set; }
        public virtual Route Route { get; set; }
    }
}