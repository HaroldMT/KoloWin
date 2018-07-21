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
    
    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            this.AccountOperations = new ObservableCollection<AccountOperation>();
            this.PartnerAddresses = new ObservableCollection<PartnerAddress>();
            this.Provisions = new ObservableCollection<Provision>();
            this.Provisions1 = new ObservableCollection<Provision>();
            this.Transfert2Cash = new ObservableCollection<Transfert2Cash>();
        }
    
        public int IdPartner { get; set; }
        public string PartnerTypeCode { get; set; }
        public string CurrencyCode { get; set; }
        public int Balance { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<AccountOperation> AccountOperations { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual RefPartnerType RefPartnerType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<PartnerAddress> PartnerAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<Provision> Provisions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<Provision> Provisions1 { get; set; }
        public virtual Reseller Reseller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<Transfert2Cash> Transfert2Cash { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }
    }
}
