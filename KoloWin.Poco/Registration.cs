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
    
    public partial class Registration
    {
        public int IdRegistration { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }
        public string Email { get; set; }
        public string RegistrationToken { get; set; }
        public string RegistrationStatusCode { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public Nullable<System.DateTime> RegistrationConfirmDate { get; set; }
        public string SimSubscriberId { get; set; }
        public string SimSerialNumber { get; set; }
        public string OperatorDeviceSim { get; set; }
        public Nullable<System.DateTime> RegistrationTokenExpiryDate { get; set; }
        public string Pwd { get; set; }
        public string DeviceId { get; set; }
    
        public virtual RefRegistrationStatu RefRegistrationStatu { get; set; }
    }
}
