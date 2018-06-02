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
    
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        public string CustomerTypeCode { get; set; }
        public string CurrencyCode { get; set; }
        public int Balance { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<int> IdRegistration { get; set; }
    
        public virtual Currency Currency { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual RefCustomerType RefCustomerType { get; set; }
        public virtual MobileDevice MobileDevice { get; set; }
        public virtual CustomerImage CustomerImage { get; set; }
        public virtual CustomerLogin CustomerLogin { get; set; }
        public virtual Partner Partner { get; set; }
        public virtual Person Person { get; set; }
    }
}
