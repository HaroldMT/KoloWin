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
    
    public partial class TransfertGroup
    {
        public int IdTransfertGroup { get; set; }
        public int IdReceiverGroup { get; set; }
        public int IdSendingCustomer { get; set; }
        public int Amount { get; set; }
        public string CodeTransfertStatus { get; set; }
        public string Reference { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual RefTransfertStatu RefTransfertStatu { get; set; }
    }
}
