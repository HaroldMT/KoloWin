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
    
    public partial class GroupImage
    {
        public int IdCustomerGroup { get; set; }
        public byte[] ImageBytes { get; set; }
    
        public virtual CustomerGroup CustomerGroup { get; set; }
    }
}
