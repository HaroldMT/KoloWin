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
    
    public partial class BusinessContactUpdateHistory
    {
        public int IdBusinessContactUpdateHistory { get; set; }
        public int IdBusiness { get; set; }
        public int IdContact { get; set; }
        public string OldJobTitle { get; set; }
        public string NewJobTitle { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Business Business { get; set; }
        public virtual Person Person { get; set; }
    }
}
