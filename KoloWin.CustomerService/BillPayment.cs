//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KoloWin.CustomerService
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillPayment
    {
        public int IdBillPayment { get; set; }
        public int IdBill { get; set; }
        public int IdPayingCustomer { get; set; }
        public int IdIssuingCustomer { get; set; }
        public System.DateTime DatePaid { get; set; }
        public Nullable<int> PaidAmount { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Customer Issuer { get; set; }
        public virtual Customer Payer { get; set; }
    }
}