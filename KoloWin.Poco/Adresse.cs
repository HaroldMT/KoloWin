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
    
    public partial class Adresse
    {
        public int IdAddress { get; set; }
        public string Line_1 { get; set; }
        public string Line_2 { get; set; }
        public string Line_3 { get; set; }
        public Nullable<int> IdCity { get; set; }
        public string PostCode { get; set; }
        public string AddressTypeCode { get; set; }
    
        public virtual City City { get; set; }
        public virtual RefAddressType RefAddressType { get; set; }
    }
}
