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
    
    public partial class KoloNotification
    {
        public int IdNotification { get; set; }
        public int IdCustomer { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public System.DateTime CreationDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<bool> Readed { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}