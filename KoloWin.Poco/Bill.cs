//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KoloWin.Poco
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int IdBill { get; set; }
        public int IdIssuingCustomer { get; set; }
        public int IdPayingCustomer { get; set; }
        public string CodeRefFactureType { get; set; }
        public string CodeRefBillStatus { get; set; }
        public System.DateTime DateIssued { get; set; }
        public int TotalBillAmount { get; set; }
        public int LeftToPay { get; set; }
    
        public virtual RefBillStatu RefBillStatu { get; set; }
        public virtual RefBillType RefBillType { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
    }
}
