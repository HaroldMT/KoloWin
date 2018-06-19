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
    
    public partial class TransfertP2p
    {
        public int IdTransfertP2p { get; set; }
        public int IdSendingCustomer { get; set; }
        public Nullable<int> IdReceiverCustomer { get; set; }
        public Nullable<int> IdTransfertScheduled { get; set; }
        public string TransfertStatusCode { get; set; }
        public int Amount { get; set; }
        public bool NeedsConfirmation { get; set; }
        public string Secret { get; set; }
        public System.DateTime TransfertDate { get; set; }
        public string Reference { get; set; }
        public bool Transfert2Cash { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public Nullable<System.DateTime> ConfirmationDate { get; set; }
        public Nullable<System.DateTime> CancelationDate { get; set; }
    
        public virtual Customer Receiver { get; set; }
        public virtual Customer Sender { get; set; }
    }
}