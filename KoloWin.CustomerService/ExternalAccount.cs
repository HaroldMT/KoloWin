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
    
    public partial class ExternalAccount
    {
        public int IdExternalAccount { get; set; }
        public string ExternalLogin { get; set; }
        public string ExternalPwd { get; set; }
        public string ExternalAccountTypeCode { get; set; }
        public Nullable<int> IdCreditCard { get; set; }
    
        public virtual RefExternalAccountType RefExternalAccountType { get; set; }
        public virtual CreditCardInfo CreditCardInfo { get; set; }
    }
}
