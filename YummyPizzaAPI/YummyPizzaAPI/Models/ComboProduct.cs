//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YummyPizzaAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ComboProduct
    {
        public int ComboProduct_ID { get; set; }
        public Nullable<int> Combo_ID { get; set; }
        public Nullable<int> Pizza_ID { get; set; }
        public Nullable<int> Size_ID { get; set; }
        public Nullable<int> Base_ID { get; set; }
        public Nullable<int> Extra_ID { get; set; }
    
        public virtual Base Base { get; set; }
        public virtual Combo Combo { get; set; }
        public virtual Extra Extra { get; set; }
        public virtual Pizza Pizza { get; set; }
        public virtual Size Size { get; set; }
    }
}
