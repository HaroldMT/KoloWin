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
    
    public partial class ExternalAccountHistory
    {
        public int IdAccountHistory { get; set; }
        public int IdExternalAccount { get; set; }
        public string OperationTypeCode { get; set; }
        public System.DateTime HistoryDate { get; set; }
        public int OldBalance { get; set; }
        public int NewBalance { get; set; }
        public int Amount { get; set; }
    
        public virtual ExternalAccount ExternalAccount { get; set; }
    }
}