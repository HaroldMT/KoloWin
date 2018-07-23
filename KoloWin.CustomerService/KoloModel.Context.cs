﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KoloAndroidEntities : DbContext
    {
        public KoloAndroidEntities()
            : base("name=KoloAndroidEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountOperation> AccountOperations { get; set; }
        public virtual DbSet<AccountOperationRequest> AccountOperationRequests { get; set; }
        public virtual DbSet<Adresse> Adresses { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<BillPayment> BillPayments { get; set; }
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<BusinessContact> BusinessContacts { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CreditCardInfo> CreditCardInfoes { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerBalanceHistory> CustomerBalanceHistories { get; set; }
        public virtual DbSet<CustomerExternalAccount> CustomerExternalAccounts { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }
        public virtual DbSet<CustomerImage> CustomerImages { get; set; }
        public virtual DbSet<CustomerLogin> CustomerLogins { get; set; }
        public virtual DbSet<CustomerTag> CustomerTags { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<EneoBillPayment> EneoBillPayments { get; set; }
        public virtual DbSet<ExternalAccountHistory> ExternalAccountHistories { get; set; }
        public virtual DbSet<GroupImage> GroupImages { get; set; }
        public virtual DbSet<KoloGroup> KoloGroups { get; set; }
        public virtual DbSet<KoloNotification> KoloNotifications { get; set; }
        public virtual DbSet<KoloPermission> KoloPermissions { get; set; }
        public virtual DbSet<KoloSystemAction> KoloSystemActions { get; set; }
        public virtual DbSet<KoloSystemHistory> KoloSystemHistories { get; set; }
        public virtual DbSet<KoloUser> KoloUsers { get; set; }
        public virtual DbSet<LoginAttempt> LoginAttempts { get; set; }
        public virtual DbSet<MobileDevice> MobileDevices { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<PartnerAddress> PartnerAddresses { get; set; }
        public virtual DbSet<PartnerBalanceHistory> PartnerBalanceHistories { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonRelationship> PersonRelationships { get; set; }
        public virtual DbSet<Provision> Provisions { get; set; }
        public virtual DbSet<RecurringContribution> RecurringContributions { get; set; }
        public virtual DbSet<RefAddressType> RefAddressTypes { get; set; }
        public virtual DbSet<RefBillStatu> RefBillStatus { get; set; }
        public virtual DbSet<RefBillType> RefBillTypes { get; set; }
        public virtual DbSet<RefCustomerType> RefCustomerTypes { get; set; }
        public virtual DbSet<RefExternalAccountType> RefExternalAccountTypes { get; set; }
        public virtual DbSet<RefGender> RefGenders { get; set; }
        public virtual DbSet<RefGroupType> RefGroupTypes { get; set; }
        public virtual DbSet<RefIndustryCategory> RefIndustryCategories { get; set; }
        public virtual DbSet<RefLoginStatu> RefLoginStatus { get; set; }
        public virtual DbSet<RefMaritalStatu> RefMaritalStatus { get; set; }
        public virtual DbSet<RefOperationStatu> RefOperationStatus { get; set; }
        public virtual DbSet<RefOperationType> RefOperationTypes { get; set; }
        public virtual DbSet<RefPartnerType> RefPartnerTypes { get; set; }
        public virtual DbSet<RefPersonRelationshipType> RefPersonRelationshipTypes { get; set; }
        public virtual DbSet<RefProvisionStatu> RefProvisionStatus { get; set; }
        public virtual DbSet<RefRegistrationStatu> RefRegistrationStatus { get; set; }
        public virtual DbSet<RefResult> RefResults { get; set; }
        public virtual DbSet<RefTransfertStatu> RefTransfertStatus { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Reseller> Resellers { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TopUp> TopUps { get; set; }
        public virtual DbSet<Transfert2Cash> Transfert2Cash { get; set; }
        public virtual DbSet<Transfert2CashDetails> Transfert2CashDetails { get; set; }
        public virtual DbSet<TransfertE2e> TransfertE2e { get; set; }
        public virtual DbSet<TransfertGroup> TransfertGroups { get; set; }
        public virtual DbSet<TransfertGroupScheduled> TransfertGroupScheduleds { get; set; }
        public virtual DbSet<TransfertP2p> TransfertP2p { get; set; }
        public virtual DbSet<TransfertScheduled> TransfertScheduleds { get; set; }
        public virtual DbSet<Wholesaler> Wholesalers { get; set; }
        public virtual DbSet<TransferGravity> TransferGravities { get; set; }
        public virtual DbSet<ExternalAccount> ExternalAccounts { get; set; }
    }
}
