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
    
    public partial class Extra_Price
    {
        public int Extra_Price_ID { get; set; }
        public Nullable<int> Extra_ID { get; set; }
        public Nullable<int> Price_ID { get; set; }
        public Nullable<System.DateTime> Extra_Price_Date { get; set; }
    
        public virtual Extra Extra { get; set; }
        public virtual Price Price { get; set; }
    }
}
