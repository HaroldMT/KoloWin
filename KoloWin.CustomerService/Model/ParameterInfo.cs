using System.Collections.Generic;
using System.Linq;

namespace KoloWin.CustomerService.Model
{
    public class ParameterInfo
    {
        public List<Currency> CurrencyList { get; set; } = new List<Currency>();

        public List<RefAddressType> RefAddressTypes { get; set; } = new List<RefAddressType>();

        public List<RefBillStatu> RefBillStatus { get; set; } = new List<RefBillStatu>();

        public List<RefBillType> RefBillTypes { get; set; } = new List<RefBillType>();

        public List<RefCustomerType> RefCustomerTypes { get; set; } = new List<RefCustomerType>();

        public List<RefExternalAccountType> RefExternalAccountTypes { get; set; } = new List<RefExternalAccountType>();

        public List<RefGender> RefGenders { get; set; } = new List<RefGender>();

        public List<RefGroupType> RefGroupTypes { get; set; } = new List<RefGroupType>();

        public List<RefIndustryCategory> RefIndustryCategorys { get; set; } = new List<RefIndustryCategory>();

        public List<RefLoginStatu> RefLoginStatus { get; set; } = new List<RefLoginStatu>();

        public List<RefMaritalStatu> RefMaritalStatus { get; set; } = new List<RefMaritalStatu>();

        public List<RefOperationStatu> RefOperationStatus { get; set; } = new List<RefOperationStatu>();

        public List<RefOperationType> RefOperationTypes { get; set; } = new List<RefOperationType>();

        public List<RefPartnerType> RefPartnerTypes { get; set; } = new List<RefPartnerType>();

        public List<RefPersonRelationshipType> RefPersonRelationshipTypes { get; set; } = new List<RefPersonRelationshipType>();

        public List<RefProvisionStatu> RefProvisionStatus { get; set; } = new List<RefProvisionStatu>();

        public List<RefRegistrationStatu> RefRegistrationStatus { get; set; } = new List<RefRegistrationStatu>();

        public List<RefResult> RefResults { get; set; } = new List<RefResult>();

        public List<RefTransfertStatu> RefTransfertStatus { get; set; } = new List<RefTransfertStatu>();

        public void Refresh(KoloAndroidEntities db, out string error)
        {
            this.CurrencyList = db.Currencies.AsNoTracking().ToList();
            this.RefAddressTypes = db.RefAddressTypes.AsNoTracking().ToList();
            this.RefBillStatus = db.RefBillStatus.AsNoTracking().ToList();
            this.RefBillTypes = db.RefBillTypes.AsNoTracking().ToList();
            this.RefCustomerTypes = db.RefCustomerTypes.AsNoTracking().ToList();
            this.RefExternalAccountTypes = db.RefExternalAccountTypes.AsNoTracking().ToList();
            this.RefGenders = db.RefGenders.AsNoTracking().ToList();
            this.RefGroupTypes = db.RefGroupTypes.AsNoTracking().ToList();
            this.RefIndustryCategorys = db.RefIndustryCategories.AsNoTracking().ToList();
            this.RefLoginStatus = db.RefLoginStatus.AsNoTracking().ToList();
            this.RefMaritalStatus = db.RefMaritalStatus.AsNoTracking().ToList();
            this.RefOperationStatus = db.RefOperationStatus.AsNoTracking().ToList();
            this.RefOperationTypes = db.RefOperationTypes.AsNoTracking().ToList();
            this.RefPartnerTypes = db.RefPartnerTypes.AsNoTracking().ToList();
            this.RefPersonRelationshipTypes = db.RefPersonRelationshipTypes.AsNoTracking().ToList();
            this.RefProvisionStatus = db.RefProvisionStatus.AsNoTracking().ToList();
            this.RefRegistrationStatus = db.RefRegistrationStatus.AsNoTracking().ToList();
            this.RefResults = db.RefResults.AsNoTracking().ToList();
            this.RefTransfertStatus = db.RefTransfertStatus.AsNoTracking().ToList();
            error = "";
        }
    }
}