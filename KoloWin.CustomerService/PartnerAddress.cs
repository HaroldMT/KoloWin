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
    
    public partial class PartnerAddress
    {
        public int IdPartner { get; set; }
        public int IdAddress { get; set; }
        public string AddresseTypeCode { get; set; }
    
        public virtual Adresse Adresse { get; set; }
        public virtual Partner Partner { get; set; }
    }
}