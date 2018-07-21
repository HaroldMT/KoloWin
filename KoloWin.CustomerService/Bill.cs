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
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.BillDetails = new ObservableCollection<BillDetail>();
            this.BillPayments = new ObservableCollection<BillPayment>();
        }
    
        public int IdBill { get; set; }
        public int IdIssuingCustomer { get; set; }
        public int IdPayingCustomer { get; set; }
        public string CodeRefBillType { get; set; }
        public string CodeRefBillStatus { get; set; }
        public System.DateTime DateIssued { get; set; }
        public int TotalBillAmount { get; set; }
        public int LeftToPay { get; set; }
        public bool AllowPartialPayment { get; set; }
    
        public virtual RefBillStatu RefBillStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<BillDetail> BillDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<BillPayment> BillPayments { get; set; }
        public virtual RefBillType RefBillType { get; set; }
        public virtual Customer IssuingCustomer { get; set; }
        public virtual Customer PayingCustomer { get; set; }
    }
}
