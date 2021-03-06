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
    
    public partial class KoloUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KoloUser()
        {
            this.KoloSystemHistories = new ObservableCollection<KoloSystemHistory>();
        }
    
        public int IdCustomer { get; set; }
        public string UserLogin { get; set; }
        public string Number { get; set; }
        public Nullable<bool> NumberVerified { get; set; }
        public string EmailAddress { get; set; }
        public bool EmailAddressVerified { get; set; }
        public string PwdSalt { get; set; }
        public string Pwd { get; set; }
        public string RecoveryToken { get; set; }
        public Nullable<System.DateTime> RecoveryTokenExpiryDate { get; set; }
        public string LoginStatusCode { get; set; }
        public Nullable<bool> MasterUser { get; set; }
        public string GroupCode { get; set; }
    
        public virtual KoloGroup KoloGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<KoloSystemHistory> KoloSystemHistories { get; set; }
        public virtual Person Person { get; set; }
        public virtual RefLoginStatu RefLoginStatu { get; set; }
    }
}
