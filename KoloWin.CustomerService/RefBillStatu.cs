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
    
    public partial class RefBillStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefBillStatu()
        {
            this.Bills = new ObservableCollection<Bill>();
        }
    
        public string BillStatusCode { get; set; }
        public string BillStatusDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<Bill> Bills { get; set; }
    }
}
