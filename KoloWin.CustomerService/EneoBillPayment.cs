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
    
    public partial class EneoBillPayment
    {
        public int IdEneoBillPayment { get; set; }
        public int IdCustomer { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public string ContractNo { get; set; }
        public string BillNumber { get; set; }
        public int Fee { get; set; }
        public int Ccion { get; set; }
        public int BillAmount { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}