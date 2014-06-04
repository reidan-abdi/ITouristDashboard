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
    
    public partial class Region
    {
        public Region()
        {
            this.Places = new HashSet<Place>();
        }
    
        public int Id { get; set; }
        public int Name { get; set; }
        public int CountryId { get; set; }
        public string Image { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Place> Places { get; set; }
        public virtual Translation Translation { get; set; }
    }
}
