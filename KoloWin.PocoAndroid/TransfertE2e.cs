//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KoloWin.PocoAndroid
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransfertE2e
    {
        public int IdTransfertE2e { get; set; }
        public int IdCustomer { get; set; }
        public int IdSendingExternalAccount { get; set; }
        public int IdReceiverExternalAccount { get; set; }
        public string TransfertStatusCode { get; set; }
        public int Amount { get; set; }
        public string OperationTypeCode { get; set; }
        public string Reference { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ExternalAccount ExternalReceiver { get; set; }
        public virtual ExternalAccount ExternalSender { get; set; }
        public virtual RefOperationType RefOperationType { get; set; }
        public virtual RefTransfertStatu RefTransfertStatu { get; set; }
    }
}
