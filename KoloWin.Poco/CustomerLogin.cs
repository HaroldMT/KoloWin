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
    
    public partial class CustomerLogin
    {
        public int IdCustomer { get; set; }
        public string Number { get; set; }
        public Nullable<bool> NumberVerified { get; set; }
        public string EmailAddress { get; set; }
        public bool EmailAddressVerified { get; set; }
        public string PwdSalt { get; set; }
        public string Pwd { get; set; }
        public string RecoveryToken { get; set; }
        public Nullable<System.DateTime> RecoveryTokenExpiryDate { get; set; }
        public string LoginStatusCode { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual RefLoginStatu RefLoginStatu { get; set; }
    }
}
