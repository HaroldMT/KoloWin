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
    using System.Collections.ObjectModel;
    
    public partial class TransfertGroupScheduled
    {
        public int IdTransfertGroupScheduled { get; set; }
        public int IdReceiverGroup { get; set; }
        public int IdSendingCustomer { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual CustomerGroup CustomerGroup { get; set; }
    }
}
