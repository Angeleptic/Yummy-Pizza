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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Invoices = new HashSet<Invoice>();
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public int Order_ID { get; set; }
        public Nullable<decimal> Order_No { get; set; }
        public Nullable<int> Order_Status_ID { get; set; }
        public Nullable<int> Order_Type_ID { get; set; }
        public string Order_Date { get; set; }
        public Nullable<decimal> OTotal { get; set; }
        public Nullable<int> Emp_Shift_ID { get; set; }
        public Nullable<int> User_ID { get; set; }
    
        public virtual Employee_Shift Employee_Shift { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual Order_Status Order_Status { get; set; }
        public virtual Order_Type Order_Type { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
