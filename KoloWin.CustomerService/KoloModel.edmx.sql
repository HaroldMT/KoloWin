
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/28/2018 14:20:46
-- Generated from EDMX file: D:\Cyberix\Windows_Projects\KoloWin\KoloWin.CustomerService\KoloModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Kolo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[fk_AccountOperation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountOperation] DROP CONSTRAINT [fk_AccountOperation];
GO
IF OBJECT_ID(N'[dbo].[fk_AccountOperation_2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountOperation] DROP CONSTRAINT [fk_AccountOperation_2];
GO
IF OBJECT_ID(N'[dbo].[fk_AccountOperation_3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountOperation] DROP CONSTRAINT [fk_AccountOperation_3];
GO
IF OBJECT_ID(N'[dbo].[fk_AccountOperation_History]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountOperation] DROP CONSTRAINT [fk_AccountOperation_History];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountOperation_Request]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountOperation] DROP CONSTRAINT [FK_AccountOperation_Request];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountOperationRequest_RefOperationStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountOperationRequest] DROP CONSTRAINT [FK_AccountOperationRequest_RefOperationStatus];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountOperationRequest_RefOperationType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountOperationRequest] DROP CONSTRAINT [FK_AccountOperationRequest_RefOperationType];
GO
IF OBJECT_ID(N'[dbo].[fk_Adresse_City]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Adresse] DROP CONSTRAINT [fk_Adresse_City];
GO
IF OBJECT_ID(N'[dbo].[FK_Adresse_RefAddressType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Adresse] DROP CONSTRAINT [FK_Adresse_RefAddressType];
GO
IF OBJECT_ID(N'[dbo].[fk_Bill]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [fk_Bill];
GO
IF OBJECT_ID(N'[dbo].[fk_BillPayement_Bill]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillPayment] DROP CONSTRAINT [fk_BillPayement_Bill];
GO
IF OBJECT_ID(N'[dbo].[fk_BillPayment_IssuingCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillPayment] DROP CONSTRAINT [fk_BillPayment_IssuingCustomer];
GO
IF OBJECT_ID(N'[dbo].[fk_BillPayment_PayingCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillPayment] DROP CONSTRAINT [fk_BillPayment_PayingCustomer];
GO
IF OBJECT_ID(N'[dbo].[fk_Business]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Business] DROP CONSTRAINT [fk_Business];
GO
IF OBJECT_ID(N'[dbo].[fk_Business_IndustryCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Business] DROP CONSTRAINT [fk_Business_IndustryCategory];
GO
IF OBJECT_ID(N'[dbo].[fk_BusinessContact_Business]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinessContact] DROP CONSTRAINT [fk_BusinessContact_Business];
GO
IF OBJECT_ID(N'[dbo].[fk_BusinessContact_Contact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinessContact] DROP CONSTRAINT [fk_BusinessContact_Contact];
GO
IF OBJECT_ID(N'[dbo].[fk_City]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[City] DROP CONSTRAINT [fk_City];
GO
IF OBJECT_ID(N'[dbo].[fk_City_0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[City] DROP CONSTRAINT [fk_City_0];
GO
IF OBJECT_ID(N'[dbo].[fk_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [fk_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_Customer_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [fk_Customer_Currency];
GO
IF OBJECT_ID(N'[dbo].[fk_Customer_CustomerType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [fk_Customer_CustomerType];
GO
IF OBJECT_ID(N'[dbo].[fk_Customer_ExternalAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerExternalAccount] DROP CONSTRAINT [fk_Customer_ExternalAccount];
GO
IF OBJECT_ID(N'[dbo].[fk_Customer_Mobile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MobileDevice] DROP CONSTRAINT [fk_Customer_Mobile];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerAddress]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerAddress] DROP CONSTRAINT [fk_CustomerAddress];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerAddress_0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerAddress] DROP CONSTRAINT [fk_CustomerAddress_0];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerBalanceHistory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerBalanceHistory] DROP CONSTRAINT [fk_CustomerBalanceHistory];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerBalanceHistory_0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerBalanceHistory] DROP CONSTRAINT [fk_CustomerBalanceHistory_0];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerGroup_GroupType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerGroup] DROP CONSTRAINT [fk_CustomerGroup_GroupType];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerGroup_MemberAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerGroup] DROP CONSTRAINT [fk_CustomerGroup_MemberAccount];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerGroupAdmin_AdminAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerGroupAdmin] DROP CONSTRAINT [fk_CustomerGroupAdmin_AdminAccount];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerGroupAdmin_CustomerGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerGroupAdmin] DROP CONSTRAINT [fk_CustomerGroupAdmin_CustomerGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerImage_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerImage] DROP CONSTRAINT [FK_CustomerImage_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerLogin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerLogin] DROP CONSTRAINT [fk_CustomerLogin];
GO
IF OBJECT_ID(N'[dbo].[fk_CustomerLogin_StatusCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerLogin] DROP CONSTRAINT [fk_CustomerLogin_StatusCode];
GO
IF OBJECT_ID(N'[dbo].[fk_customertags_customeraccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerTags] DROP CONSTRAINT [fk_customertags_customeraccount];
GO
IF OBJECT_ID(N'[dbo].[fk_customertags_tag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerTags] DROP CONSTRAINT [fk_customertags_tag];
GO
IF OBJECT_ID(N'[dbo].[FK_EneoBillPayment_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EneoBillPayment] DROP CONSTRAINT [FK_EneoBillPayment_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_ExternalAccount_History]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExternalAccountHistory] DROP CONSTRAINT [fk_ExternalAccount_History];
GO
IF OBJECT_ID(N'[dbo].[fk_ExternalAccount_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExternalAccount] DROP CONSTRAINT [fk_ExternalAccount_Type];
GO
IF OBJECT_ID(N'[dbo].[fk_Facture]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [fk_Facture];
GO
IF OBJECT_ID(N'[dbo].[fk_Facture_IssuingCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [fk_Facture_IssuingCustomer];
GO
IF OBJECT_ID(N'[dbo].[fk_Facture_PayingCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [fk_Facture_PayingCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_GroupImage_CustomerGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupImage] DROP CONSTRAINT [FK_GroupImage_CustomerGroup];
GO
IF OBJECT_ID(N'[dbo].[fk_LoginAttempt_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoginAttempt] DROP CONSTRAINT [fk_LoginAttempt_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_LoginAttempt_ResultCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoginAttempt] DROP CONSTRAINT [fk_LoginAttempt_ResultCode];
GO
IF OBJECT_ID(N'[dbo].[fk_Notification_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KoloNotification] DROP CONSTRAINT [fk_Notification_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_OperationRequest_CustomerAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccountOperationRequest] DROP CONSTRAINT [fk_OperationRequest_CustomerAccount];
GO
IF OBJECT_ID(N'[dbo].[fk_Partner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Partner] DROP CONSTRAINT [fk_Partner];
GO
IF OBJECT_ID(N'[dbo].[fk_Partner_0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Partner] DROP CONSTRAINT [fk_Partner_0];
GO
IF OBJECT_ID(N'[dbo].[fk_Partner_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Partner] DROP CONSTRAINT [fk_Partner_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_PartnerAddress_Address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PartnerAddress] DROP CONSTRAINT [fk_PartnerAddress_Address];
GO
IF OBJECT_ID(N'[dbo].[fk_PartnerAddress_Partner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PartnerAddress] DROP CONSTRAINT [fk_PartnerAddress_Partner];
GO
IF OBJECT_ID(N'[dbo].[fk_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Person] DROP CONSTRAINT [fk_Person];
GO
IF OBJECT_ID(N'[dbo].[fk_Person_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Person] DROP CONSTRAINT [fk_Person_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_Person_Gender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Person] DROP CONSTRAINT [fk_Person_Gender];
GO
IF OBJECT_ID(N'[dbo].[fk_Person_MaritalStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Person] DROP CONSTRAINT [fk_Person_MaritalStatus];
GO
IF OBJECT_ID(N'[dbo].[fk_Provision_History]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Provision] DROP CONSTRAINT [fk_Provision_History];
GO
IF OBJECT_ID(N'[dbo].[fk_Provision_ResellerPartnerAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Provision] DROP CONSTRAINT [fk_Provision_ResellerPartnerAccount];
GO
IF OBJECT_ID(N'[dbo].[fk_Provision_StatusCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Provision] DROP CONSTRAINT [fk_Provision_StatusCode];
GO
IF OBJECT_ID(N'[dbo].[fk_Provision_WholesalerPartnerAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Provision] DROP CONSTRAINT [fk_Provision_WholesalerPartnerAccount];
GO
IF OBJECT_ID(N'[dbo].[fk_RecurringContribution_CustomerGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RecurringContribution] DROP CONSTRAINT [fk_RecurringContribution_CustomerGroup];
GO
IF OBJECT_ID(N'[dbo].[fk_RecurringContribution_TreasuererCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RecurringContribution] DROP CONSTRAINT [fk_RecurringContribution_TreasuererCustomer];
GO
IF OBJECT_ID(N'[dbo].[fk_Registration]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Registration] DROP CONSTRAINT [fk_Registration];
GO
IF OBJECT_ID(N'[dbo].[fk_Relationship_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonRelationship] DROP CONSTRAINT [fk_Relationship_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_Relationship_PersonRelation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonRelationship] DROP CONSTRAINT [fk_Relationship_PersonRelation];
GO
IF OBJECT_ID(N'[dbo].[fk_Relationship_TypeCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonRelationship] DROP CONSTRAINT [fk_Relationship_TypeCode];
GO
IF OBJECT_ID(N'[dbo].[fk_Reseller]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reseller] DROP CONSTRAINT [fk_Reseller];
GO
IF OBJECT_ID(N'[dbo].[FK_TopUp_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TopUp] DROP CONSTRAINT [FK_TopUp_Customer];
GO
IF OBJECT_ID(N'[KoloModelStoreContainer].[FK_TransferGravity_Customer]', 'F') IS NOT NULL
    ALTER TABLE [KoloModelStoreContainer].[TransferGravity] DROP CONSTRAINT [FK_TransferGravity_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_Transfert2Cash_PartnerAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfert2Cash] DROP CONSTRAINT [fk_Transfert2Cash_PartnerAccount];
GO
IF OBJECT_ID(N'[dbo].[fk_Transfert2CashDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfert2CashDetails] DROP CONSTRAINT [fk_Transfert2CashDetails];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertE2e_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertE2e] DROP CONSTRAINT [fk_TransfertE2e_Customer];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertE2e_ExternalReceiver]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertE2e] DROP CONSTRAINT [fk_TransfertE2e_ExternalReceiver];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertE2e_ExternalSender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertE2e] DROP CONSTRAINT [fk_TransfertE2e_ExternalSender];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertE2e_OperationtType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertE2e] DROP CONSTRAINT [fk_TransfertE2e_OperationtType];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertE2e_StatusCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertE2e] DROP CONSTRAINT [fk_TransfertE2e_StatusCode];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertGroup_ReceiverGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertGroup] DROP CONSTRAINT [fk_TransfertGroup_ReceiverGroup];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertGroup_Sender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertGroup] DROP CONSTRAINT [fk_TransfertGroup_Sender];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertGroup_StatusCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertGroup] DROP CONSTRAINT [fk_TransfertGroup_StatusCode];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertGroupScheduled_ReceiverGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertGroupScheduled] DROP CONSTRAINT [fk_TransfertGroupScheduled_ReceiverGroup];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertGroupScheduled_Sender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertGroupScheduled] DROP CONSTRAINT [fk_TransfertGroupScheduled_Sender];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertP2p_Receiver]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertP2p] DROP CONSTRAINT [fk_TransfertP2p_Receiver];
GO
IF OBJECT_ID(N'[dbo].[FK_TransfertP2p_Sender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertP2p] DROP CONSTRAINT [FK_TransfertP2p_Sender];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertScheduled_Receiver]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertScheduled] DROP CONSTRAINT [fk_TransfertScheduled_Receiver];
GO
IF OBJECT_ID(N'[dbo].[fk_TransfertScheduled_Sender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransfertScheduled] DROP CONSTRAINT [fk_TransfertScheduled_Sender];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KoloUser] DROP CONSTRAINT [FK_User_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_User_RefLoginStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KoloUser] DROP CONSTRAINT [FK_User_RefLoginStatus];
GO
IF OBJECT_ID(N'[dbo].[fk_Wholesaler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Wholesaler] DROP CONSTRAINT [fk_Wholesaler];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AccountOperation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccountOperation];
GO
IF OBJECT_ID(N'[dbo].[AccountOperationRequest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccountOperationRequest];
GO
IF OBJECT_ID(N'[dbo].[Adresse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Adresse];
GO
IF OBJECT_ID(N'[dbo].[Bill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bill];
GO
IF OBJECT_ID(N'[dbo].[BillPayment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BillPayment];
GO
IF OBJECT_ID(N'[dbo].[Business]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Business];
GO
IF OBJECT_ID(N'[dbo].[BusinessContact]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BusinessContact];
GO
IF OBJECT_ID(N'[dbo].[City]', 'U') IS NOT NULL
    DROP TABLE [dbo].[City];
GO
IF OBJECT_ID(N'[dbo].[Country]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Country];
GO
IF OBJECT_ID(N'[dbo].[Currency]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Currency];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[CustomerAddress]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerAddress];
GO
IF OBJECT_ID(N'[dbo].[CustomerBalanceHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerBalanceHistory];
GO
IF OBJECT_ID(N'[dbo].[CustomerExternalAccount]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerExternalAccount];
GO
IF OBJECT_ID(N'[dbo].[CustomerGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerGroup];
GO
IF OBJECT_ID(N'[dbo].[CustomerGroupAdmin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerGroupAdmin];
GO
IF OBJECT_ID(N'[dbo].[CustomerImage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerImage];
GO
IF OBJECT_ID(N'[dbo].[CustomerLogin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerLogin];
GO
IF OBJECT_ID(N'[dbo].[CustomerTags]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerTags];
GO
IF OBJECT_ID(N'[dbo].[District]', 'U') IS NOT NULL
    DROP TABLE [dbo].[District];
GO
IF OBJECT_ID(N'[dbo].[EneoBillPayment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EneoBillPayment];
GO
IF OBJECT_ID(N'[dbo].[ExternalAccount]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExternalAccount];
GO
IF OBJECT_ID(N'[dbo].[ExternalAccountHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExternalAccountHistory];
GO
IF OBJECT_ID(N'[dbo].[GroupImage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GroupImage];
GO
IF OBJECT_ID(N'[dbo].[KoloNotification]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KoloNotification];
GO
IF OBJECT_ID(N'[dbo].[KoloSystemAction]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KoloSystemAction];
GO
IF OBJECT_ID(N'[dbo].[KoloUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KoloUser];
GO
IF OBJECT_ID(N'[dbo].[LoginAttempt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoginAttempt];
GO
IF OBJECT_ID(N'[dbo].[MobileDevice]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MobileDevice];
GO
IF OBJECT_ID(N'[dbo].[Partner]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Partner];
GO
IF OBJECT_ID(N'[dbo].[PartnerAddress]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PartnerAddress];
GO
IF OBJECT_ID(N'[dbo].[PartnerBalanceHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PartnerBalanceHistory];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO
IF OBJECT_ID(N'[dbo].[PersonRelationship]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonRelationship];
GO
IF OBJECT_ID(N'[dbo].[Provision]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Provision];
GO
IF OBJECT_ID(N'[dbo].[RecurringContribution]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RecurringContribution];
GO
IF OBJECT_ID(N'[dbo].[RefAddressType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefAddressType];
GO
IF OBJECT_ID(N'[dbo].[RefBillStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefBillStatus];
GO
IF OBJECT_ID(N'[dbo].[RefBillType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefBillType];
GO
IF OBJECT_ID(N'[dbo].[RefCustomerType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefCustomerType];
GO
IF OBJECT_ID(N'[dbo].[RefExternalAccountType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefExternalAccountType];
GO
IF OBJECT_ID(N'[dbo].[RefGender]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefGender];
GO
IF OBJECT_ID(N'[dbo].[RefGroupType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefGroupType];
GO
IF OBJECT_ID(N'[dbo].[RefIndustryCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefIndustryCategory];
GO
IF OBJECT_ID(N'[dbo].[RefLoginStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefLoginStatus];
GO
IF OBJECT_ID(N'[dbo].[RefMaritalStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefMaritalStatus];
GO
IF OBJECT_ID(N'[dbo].[RefOperationStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefOperationStatus];
GO
IF OBJECT_ID(N'[dbo].[RefOperationType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefOperationType];
GO
IF OBJECT_ID(N'[dbo].[RefPartnerType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefPartnerType];
GO
IF OBJECT_ID(N'[dbo].[RefPersonRelationshipType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefPersonRelationshipType];
GO
IF OBJECT_ID(N'[dbo].[RefProvisionStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefProvisionStatus];
GO
IF OBJECT_ID(N'[dbo].[RefRegistrationStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefRegistrationStatus];
GO
IF OBJECT_ID(N'[dbo].[RefResult]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefResult];
GO
IF OBJECT_ID(N'[dbo].[RefTransfertStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefTransfertStatus];
GO
IF OBJECT_ID(N'[dbo].[Registration]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Registration];
GO
IF OBJECT_ID(N'[dbo].[Reseller]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reseller];
GO
IF OBJECT_ID(N'[dbo].[Tag]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tag];
GO
IF OBJECT_ID(N'[dbo].[TopUp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TopUp];
GO
IF OBJECT_ID(N'[dbo].[Transfert2Cash]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transfert2Cash];
GO
IF OBJECT_ID(N'[dbo].[Transfert2CashDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transfert2CashDetails];
GO
IF OBJECT_ID(N'[dbo].[TransfertE2e]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransfertE2e];
GO
IF OBJECT_ID(N'[dbo].[TransfertGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransfertGroup];
GO
IF OBJECT_ID(N'[dbo].[TransfertGroupScheduled]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransfertGroupScheduled];
GO
IF OBJECT_ID(N'[dbo].[TransfertP2p]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransfertP2p];
GO
IF OBJECT_ID(N'[dbo].[TransfertScheduled]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransfertScheduled];
GO
IF OBJECT_ID(N'[dbo].[Wholesaler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Wholesaler];
GO
IF OBJECT_ID(N'[KoloModelStoreContainer].[TransferGravity]', 'U') IS NOT NULL
    DROP TABLE [KoloModelStoreContainer].[TransferGravity];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AccountOperations'
CREATE TABLE [dbo].[AccountOperations] (
    [IdAccountOperation] int IDENTITY(1,1) NOT NULL,
    [IdPartnerAccount] int  NOT NULL,
    [OperationStatusCode] nvarchar(15)  NULL,
    [IdPatnerHistory] int  NOT NULL,
    [OperationTypeCode] nvarchar(15)  NOT NULL,
    [Amount] int  NOT NULL
);
GO

-- Creating table 'AccountOperationRequests'
CREATE TABLE [dbo].[AccountOperationRequests] (
    [IdAccountOperationRequest] int  NOT NULL,
    [IdCustomerAccount] int  NOT NULL,
    [RequestDate] datetime  NULL,
    [OperationTypeCode] nvarchar(15)  NOT NULL,
    [OperationStatusCode] nvarchar(15)  NULL,
    [Amount] int  NOT NULL
);
GO

-- Creating table 'Adresses'
CREATE TABLE [dbo].[Adresses] (
    [IdAddress] int IDENTITY(1,1) NOT NULL,
    [Line_1] nvarchar(50)  NOT NULL,
    [Line_2] nvarchar(50)  NULL,
    [Line_3] nvarchar(50)  NULL,
    [IdCity] int  NULL,
    [PostCode] nvarchar(10)  NULL,
    [AddressTypeCode] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Bills'
CREATE TABLE [dbo].[Bills] (
    [IdBill] int IDENTITY(1,1) NOT NULL,
    [IdIssuingCustomer] int  NOT NULL,
    [IdPayingCustomer] int  NOT NULL,
    [CodeRefFactureType] nvarchar(15)  NULL,
    [CodeRefBillStatus] nvarchar(15)  NULL,
    [DateIssued] datetime  NOT NULL,
    [TotalBillAmount] int  NOT NULL,
    [LeftToPay] int  NOT NULL
);
GO

-- Creating table 'BillPayments'
CREATE TABLE [dbo].[BillPayments] (
    [IdBillPayment] int IDENTITY(1,1) NOT NULL,
    [IdBill] int  NOT NULL,
    [IdPayingCustomer] int  NOT NULL,
    [IdIssuingCustomer] int  NOT NULL,
    [DatePaid] datetime  NOT NULL,
    [PaidAmount] int  NULL
);
GO

-- Creating table 'Businesses'
CREATE TABLE [dbo].[Businesses] (
    [IdCustomer] int IDENTITY(1,1) NOT NULL,
    [IndustryCategoryCode] nvarchar(15)  NULL,
    [BusinessName] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'BusinessContacts'
CREATE TABLE [dbo].[BusinessContacts] (
    [IdBusiness] int  NOT NULL,
    [IdContact] int  NOT NULL,
    [JobTitle] nvarchar(50)  NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [IdCity] int IDENTITY(1,1) NOT NULL,
    [CityName] nvarchar(50)  NOT NULL,
    [CountryCode] nvarchar(10)  NOT NULL,
    [IdDistrict] int  NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [CountryCode] nvarchar(10)  NOT NULL,
    [CountryName] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Currencies'
CREATE TABLE [dbo].[Currencies] (
    [CurrencyCode] nchar(3)  NOT NULL,
    [CurrencyName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [IdCustomer] int IDENTITY(1,1) NOT NULL,
    [CustomerTypeCode] nvarchar(15)  NOT NULL,
    [CurrencyCode] nchar(3)  NOT NULL,
    [Balance] int  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [IdRegistration] int  NULL,
    [BalanceUnavailable] int  NOT NULL,
    [EneoContractNo] nvarchar(30)  NULL,
    [EneoPercentage] int  NULL,
    [TopUpPercentage] int  NULL,
    [GravityId] int  NULL,
    [GravityCode] nvarchar(50)  NULL,
    [GravityPercentage] int  NULL
);
GO

-- Creating table 'CustomerAddresses'
CREATE TABLE [dbo].[CustomerAddresses] (
    [IdCustomer] int  NOT NULL,
    [IdAddress] int  NOT NULL,
    [CodeAddresseType] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'CustomerBalanceHistories'
CREATE TABLE [dbo].[CustomerBalanceHistories] (
    [IdCustomerHistory] int IDENTITY(1,1) NOT NULL,
    [IdCustomerAccount] int  NOT NULL,
    [OperationTypeCode] nvarchar(15)  NOT NULL,
    [HistoryDate] datetime  NULL,
    [OldBalance] int  NOT NULL,
    [NewBalance] int  NOT NULL,
    [Amount] int  NULL
);
GO

-- Creating table 'CustomerExternalAccounts'
CREATE TABLE [dbo].[CustomerExternalAccounts] (
    [IdCustomer] int  NOT NULL,
    [IdExternalAccount] int  NOT NULL
);
GO

-- Creating table 'CustomerGroups'
CREATE TABLE [dbo].[CustomerGroups] (
    [IdCustomerGroup] int IDENTITY(1,1) NOT NULL,
    [IdMemberCustomer] int  NOT NULL,
    [GroupTypeCode] nvarchar(15)  NOT NULL,
    [GroupName] nvarchar(50)  NOT NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'CustomerImages'
CREATE TABLE [dbo].[CustomerImages] (
    [IdCustomer] int  NOT NULL,
    [ImageBytes] varbinary(max)  NULL
);
GO

-- Creating table 'CustomerLogins'
CREATE TABLE [dbo].[CustomerLogins] (
    [IdCustomer] int  NOT NULL,
    [Number] nvarchar(30)  NOT NULL,
    [NumberVerified] bit  NULL,
    [EmailAddress] nvarchar(100)  NULL,
    [EmailAddressVerified] bit  NOT NULL,
    [PwdSalt] nvarchar(256)  NULL,
    [Pwd] nvarchar(256)  NULL,
    [RecoveryToken] nvarchar(10)  NULL,
    [RecoveryTokenExpiryDate] datetime  NULL,
    [LoginStatusCode] nvarchar(15)  NULL
);
GO

-- Creating table 'CustomerTags'
CREATE TABLE [dbo].[CustomerTags] (
    [IdCustomerTags] int IDENTITY(1,1) NOT NULL,
    [IdCustomerAccount] int  NULL,
    [IdTag] int  NULL
);
GO

-- Creating table 'Districts'
CREATE TABLE [dbo].[Districts] (
    [IdDistrict] int IDENTITY(1,1) NOT NULL,
    [DistrictName] nvarchar(50)  NOT NULL,
    [CountryCode] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'ExternalAccounts'
CREATE TABLE [dbo].[ExternalAccounts] (
    [IdExternalAccount] int IDENTITY(1,1) NOT NULL,
    [ExternalLogin] nvarchar(50)  NOT NULL,
    [ExternalPwd] nvarchar(50)  NOT NULL,
    [ExternalAccountTypeCode] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'ExternalAccountHistories'
CREATE TABLE [dbo].[ExternalAccountHistories] (
    [IdAccountHistory] int IDENTITY(1,1) NOT NULL,
    [IdExternalAccount] int  NOT NULL,
    [OperationTypeCode] nvarchar(15)  NOT NULL,
    [HistoryDate] datetime  NOT NULL,
    [OldBalance] int  NOT NULL,
    [NewBalance] int  NOT NULL,
    [Amount] int  NOT NULL
);
GO

-- Creating table 'GroupImages'
CREATE TABLE [dbo].[GroupImages] (
    [IdCustomerGroup] int  NOT NULL,
    [ImageBytes] varbinary(max)  NULL
);
GO

-- Creating table 'KoloNotifications'
CREATE TABLE [dbo].[KoloNotifications] (
    [IdNotification] int IDENTITY(1,1) NOT NULL,
    [IdCustomer] int  NOT NULL,
    [Title] nvarchar(15)  NOT NULL,
    [Message] nvarchar(50)  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [ExpiryDate] datetime  NULL,
    [Readed] bit  NULL
);
GO

-- Creating table 'KoloSystemActions'
CREATE TABLE [dbo].[KoloSystemActions] (
    [ActionCode] nvarchar(25)  NOT NULL,
    [ActionDescription] nvarchar(100)  NULL
);
GO

-- Creating table 'KoloUsers'
CREATE TABLE [dbo].[KoloUsers] (
    [IdCustomer] int  NOT NULL,
    [UserLogin] nvarchar(30)  NOT NULL,
    [Number] nvarchar(30)  NOT NULL,
    [NumberVerified] bit  NULL,
    [EmailAddress] nvarchar(100)  NULL,
    [EmailAddressVerified] bit  NOT NULL,
    [PwdSalt] nvarchar(256)  NULL,
    [Pwd] nvarchar(256)  NULL,
    [RecoveryToken] nvarchar(10)  NULL,
    [RecoveryTokenExpiryDate] datetime  NULL,
    [LoginStatusCode] nvarchar(15)  NULL,
    [MasterUser] bit  NULL,
    [GroupCode] nvarchar(25)  NULL
);
GO

-- Creating table 'LoginAttempts'
CREATE TABLE [dbo].[LoginAttempts] (
    [IdLoginAttempt] int IDENTITY(1,1) NOT NULL,
    [IdCustomer] int  NOT NULL,
    [LoginTime] datetime  NOT NULL,
    [ResultCode] nvarchar(15)  NOT NULL,
    [DeviceId] nvarchar(15)  NOT NULL,
    [SimOperator] nvarchar(10)  NOT NULL,
    [SimSerialNumber] nvarchar(20)  NOT NULL,
    [SubscriberId] nvarchar(20)  NOT NULL,
    [Pwd] nvarchar(256)  NOT NULL,
    [Number] nvarchar(30)  NOT NULL,
    [Latitude] decimal(9,6)  NULL,
    [Longitude] decimal(9,6)  NULL,
    [Accuracy] decimal(4,2)  NULL
);
GO

-- Creating table 'MobileDevices'
CREATE TABLE [dbo].[MobileDevices] (
    [IdMobileDevice] int  NOT NULL,
    [DeviceId] nvarchar(15)  NOT NULL,
    [LineNumber] nvarchar(15)  NOT NULL,
    [NetworkCountryIso] nvarchar(3)  NULL,
    [NetworkOperator] nvarchar(10)  NULL,
    [NetworkOperatorName] nvarchar(50)  NULL,
    [NetworkType] nvarchar(15)  NULL,
    [PhoneType] nvarchar(15)  NULL,
    [SimCountryIso] nvarchar(3)  NOT NULL,
    [SimOperator] nvarchar(10)  NOT NULL,
    [SimOperatorName] nvarchar(50)  NULL,
    [SimSerialNumber] nvarchar(20)  NOT NULL,
    [SimState] nvarchar(15)  NULL,
    [SubscriberId] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Partners'
CREATE TABLE [dbo].[Partners] (
    [IdPartner] int IDENTITY(1,1) NOT NULL,
    [PartnerTypeCode] nvarchar(15)  NOT NULL,
    [CurrencyCode] nchar(3)  NOT NULL,
    [Balance] int  NOT NULL,
    [DateCreated] datetime  NOT NULL
);
GO

-- Creating table 'PartnerAddresses'
CREATE TABLE [dbo].[PartnerAddresses] (
    [IdPartner] int  NOT NULL,
    [IdAddress] int  NOT NULL,
    [AddresseTypeCode] nvarchar(15)  NULL
);
GO

-- Creating table 'PartnerBalanceHistories'
CREATE TABLE [dbo].[PartnerBalanceHistories] (
    [IdPatnerHistory] int  NOT NULL,
    [IdPartnerAccount] int  NOT NULL,
    [HistoryDate] datetime  NOT NULL,
    [OldBalance] int  NOT NULL,
    [NewBalance] int  NOT NULL,
    [Amount] int  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [IdCustomer] int  NOT NULL,
    [GenderCode] nvarchar(15)  NULL,
    [MaritalStatusCode] nvarchar(15)  NULL,
    [Firstname] nvarchar(100)  NULL,
    [Middlename] nvarchar(100)  NULL,
    [Lastname] nvarchar(100)  NULL,
    [DateOfBirth] datetime  NULL,
    [DateCreated] datetime  NULL,
    [CountryCode] nvarchar(10)  NULL
);
GO

-- Creating table 'PersonRelationships'
CREATE TABLE [dbo].[PersonRelationships] (
    [IdCustomer] int  NOT NULL,
    [IdPersonRelation] int  NOT NULL,
    [RelationshipTypeCode] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Provisions'
CREATE TABLE [dbo].[Provisions] (
    [IdProvision] int IDENTITY(1,1) NOT NULL,
    [IdProvisionRequest] int  NULL,
    [IdPatnerHistory] int  NOT NULL,
    [IdResellerPartnerAccount] int  NOT NULL,
    [IdWholesalerPartnerAccount] int  NOT NULL,
    [CodeRefProsisionStatus] nvarchar(15)  NULL,
    [ProvisionDate] datetime  NOT NULL,
    [Amount] int  NOT NULL
);
GO

-- Creating table 'RecurringContributions'
CREATE TABLE [dbo].[RecurringContributions] (
    [IdRecurringContribution] int IDENTITY(1,1) NOT NULL,
    [IdTreasurerCustomer] int  NOT NULL,
    [IdCustomerGroup] int  NOT NULL
);
GO

-- Creating table 'RefAddressTypes'
CREATE TABLE [dbo].[RefAddressTypes] (
    [AddressTypeDescription] nvarchar(100)  NULL,
    [AddressTypeCode] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'RefBillStatus'
CREATE TABLE [dbo].[RefBillStatus] (
    [BillStatusCode] nvarchar(15)  NOT NULL,
    [BillStatusDescription] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'RefBillTypes'
CREATE TABLE [dbo].[RefBillTypes] (
    [BillTypeCode] nvarchar(15)  NOT NULL,
    [BillTypeDescription] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'RefCustomerTypes'
CREATE TABLE [dbo].[RefCustomerTypes] (
    [CustomerTypeCode] nvarchar(15)  NOT NULL,
    [CustomerTypeDescription] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'RefExternalAccountTypes'
CREATE TABLE [dbo].[RefExternalAccountTypes] (
    [ExternalAccountTypeCode] nvarchar(15)  NOT NULL,
    [ExternalAccountTypeDescription] nvarchar(50)  NULL
);
GO

-- Creating table 'RefGenders'
CREATE TABLE [dbo].[RefGenders] (
    [GenderCode] nvarchar(15)  NOT NULL,
    [GenderDescription] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'RefGroupTypes'
CREATE TABLE [dbo].[RefGroupTypes] (
    [GroupTypeCode] nvarchar(15)  NOT NULL,
    [GroupTypeDescription] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'RefIndustryCategories'
CREATE TABLE [dbo].[RefIndustryCategories] (
    [IndustryCategoryCode] nvarchar(15)  NOT NULL,
    [IndustryCategoryDescrption] nvarchar(50)  NULL
);
GO

-- Creating table 'RefLoginStatus'
CREATE TABLE [dbo].[RefLoginStatus] (
    [LoginStatusCode] nvarchar(15)  NOT NULL,
    [LoginStatusDescription] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'RefMaritalStatus'
CREATE TABLE [dbo].[RefMaritalStatus] (
    [MaritalStatusCode] nvarchar(15)  NOT NULL,
    [MaritalStatusDescription] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'RefOperationStatus'
CREATE TABLE [dbo].[RefOperationStatus] (
    [OperationStatusCode] nvarchar(15)  NOT NULL,
    [OperationStatusDescription] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'RefOperationTypes'
CREATE TABLE [dbo].[RefOperationTypes] (
    [OperationTypeCode] nvarchar(15)  NOT NULL,
    [OperationTypeName] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'RefPartnerTypes'
CREATE TABLE [dbo].[RefPartnerTypes] (
    [PartnerTypeCode] nvarchar(15)  NOT NULL,
    [PartnerTypeDescription] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'RefPersonRelationshipTypes'
CREATE TABLE [dbo].[RefPersonRelationshipTypes] (
    [RelationshipTypeCode] nvarchar(15)  NOT NULL,
    [RelationshipTypeDescription] nvarchar(50)  NULL
);
GO

-- Creating table 'RefProvisionStatus'
CREATE TABLE [dbo].[RefProvisionStatus] (
    [ProvisionStatusCode] nvarchar(15)  NOT NULL,
    [ProvisionStatusDescription] nvarchar(100)  NULL
);
GO

-- Creating table 'RefRegistrationStatus'
CREATE TABLE [dbo].[RefRegistrationStatus] (
    [RegistrationStatusCode] nvarchar(15)  NOT NULL,
    [RegistrationStatusDescription] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'RefResults'
CREATE TABLE [dbo].[RefResults] (
    [ResultCode] nvarchar(15)  NOT NULL,
    [ResultDescription] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'RefTransfertStatus'
CREATE TABLE [dbo].[RefTransfertStatus] (
    [TransfertStatusCode] nvarchar(15)  NOT NULL,
    [TransfertStatusDescription] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Registrations'
CREATE TABLE [dbo].[Registrations] (
    [IdRegistration] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(100)  NULL,
    [FirstName] nvarchar(100)  NULL,
    [PhoneNumber] nvarchar(15)  NULL,
    [Dob] datetime  NULL,
    [Email] nvarchar(50)  NULL,
    [RegistrationToken] nvarchar(10)  NULL,
    [RegistrationStatusCode] nvarchar(15)  NOT NULL,
    [RegistrationDate] datetime  NOT NULL,
    [RegistrationConfirmDate] datetime  NULL,
    [SimSubscriberId] nvarchar(20)  NOT NULL,
    [SimSerialNumber] nvarchar(20)  NOT NULL,
    [OperatorDeviceSim] nvarchar(100)  NOT NULL,
    [RegistrationTokenExpiryDate] datetime  NULL,
    [Pwd] nvarchar(256)  NOT NULL,
    [DeviceId] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Resellers'
CREATE TABLE [dbo].[Resellers] (
    [IdPartner] int IDENTITY(1,1) NOT NULL,
    [IdWholesalerPartner] int  NOT NULL
);
GO

-- Creating table 'Tags'
CREATE TABLE [dbo].[Tags] (
    [IdTag] int IDENTITY(1,1) NOT NULL,
    [TagName] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Transfert2Cash'
CREATE TABLE [dbo].[Transfert2Cash] (
    [IdTransfert2Cash] int  NOT NULL,
    [IdPartnerAccount] int  NOT NULL,
    [IdSendingTransfert2CashDetails] int  NOT NULL,
    [IdReceiverTransfert2CashDetails] int  NOT NULL,
    [CodeTransfertStatus] nvarchar(15)  NULL,
    [Amount] int  NOT NULL
);
GO

-- Creating table 'Transfert2CashDetails'
CREATE TABLE [dbo].[Transfert2CashDetails] (
    [IdTransfert2CashDetails] int IDENTITY(1,1) NOT NULL,
    [IdCustomerAccount] int  NULL,
    [Firstname] nvarchar(100)  NULL,
    [Middlename] nvarchar(100)  NULL,
    [Lastname] nvarchar(100)  NULL,
    [Reference] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'TransfertE2e'
CREATE TABLE [dbo].[TransfertE2e] (
    [IdTransfertE2e] int  NOT NULL,
    [IdCustomer] int  NOT NULL,
    [IdSendingExternalAccount] int  NOT NULL,
    [IdReceiverExternalAccount] int  NOT NULL,
    [TransfertStatusCode] nvarchar(15)  NOT NULL,
    [Amount] int  NOT NULL,
    [OperationTypeCode] nvarchar(15)  NOT NULL,
    [Reference] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'TransfertGroups'
CREATE TABLE [dbo].[TransfertGroups] (
    [IdTransfertGroup] int IDENTITY(1,1) NOT NULL,
    [IdReceiverGroup] int  NOT NULL,
    [IdSendingCustomer] int  NOT NULL,
    [Amount] int  NOT NULL,
    [CodeTransfertStatus] nvarchar(15)  NOT NULL,
    [Reference] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'TransfertGroupScheduleds'
CREATE TABLE [dbo].[TransfertGroupScheduleds] (
    [IdTransfertGroupScheduled] int  NOT NULL,
    [IdReceiverGroup] int  NOT NULL,
    [IdSendingCustomer] int  NOT NULL
);
GO

-- Creating table 'TransfertP2p'
CREATE TABLE [dbo].[TransfertP2p] (
    [IdTransfertP2p] int IDENTITY(1,1) NOT NULL,
    [IdSendingCustomer] int  NOT NULL,
    [IdReceiverCustomer] int  NULL,
    [IdTransfertScheduled] int  NULL,
    [TransfertStatusCode] nvarchar(15)  NOT NULL,
    [Amount] int  NOT NULL,
    [NeedsConfirmation] bit  NOT NULL,
    [Secret] nvarchar(4)  NULL,
    [TransfertDate] datetime  NOT NULL,
    [Reference] nvarchar(30)  NOT NULL,
    [Transfert2Cash] bit  NOT NULL,
    [ReceiveDate] datetime  NULL,
    [ConfirmationDate] datetime  NULL,
    [CancelationDate] datetime  NULL
);
GO

-- Creating table 'TransfertScheduleds'
CREATE TABLE [dbo].[TransfertScheduleds] (
    [IdTransfertScheduled] int IDENTITY(1,1) NOT NULL,
    [IdSendingCustomer] int  NOT NULL,
    [IdReceiverCustomer] int  NOT NULL,
    [DateScheduled] datetime  NOT NULL
);
GO

-- Creating table 'Wholesalers'
CREATE TABLE [dbo].[Wholesalers] (
    [IdPartner] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'EneoBillPayments'
CREATE TABLE [dbo].[EneoBillPayments] (
    [IdEneoBillPayment] int IDENTITY(1,1) NOT NULL,
    [IdCustomer] int  NOT NULL,
    [PaymentDate] datetime  NOT NULL,
    [ContractNo] nvarchar(50)  NOT NULL,
    [BillNumber] nvarchar(20)  NOT NULL,
    [Fee] int  NOT NULL,
    [Ccion] int  NOT NULL,
    [BillAmount] int  NOT NULL
);
GO

-- Creating table 'TopUps'
CREATE TABLE [dbo].[TopUps] (
    [IdTopUp] int IDENTITY(1,1) NOT NULL,
    [OpDate] datetime  NOT NULL,
    [PhoneNumber] nvarchar(15)  NOT NULL,
    [Amount] nchar(10)  NOT NULL,
    [OperatorCode] nvarchar(25)  NOT NULL,
    [Ccion] int  NOT NULL,
    [IdCustomer] int  NOT NULL
);
GO

-- Creating table 'TransferGravities'
CREATE TABLE [dbo].[TransferGravities] (
    [TransferMadId] int  NOT NULL,
    [GravityReference] nvarchar(25)  NOT NULL,
    [KoloReference] nvarchar(30)  NOT NULL,
    [KoloSenderId] int  NOT NULL,
    [GravitySenderId] int  NOT NULL,
    [GravityReceiverId] int  NOT NULL,
    [Amount] int  NOT NULL,
    [Received] bit  NOT NULL,
    [ReceiverLastName] nvarchar(50)  NOT NULL,
    [ReceiverFirstName] nvarchar(50)  NOT NULL,
    [ReceiverPhoneNumber] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'CustomerGroupAdmin'
CREATE TABLE [dbo].[CustomerGroupAdmin] (
    [CustomerGroupAdmin_CustomerGroup_IdCustomer] int  NOT NULL,
    [CustomerGroupAdmin_Customer_IdCustomerGroup] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdAccountOperation] in table 'AccountOperations'
ALTER TABLE [dbo].[AccountOperations]
ADD CONSTRAINT [PK_AccountOperations]
    PRIMARY KEY CLUSTERED ([IdAccountOperation] ASC);
GO

-- Creating primary key on [IdAccountOperationRequest] in table 'AccountOperationRequests'
ALTER TABLE [dbo].[AccountOperationRequests]
ADD CONSTRAINT [PK_AccountOperationRequests]
    PRIMARY KEY CLUSTERED ([IdAccountOperationRequest] ASC);
GO

-- Creating primary key on [IdAddress] in table 'Adresses'
ALTER TABLE [dbo].[Adresses]
ADD CONSTRAINT [PK_Adresses]
    PRIMARY KEY CLUSTERED ([IdAddress] ASC);
GO

-- Creating primary key on [IdBill] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [PK_Bills]
    PRIMARY KEY CLUSTERED ([IdBill] ASC);
GO

-- Creating primary key on [IdBillPayment] in table 'BillPayments'
ALTER TABLE [dbo].[BillPayments]
ADD CONSTRAINT [PK_BillPayments]
    PRIMARY KEY CLUSTERED ([IdBillPayment] ASC);
GO

-- Creating primary key on [IdCustomer] in table 'Businesses'
ALTER TABLE [dbo].[Businesses]
ADD CONSTRAINT [PK_Businesses]
    PRIMARY KEY CLUSTERED ([IdCustomer] ASC);
GO

-- Creating primary key on [IdBusiness], [IdContact] in table 'BusinessContacts'
ALTER TABLE [dbo].[BusinessContacts]
ADD CONSTRAINT [PK_BusinessContacts]
    PRIMARY KEY CLUSTERED ([IdBusiness], [IdContact] ASC);
GO

-- Creating primary key on [IdCity] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([IdCity] ASC);
GO

-- Creating primary key on [CountryCode] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([CountryCode] ASC);
GO

-- Creating primary key on [CurrencyCode] in table 'Currencies'
ALTER TABLE [dbo].[Currencies]
ADD CONSTRAINT [PK_Currencies]
    PRIMARY KEY CLUSTERED ([CurrencyCode] ASC);
GO

-- Creating primary key on [IdCustomer] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([IdCustomer] ASC);
GO

-- Creating primary key on [IdCustomer], [IdAddress] in table 'CustomerAddresses'
ALTER TABLE [dbo].[CustomerAddresses]
ADD CONSTRAINT [PK_CustomerAddresses]
    PRIMARY KEY CLUSTERED ([IdCustomer], [IdAddress] ASC);
GO

-- Creating primary key on [IdCustomerHistory] in table 'CustomerBalanceHistories'
ALTER TABLE [dbo].[CustomerBalanceHistories]
ADD CONSTRAINT [PK_CustomerBalanceHistories]
    PRIMARY KEY CLUSTERED ([IdCustomerHistory] ASC);
GO

-- Creating primary key on [IdCustomer], [IdExternalAccount] in table 'CustomerExternalAccounts'
ALTER TABLE [dbo].[CustomerExternalAccounts]
ADD CONSTRAINT [PK_CustomerExternalAccounts]
    PRIMARY KEY CLUSTERED ([IdCustomer], [IdExternalAccount] ASC);
GO

-- Creating primary key on [IdCustomerGroup] in table 'CustomerGroups'
ALTER TABLE [dbo].[CustomerGroups]
ADD CONSTRAINT [PK_CustomerGroups]
    PRIMARY KEY CLUSTERED ([IdCustomerGroup] ASC);
GO

-- Creating primary key on [IdCustomer] in table 'CustomerImages'
ALTER TABLE [dbo].[CustomerImages]
ADD CONSTRAINT [PK_CustomerImages]
    PRIMARY KEY CLUSTERED ([IdCustomer] ASC);
GO

-- Creating primary key on [IdCustomer] in table 'CustomerLogins'
ALTER TABLE [dbo].[CustomerLogins]
ADD CONSTRAINT [PK_CustomerLogins]
    PRIMARY KEY CLUSTERED ([IdCustomer] ASC);
GO

-- Creating primary key on [IdCustomerTags] in table 'CustomerTags'
ALTER TABLE [dbo].[CustomerTags]
ADD CONSTRAINT [PK_CustomerTags]
    PRIMARY KEY CLUSTERED ([IdCustomerTags] ASC);
GO

-- Creating primary key on [IdDistrict] in table 'Districts'
ALTER TABLE [dbo].[Districts]
ADD CONSTRAINT [PK_Districts]
    PRIMARY KEY CLUSTERED ([IdDistrict] ASC);
GO

-- Creating primary key on [IdExternalAccount] in table 'ExternalAccounts'
ALTER TABLE [dbo].[ExternalAccounts]
ADD CONSTRAINT [PK_ExternalAccounts]
    PRIMARY KEY CLUSTERED ([IdExternalAccount] ASC);
GO

-- Creating primary key on [IdAccountHistory] in table 'ExternalAccountHistories'
ALTER TABLE [dbo].[ExternalAccountHistories]
ADD CONSTRAINT [PK_ExternalAccountHistories]
    PRIMARY KEY CLUSTERED ([IdAccountHistory] ASC);
GO

-- Creating primary key on [IdCustomerGroup] in table 'GroupImages'
ALTER TABLE [dbo].[GroupImages]
ADD CONSTRAINT [PK_GroupImages]
    PRIMARY KEY CLUSTERED ([IdCustomerGroup] ASC);
GO

-- Creating primary key on [IdNotification] in table 'KoloNotifications'
ALTER TABLE [dbo].[KoloNotifications]
ADD CONSTRAINT [PK_KoloNotifications]
    PRIMARY KEY CLUSTERED ([IdNotification] ASC);
GO

-- Creating primary key on [ActionCode] in table 'KoloSystemActions'
ALTER TABLE [dbo].[KoloSystemActions]
ADD CONSTRAINT [PK_KoloSystemActions]
    PRIMARY KEY CLUSTERED ([ActionCode] ASC);
GO

-- Creating primary key on [IdCustomer] in table 'KoloUsers'
ALTER TABLE [dbo].[KoloUsers]
ADD CONSTRAINT [PK_KoloUsers]
    PRIMARY KEY CLUSTERED ([IdCustomer] ASC);
GO

-- Creating primary key on [IdLoginAttempt] in table 'LoginAttempts'
ALTER TABLE [dbo].[LoginAttempts]
ADD CONSTRAINT [PK_LoginAttempts]
    PRIMARY KEY CLUSTERED ([IdLoginAttempt] ASC);
GO

-- Creating primary key on [IdMobileDevice] in table 'MobileDevices'
ALTER TABLE [dbo].[MobileDevices]
ADD CONSTRAINT [PK_MobileDevices]
    PRIMARY KEY CLUSTERED ([IdMobileDevice] ASC);
GO

-- Creating primary key on [IdPartner] in table 'Partners'
ALTER TABLE [dbo].[Partners]
ADD CONSTRAINT [PK_Partners]
    PRIMARY KEY CLUSTERED ([IdPartner] ASC);
GO

-- Creating primary key on [IdPartner], [IdAddress] in table 'PartnerAddresses'
ALTER TABLE [dbo].[PartnerAddresses]
ADD CONSTRAINT [PK_PartnerAddresses]
    PRIMARY KEY CLUSTERED ([IdPartner], [IdAddress] ASC);
GO

-- Creating primary key on [IdPatnerHistory] in table 'PartnerBalanceHistories'
ALTER TABLE [dbo].[PartnerBalanceHistories]
ADD CONSTRAINT [PK_PartnerBalanceHistories]
    PRIMARY KEY CLUSTERED ([IdPatnerHistory] ASC);
GO

-- Creating primary key on [IdCustomer] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([IdCustomer] ASC);
GO

-- Creating primary key on [IdCustomer] in table 'PersonRelationships'
ALTER TABLE [dbo].[PersonRelationships]
ADD CONSTRAINT [PK_PersonRelationships]
    PRIMARY KEY CLUSTERED ([IdCustomer] ASC);
GO

-- Creating primary key on [IdProvision] in table 'Provisions'
ALTER TABLE [dbo].[Provisions]
ADD CONSTRAINT [PK_Provisions]
    PRIMARY KEY CLUSTERED ([IdProvision] ASC);
GO

-- Creating primary key on [IdRecurringContribution] in table 'RecurringContributions'
ALTER TABLE [dbo].[RecurringContributions]
ADD CONSTRAINT [PK_RecurringContributions]
    PRIMARY KEY CLUSTERED ([IdRecurringContribution] ASC);
GO

-- Creating primary key on [AddressTypeCode] in table 'RefAddressTypes'
ALTER TABLE [dbo].[RefAddressTypes]
ADD CONSTRAINT [PK_RefAddressTypes]
    PRIMARY KEY CLUSTERED ([AddressTypeCode] ASC);
GO

-- Creating primary key on [BillStatusCode] in table 'RefBillStatus'
ALTER TABLE [dbo].[RefBillStatus]
ADD CONSTRAINT [PK_RefBillStatus]
    PRIMARY KEY CLUSTERED ([BillStatusCode] ASC);
GO

-- Creating primary key on [BillTypeCode] in table 'RefBillTypes'
ALTER TABLE [dbo].[RefBillTypes]
ADD CONSTRAINT [PK_RefBillTypes]
    PRIMARY KEY CLUSTERED ([BillTypeCode] ASC);
GO

-- Creating primary key on [CustomerTypeCode] in table 'RefCustomerTypes'
ALTER TABLE [dbo].[RefCustomerTypes]
ADD CONSTRAINT [PK_RefCustomerTypes]
    PRIMARY KEY CLUSTERED ([CustomerTypeCode] ASC);
GO

-- Creating primary key on [ExternalAccountTypeCode] in table 'RefExternalAccountTypes'
ALTER TABLE [dbo].[RefExternalAccountTypes]
ADD CONSTRAINT [PK_RefExternalAccountTypes]
    PRIMARY KEY CLUSTERED ([ExternalAccountTypeCode] ASC);
GO

-- Creating primary key on [GenderCode] in table 'RefGenders'
ALTER TABLE [dbo].[RefGenders]
ADD CONSTRAINT [PK_RefGenders]
    PRIMARY KEY CLUSTERED ([GenderCode] ASC);
GO

-- Creating primary key on [GroupTypeCode] in table 'RefGroupTypes'
ALTER TABLE [dbo].[RefGroupTypes]
ADD CONSTRAINT [PK_RefGroupTypes]
    PRIMARY KEY CLUSTERED ([GroupTypeCode] ASC);
GO

-- Creating primary key on [IndustryCategoryCode] in table 'RefIndustryCategories'
ALTER TABLE [dbo].[RefIndustryCategories]
ADD CONSTRAINT [PK_RefIndustryCategories]
    PRIMARY KEY CLUSTERED ([IndustryCategoryCode] ASC);
GO

-- Creating primary key on [LoginStatusCode] in table 'RefLoginStatus'
ALTER TABLE [dbo].[RefLoginStatus]
ADD CONSTRAINT [PK_RefLoginStatus]
    PRIMARY KEY CLUSTERED ([LoginStatusCode] ASC);
GO

-- Creating primary key on [MaritalStatusCode] in table 'RefMaritalStatus'
ALTER TABLE [dbo].[RefMaritalStatus]
ADD CONSTRAINT [PK_RefMaritalStatus]
    PRIMARY KEY CLUSTERED ([MaritalStatusCode] ASC);
GO

-- Creating primary key on [OperationStatusCode] in table 'RefOperationStatus'
ALTER TABLE [dbo].[RefOperationStatus]
ADD CONSTRAINT [PK_RefOperationStatus]
    PRIMARY KEY CLUSTERED ([OperationStatusCode] ASC);
GO

-- Creating primary key on [OperationTypeCode] in table 'RefOperationTypes'
ALTER TABLE [dbo].[RefOperationTypes]
ADD CONSTRAINT [PK_RefOperationTypes]
    PRIMARY KEY CLUSTERED ([OperationTypeCode] ASC);
GO

-- Creating primary key on [PartnerTypeCode] in table 'RefPartnerTypes'
ALTER TABLE [dbo].[RefPartnerTypes]
ADD CONSTRAINT [PK_RefPartnerTypes]
    PRIMARY KEY CLUSTERED ([PartnerTypeCode] ASC);
GO

-- Creating primary key on [RelationshipTypeCode] in table 'RefPersonRelationshipTypes'
ALTER TABLE [dbo].[RefPersonRelationshipTypes]
ADD CONSTRAINT [PK_RefPersonRelationshipTypes]
    PRIMARY KEY CLUSTERED ([RelationshipTypeCode] ASC);
GO

-- Creating primary key on [ProvisionStatusCode] in table 'RefProvisionStatus'
ALTER TABLE [dbo].[RefProvisionStatus]
ADD CONSTRAINT [PK_RefProvisionStatus]
    PRIMARY KEY CLUSTERED ([ProvisionStatusCode] ASC);
GO

-- Creating primary key on [RegistrationStatusCode] in table 'RefRegistrationStatus'
ALTER TABLE [dbo].[RefRegistrationStatus]
ADD CONSTRAINT [PK_RefRegistrationStatus]
    PRIMARY KEY CLUSTERED ([RegistrationStatusCode] ASC);
GO

-- Creating primary key on [ResultCode] in table 'RefResults'
ALTER TABLE [dbo].[RefResults]
ADD CONSTRAINT [PK_RefResults]
    PRIMARY KEY CLUSTERED ([ResultCode] ASC);
GO

-- Creating primary key on [TransfertStatusCode] in table 'RefTransfertStatus'
ALTER TABLE [dbo].[RefTransfertStatus]
ADD CONSTRAINT [PK_RefTransfertStatus]
    PRIMARY KEY CLUSTERED ([TransfertStatusCode] ASC);
GO

-- Creating primary key on [IdRegistration] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [PK_Registrations]
    PRIMARY KEY CLUSTERED ([IdRegistration] ASC);
GO

-- Creating primary key on [IdPartner] in table 'Resellers'
ALTER TABLE [dbo].[Resellers]
ADD CONSTRAINT [PK_Resellers]
    PRIMARY KEY CLUSTERED ([IdPartner] ASC);
GO

-- Creating primary key on [IdTag] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [PK_Tags]
    PRIMARY KEY CLUSTERED ([IdTag] ASC);
GO

-- Creating primary key on [IdTransfert2Cash] in table 'Transfert2Cash'
ALTER TABLE [dbo].[Transfert2Cash]
ADD CONSTRAINT [PK_Transfert2Cash]
    PRIMARY KEY CLUSTERED ([IdTransfert2Cash] ASC);
GO

-- Creating primary key on [IdTransfert2CashDetails] in table 'Transfert2CashDetails'
ALTER TABLE [dbo].[Transfert2CashDetails]
ADD CONSTRAINT [PK_Transfert2CashDetails]
    PRIMARY KEY CLUSTERED ([IdTransfert2CashDetails] ASC);
GO

-- Creating primary key on [IdTransfertE2e] in table 'TransfertE2e'
ALTER TABLE [dbo].[TransfertE2e]
ADD CONSTRAINT [PK_TransfertE2e]
    PRIMARY KEY CLUSTERED ([IdTransfertE2e] ASC);
GO

-- Creating primary key on [IdTransfertGroup] in table 'TransfertGroups'
ALTER TABLE [dbo].[TransfertGroups]
ADD CONSTRAINT [PK_TransfertGroups]
    PRIMARY KEY CLUSTERED ([IdTransfertGroup] ASC);
GO

-- Creating primary key on [IdTransfertGroupScheduled] in table 'TransfertGroupScheduleds'
ALTER TABLE [dbo].[TransfertGroupScheduleds]
ADD CONSTRAINT [PK_TransfertGroupScheduleds]
    PRIMARY KEY CLUSTERED ([IdTransfertGroupScheduled] ASC);
GO

-- Creating primary key on [IdTransfertP2p] in table 'TransfertP2p'
ALTER TABLE [dbo].[TransfertP2p]
ADD CONSTRAINT [PK_TransfertP2p]
    PRIMARY KEY CLUSTERED ([IdTransfertP2p] ASC);
GO

-- Creating primary key on [IdTransfertScheduled] in table 'TransfertScheduleds'
ALTER TABLE [dbo].[TransfertScheduleds]
ADD CONSTRAINT [PK_TransfertScheduleds]
    PRIMARY KEY CLUSTERED ([IdTransfertScheduled] ASC);
GO

-- Creating primary key on [IdPartner] in table 'Wholesalers'
ALTER TABLE [dbo].[Wholesalers]
ADD CONSTRAINT [PK_Wholesalers]
    PRIMARY KEY CLUSTERED ([IdPartner] ASC);
GO

-- Creating primary key on [IdEneoBillPayment] in table 'EneoBillPayments'
ALTER TABLE [dbo].[EneoBillPayments]
ADD CONSTRAINT [PK_EneoBillPayments]
    PRIMARY KEY CLUSTERED ([IdEneoBillPayment] ASC);
GO

-- Creating primary key on [IdTopUp] in table 'TopUps'
ALTER TABLE [dbo].[TopUps]
ADD CONSTRAINT [PK_TopUps]
    PRIMARY KEY CLUSTERED ([IdTopUp] ASC);
GO

-- Creating primary key on [TransferMadId], [GravityReference], [KoloReference], [KoloSenderId], [GravitySenderId], [GravityReceiverId], [Amount], [Received], [ReceiverLastName], [ReceiverFirstName], [ReceiverPhoneNumber] in table 'TransferGravities'
ALTER TABLE [dbo].[TransferGravities]
ADD CONSTRAINT [PK_TransferGravities]
    PRIMARY KEY CLUSTERED ([TransferMadId], [GravityReference], [KoloReference], [KoloSenderId], [GravitySenderId], [GravityReceiverId], [Amount], [Received], [ReceiverLastName], [ReceiverFirstName], [ReceiverPhoneNumber] ASC);
GO

-- Creating primary key on [CustomerGroupAdmin_CustomerGroup_IdCustomer], [CustomerGroupAdmin_Customer_IdCustomerGroup] in table 'CustomerGroupAdmin'
ALTER TABLE [dbo].[CustomerGroupAdmin]
ADD CONSTRAINT [PK_CustomerGroupAdmin]
    PRIMARY KEY CLUSTERED ([CustomerGroupAdmin_CustomerGroup_IdCustomer], [CustomerGroupAdmin_Customer_IdCustomerGroup] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [OperationStatusCode] in table 'AccountOperations'
ALTER TABLE [dbo].[AccountOperations]
ADD CONSTRAINT [fk_AccountOperation]
    FOREIGN KEY ([OperationStatusCode])
    REFERENCES [dbo].[RefOperationStatus]
        ([OperationStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_AccountOperation'
CREATE INDEX [IX_fk_AccountOperation]
ON [dbo].[AccountOperations]
    ([OperationStatusCode]);
GO

-- Creating foreign key on [IdPartnerAccount] in table 'AccountOperations'
ALTER TABLE [dbo].[AccountOperations]
ADD CONSTRAINT [fk_AccountOperation_2]
    FOREIGN KEY ([IdPartnerAccount])
    REFERENCES [dbo].[Partners]
        ([IdPartner])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_AccountOperation_2'
CREATE INDEX [IX_fk_AccountOperation_2]
ON [dbo].[AccountOperations]
    ([IdPartnerAccount]);
GO

-- Creating foreign key on [OperationTypeCode] in table 'AccountOperations'
ALTER TABLE [dbo].[AccountOperations]
ADD CONSTRAINT [fk_AccountOperation_3]
    FOREIGN KEY ([OperationTypeCode])
    REFERENCES [dbo].[RefOperationTypes]
        ([OperationTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_AccountOperation_3'
CREATE INDEX [IX_fk_AccountOperation_3]
ON [dbo].[AccountOperations]
    ([OperationTypeCode]);
GO

-- Creating foreign key on [IdPatnerHistory] in table 'AccountOperations'
ALTER TABLE [dbo].[AccountOperations]
ADD CONSTRAINT [fk_AccountOperation_History]
    FOREIGN KEY ([IdPatnerHistory])
    REFERENCES [dbo].[PartnerBalanceHistories]
        ([IdPatnerHistory])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_AccountOperation_History'
CREATE INDEX [IX_fk_AccountOperation_History]
ON [dbo].[AccountOperations]
    ([IdPatnerHistory]);
GO

-- Creating foreign key on [IdAccountOperation] in table 'AccountOperations'
ALTER TABLE [dbo].[AccountOperations]
ADD CONSTRAINT [FK_AccountOperation_Request]
    FOREIGN KEY ([IdAccountOperation])
    REFERENCES [dbo].[AccountOperationRequests]
        ([IdAccountOperationRequest])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OperationStatusCode] in table 'AccountOperationRequests'
ALTER TABLE [dbo].[AccountOperationRequests]
ADD CONSTRAINT [FK_AccountOperationRequest_RefOperationStatus]
    FOREIGN KEY ([OperationStatusCode])
    REFERENCES [dbo].[RefOperationStatus]
        ([OperationStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountOperationRequest_RefOperationStatus'
CREATE INDEX [IX_FK_AccountOperationRequest_RefOperationStatus]
ON [dbo].[AccountOperationRequests]
    ([OperationStatusCode]);
GO

-- Creating foreign key on [OperationTypeCode] in table 'AccountOperationRequests'
ALTER TABLE [dbo].[AccountOperationRequests]
ADD CONSTRAINT [FK_AccountOperationRequest_RefOperationType]
    FOREIGN KEY ([OperationTypeCode])
    REFERENCES [dbo].[RefOperationTypes]
        ([OperationTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountOperationRequest_RefOperationType'
CREATE INDEX [IX_FK_AccountOperationRequest_RefOperationType]
ON [dbo].[AccountOperationRequests]
    ([OperationTypeCode]);
GO

-- Creating foreign key on [IdCustomerAccount] in table 'AccountOperationRequests'
ALTER TABLE [dbo].[AccountOperationRequests]
ADD CONSTRAINT [fk_OperationRequest_CustomerAccount]
    FOREIGN KEY ([IdCustomerAccount])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_OperationRequest_CustomerAccount'
CREATE INDEX [IX_fk_OperationRequest_CustomerAccount]
ON [dbo].[AccountOperationRequests]
    ([IdCustomerAccount]);
GO

-- Creating foreign key on [IdCity] in table 'Adresses'
ALTER TABLE [dbo].[Adresses]
ADD CONSTRAINT [fk_Adresse_City]
    FOREIGN KEY ([IdCity])
    REFERENCES [dbo].[Cities]
        ([IdCity])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Adresse_City'
CREATE INDEX [IX_fk_Adresse_City]
ON [dbo].[Adresses]
    ([IdCity]);
GO

-- Creating foreign key on [AddressTypeCode] in table 'Adresses'
ALTER TABLE [dbo].[Adresses]
ADD CONSTRAINT [FK_Adresse_RefAddressType]
    FOREIGN KEY ([AddressTypeCode])
    REFERENCES [dbo].[RefAddressTypes]
        ([AddressTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Adresse_RefAddressType'
CREATE INDEX [IX_FK_Adresse_RefAddressType]
ON [dbo].[Adresses]
    ([AddressTypeCode]);
GO

-- Creating foreign key on [IdAddress] in table 'CustomerAddresses'
ALTER TABLE [dbo].[CustomerAddresses]
ADD CONSTRAINT [fk_CustomerAddress]
    FOREIGN KEY ([IdAddress])
    REFERENCES [dbo].[Adresses]
        ([IdAddress])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_CustomerAddress'
CREATE INDEX [IX_fk_CustomerAddress]
ON [dbo].[CustomerAddresses]
    ([IdAddress]);
GO

-- Creating foreign key on [IdAddress] in table 'PartnerAddresses'
ALTER TABLE [dbo].[PartnerAddresses]
ADD CONSTRAINT [fk_PartnerAddress_Address]
    FOREIGN KEY ([IdAddress])
    REFERENCES [dbo].[Adresses]
        ([IdAddress])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_PartnerAddress_Address'
CREATE INDEX [IX_fk_PartnerAddress_Address]
ON [dbo].[PartnerAddresses]
    ([IdAddress]);
GO

-- Creating foreign key on [CodeRefBillStatus] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [fk_Bill]
    FOREIGN KEY ([CodeRefBillStatus])
    REFERENCES [dbo].[RefBillStatus]
        ([BillStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Bill'
CREATE INDEX [IX_fk_Bill]
ON [dbo].[Bills]
    ([CodeRefBillStatus]);
GO

-- Creating foreign key on [IdBill] in table 'BillPayments'
ALTER TABLE [dbo].[BillPayments]
ADD CONSTRAINT [fk_BillPayement_Bill]
    FOREIGN KEY ([IdBill])
    REFERENCES [dbo].[Bills]
        ([IdBill])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_BillPayement_Bill'
CREATE INDEX [IX_fk_BillPayement_Bill]
ON [dbo].[BillPayments]
    ([IdBill]);
GO

-- Creating foreign key on [CodeRefFactureType] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [fk_Facture]
    FOREIGN KEY ([CodeRefFactureType])
    REFERENCES [dbo].[RefBillTypes]
        ([BillTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Facture'
CREATE INDEX [IX_fk_Facture]
ON [dbo].[Bills]
    ([CodeRefFactureType]);
GO

-- Creating foreign key on [IdIssuingCustomer] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [fk_Facture_IssuingCustomer]
    FOREIGN KEY ([IdIssuingCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Facture_IssuingCustomer'
CREATE INDEX [IX_fk_Facture_IssuingCustomer]
ON [dbo].[Bills]
    ([IdIssuingCustomer]);
GO

-- Creating foreign key on [IdPayingCustomer] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [fk_Facture_PayingCustomer]
    FOREIGN KEY ([IdPayingCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Facture_PayingCustomer'
CREATE INDEX [IX_fk_Facture_PayingCustomer]
ON [dbo].[Bills]
    ([IdPayingCustomer]);
GO

-- Creating foreign key on [IdIssuingCustomer] in table 'BillPayments'
ALTER TABLE [dbo].[BillPayments]
ADD CONSTRAINT [fk_BillPayment_IssuingCustomer]
    FOREIGN KEY ([IdIssuingCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_BillPayment_IssuingCustomer'
CREATE INDEX [IX_fk_BillPayment_IssuingCustomer]
ON [dbo].[BillPayments]
    ([IdIssuingCustomer]);
GO

-- Creating foreign key on [IdPayingCustomer] in table 'BillPayments'
ALTER TABLE [dbo].[BillPayments]
ADD CONSTRAINT [fk_BillPayment_PayingCustomer]
    FOREIGN KEY ([IdPayingCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_BillPayment_PayingCustomer'
CREATE INDEX [IX_fk_BillPayment_PayingCustomer]
ON [dbo].[BillPayments]
    ([IdPayingCustomer]);
GO

-- Creating foreign key on [IdCustomer] in table 'Businesses'
ALTER TABLE [dbo].[Businesses]
ADD CONSTRAINT [fk_Business]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IndustryCategoryCode] in table 'Businesses'
ALTER TABLE [dbo].[Businesses]
ADD CONSTRAINT [fk_Business_IndustryCategory]
    FOREIGN KEY ([IndustryCategoryCode])
    REFERENCES [dbo].[RefIndustryCategories]
        ([IndustryCategoryCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Business_IndustryCategory'
CREATE INDEX [IX_fk_Business_IndustryCategory]
ON [dbo].[Businesses]
    ([IndustryCategoryCode]);
GO

-- Creating foreign key on [IdBusiness] in table 'BusinessContacts'
ALTER TABLE [dbo].[BusinessContacts]
ADD CONSTRAINT [fk_BusinessContact_Business]
    FOREIGN KEY ([IdBusiness])
    REFERENCES [dbo].[Businesses]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdContact] in table 'BusinessContacts'
ALTER TABLE [dbo].[BusinessContacts]
ADD CONSTRAINT [fk_BusinessContact_Contact]
    FOREIGN KEY ([IdContact])
    REFERENCES [dbo].[People]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_BusinessContact_Contact'
CREATE INDEX [IX_fk_BusinessContact_Contact]
ON [dbo].[BusinessContacts]
    ([IdContact]);
GO

-- Creating foreign key on [CountryCode] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [fk_City]
    FOREIGN KEY ([CountryCode])
    REFERENCES [dbo].[Countries]
        ([CountryCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_City'
CREATE INDEX [IX_fk_City]
ON [dbo].[Cities]
    ([CountryCode]);
GO

-- Creating foreign key on [IdDistrict] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [fk_City_0]
    FOREIGN KEY ([IdDistrict])
    REFERENCES [dbo].[Districts]
        ([IdDistrict])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_City_0'
CREATE INDEX [IX_fk_City_0]
ON [dbo].[Cities]
    ([IdDistrict]);
GO

-- Creating foreign key on [CountryCode] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [fk_Person]
    FOREIGN KEY ([CountryCode])
    REFERENCES [dbo].[Countries]
        ([CountryCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Person'
CREATE INDEX [IX_fk_Person]
ON [dbo].[People]
    ([CountryCode]);
GO

-- Creating foreign key on [CurrencyCode] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [fk_Customer_Currency]
    FOREIGN KEY ([CurrencyCode])
    REFERENCES [dbo].[Currencies]
        ([CurrencyCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Customer_Currency'
CREATE INDEX [IX_fk_Customer_Currency]
ON [dbo].[Customers]
    ([CurrencyCode]);
GO

-- Creating foreign key on [CurrencyCode] in table 'Partners'
ALTER TABLE [dbo].[Partners]
ADD CONSTRAINT [fk_Partner_0]
    FOREIGN KEY ([CurrencyCode])
    REFERENCES [dbo].[Currencies]
        ([CurrencyCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Partner_0'
CREATE INDEX [IX_fk_Partner_0]
ON [dbo].[Partners]
    ([CurrencyCode]);
GO

-- Creating foreign key on [IdRegistration] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [fk_Customer]
    FOREIGN KEY ([IdRegistration])
    REFERENCES [dbo].[Registrations]
        ([IdRegistration])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Customer'
CREATE INDEX [IX_fk_Customer]
ON [dbo].[Customers]
    ([IdRegistration]);
GO

-- Creating foreign key on [CustomerTypeCode] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [fk_Customer_CustomerType]
    FOREIGN KEY ([CustomerTypeCode])
    REFERENCES [dbo].[RefCustomerTypes]
        ([CustomerTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Customer_CustomerType'
CREATE INDEX [IX_fk_Customer_CustomerType]
ON [dbo].[Customers]
    ([CustomerTypeCode]);
GO

-- Creating foreign key on [IdMobileDevice] in table 'MobileDevices'
ALTER TABLE [dbo].[MobileDevices]
ADD CONSTRAINT [fk_Customer_Mobile]
    FOREIGN KEY ([IdMobileDevice])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCustomer] in table 'CustomerAddresses'
ALTER TABLE [dbo].[CustomerAddresses]
ADD CONSTRAINT [fk_CustomerAddress_0]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCustomerAccount] in table 'CustomerBalanceHistories'
ALTER TABLE [dbo].[CustomerBalanceHistories]
ADD CONSTRAINT [fk_CustomerBalanceHistory]
    FOREIGN KEY ([IdCustomerAccount])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_CustomerBalanceHistory'
CREATE INDEX [IX_fk_CustomerBalanceHistory]
ON [dbo].[CustomerBalanceHistories]
    ([IdCustomerAccount]);
GO

-- Creating foreign key on [IdMemberCustomer] in table 'CustomerGroups'
ALTER TABLE [dbo].[CustomerGroups]
ADD CONSTRAINT [fk_CustomerGroup_MemberAccount]
    FOREIGN KEY ([IdMemberCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_CustomerGroup_MemberAccount'
CREATE INDEX [IX_fk_CustomerGroup_MemberAccount]
ON [dbo].[CustomerGroups]
    ([IdMemberCustomer]);
GO

-- Creating foreign key on [IdCustomer] in table 'CustomerImages'
ALTER TABLE [dbo].[CustomerImages]
ADD CONSTRAINT [FK_CustomerImage_Customer]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCustomer] in table 'CustomerLogins'
ALTER TABLE [dbo].[CustomerLogins]
ADD CONSTRAINT [fk_CustomerLogin]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCustomerAccount] in table 'CustomerTags'
ALTER TABLE [dbo].[CustomerTags]
ADD CONSTRAINT [fk_customertags_customeraccount]
    FOREIGN KEY ([IdCustomerAccount])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_customertags_customeraccount'
CREATE INDEX [IX_fk_customertags_customeraccount]
ON [dbo].[CustomerTags]
    ([IdCustomerAccount]);
GO

-- Creating foreign key on [IdCustomer] in table 'KoloNotifications'
ALTER TABLE [dbo].[KoloNotifications]
ADD CONSTRAINT [fk_Notification_Customer]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Notification_Customer'
CREATE INDEX [IX_fk_Notification_Customer]
ON [dbo].[KoloNotifications]
    ([IdCustomer]);
GO

-- Creating foreign key on [IdPartner] in table 'Partners'
ALTER TABLE [dbo].[Partners]
ADD CONSTRAINT [fk_Partner_Customer]
    FOREIGN KEY ([IdPartner])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCustomer] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [fk_Person_Customer]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdTreasurerCustomer] in table 'RecurringContributions'
ALTER TABLE [dbo].[RecurringContributions]
ADD CONSTRAINT [fk_RecurringContribution_TreasuererCustomer]
    FOREIGN KEY ([IdTreasurerCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_RecurringContribution_TreasuererCustomer'
CREATE INDEX [IX_fk_RecurringContribution_TreasuererCustomer]
ON [dbo].[RecurringContributions]
    ([IdTreasurerCustomer]);
GO

-- Creating foreign key on [IdCustomerAccount] in table 'Transfert2CashDetails'
ALTER TABLE [dbo].[Transfert2CashDetails]
ADD CONSTRAINT [fk_Transfert2CashDetails]
    FOREIGN KEY ([IdCustomerAccount])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Transfert2CashDetails'
CREATE INDEX [IX_fk_Transfert2CashDetails]
ON [dbo].[Transfert2CashDetails]
    ([IdCustomerAccount]);
GO

-- Creating foreign key on [IdCustomer] in table 'TransfertE2e'
ALTER TABLE [dbo].[TransfertE2e]
ADD CONSTRAINT [fk_TransfertE2e_Customer]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertE2e_Customer'
CREATE INDEX [IX_fk_TransfertE2e_Customer]
ON [dbo].[TransfertE2e]
    ([IdCustomer]);
GO

-- Creating foreign key on [IdSendingCustomer] in table 'TransfertGroups'
ALTER TABLE [dbo].[TransfertGroups]
ADD CONSTRAINT [fk_TransfertGroup_Sender]
    FOREIGN KEY ([IdSendingCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertGroup_Sender'
CREATE INDEX [IX_fk_TransfertGroup_Sender]
ON [dbo].[TransfertGroups]
    ([IdSendingCustomer]);
GO

-- Creating foreign key on [IdSendingCustomer] in table 'TransfertGroupScheduleds'
ALTER TABLE [dbo].[TransfertGroupScheduleds]
ADD CONSTRAINT [fk_TransfertGroupScheduled_Sender]
    FOREIGN KEY ([IdSendingCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertGroupScheduled_Sender'
CREATE INDEX [IX_fk_TransfertGroupScheduled_Sender]
ON [dbo].[TransfertGroupScheduleds]
    ([IdSendingCustomer]);
GO

-- Creating foreign key on [IdReceiverCustomer] in table 'TransfertP2p'
ALTER TABLE [dbo].[TransfertP2p]
ADD CONSTRAINT [fk_TransfertP2p_Receiver]
    FOREIGN KEY ([IdReceiverCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertP2p_Receiver'
CREATE INDEX [IX_fk_TransfertP2p_Receiver]
ON [dbo].[TransfertP2p]
    ([IdReceiverCustomer]);
GO

-- Creating foreign key on [IdReceiverCustomer] in table 'TransfertScheduleds'
ALTER TABLE [dbo].[TransfertScheduleds]
ADD CONSTRAINT [fk_TransfertScheduled_Receiver]
    FOREIGN KEY ([IdReceiverCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertScheduled_Receiver'
CREATE INDEX [IX_fk_TransfertScheduled_Receiver]
ON [dbo].[TransfertScheduleds]
    ([IdReceiverCustomer]);
GO

-- Creating foreign key on [IdSendingCustomer] in table 'TransfertScheduleds'
ALTER TABLE [dbo].[TransfertScheduleds]
ADD CONSTRAINT [fk_TransfertScheduled_Sender]
    FOREIGN KEY ([IdSendingCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertScheduled_Sender'
CREATE INDEX [IX_fk_TransfertScheduled_Sender]
ON [dbo].[TransfertScheduleds]
    ([IdSendingCustomer]);
GO

-- Creating foreign key on [OperationTypeCode] in table 'CustomerBalanceHistories'
ALTER TABLE [dbo].[CustomerBalanceHistories]
ADD CONSTRAINT [fk_CustomerBalanceHistory_0]
    FOREIGN KEY ([OperationTypeCode])
    REFERENCES [dbo].[RefOperationTypes]
        ([OperationTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_CustomerBalanceHistory_0'
CREATE INDEX [IX_fk_CustomerBalanceHistory_0]
ON [dbo].[CustomerBalanceHistories]
    ([OperationTypeCode]);
GO

-- Creating foreign key on [IdExternalAccount] in table 'CustomerExternalAccounts'
ALTER TABLE [dbo].[CustomerExternalAccounts]
ADD CONSTRAINT [fk_Customer_ExternalAccount]
    FOREIGN KEY ([IdExternalAccount])
    REFERENCES [dbo].[ExternalAccounts]
        ([IdExternalAccount])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Customer_ExternalAccount'
CREATE INDEX [IX_fk_Customer_ExternalAccount]
ON [dbo].[CustomerExternalAccounts]
    ([IdExternalAccount]);
GO

-- Creating foreign key on [GroupTypeCode] in table 'CustomerGroups'
ALTER TABLE [dbo].[CustomerGroups]
ADD CONSTRAINT [fk_CustomerGroup_GroupType]
    FOREIGN KEY ([GroupTypeCode])
    REFERENCES [dbo].[RefGroupTypes]
        ([GroupTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_CustomerGroup_GroupType'
CREATE INDEX [IX_fk_CustomerGroup_GroupType]
ON [dbo].[CustomerGroups]
    ([GroupTypeCode]);
GO

-- Creating foreign key on [IdCustomerGroup] in table 'GroupImages'
ALTER TABLE [dbo].[GroupImages]
ADD CONSTRAINT [FK_GroupImage_CustomerGroup]
    FOREIGN KEY ([IdCustomerGroup])
    REFERENCES [dbo].[CustomerGroups]
        ([IdCustomerGroup])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCustomerGroup] in table 'RecurringContributions'
ALTER TABLE [dbo].[RecurringContributions]
ADD CONSTRAINT [fk_RecurringContribution_CustomerGroup]
    FOREIGN KEY ([IdCustomerGroup])
    REFERENCES [dbo].[CustomerGroups]
        ([IdCustomerGroup])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_RecurringContribution_CustomerGroup'
CREATE INDEX [IX_fk_RecurringContribution_CustomerGroup]
ON [dbo].[RecurringContributions]
    ([IdCustomerGroup]);
GO

-- Creating foreign key on [IdReceiverGroup] in table 'TransfertGroups'
ALTER TABLE [dbo].[TransfertGroups]
ADD CONSTRAINT [fk_TransfertGroup_ReceiverGroup]
    FOREIGN KEY ([IdReceiverGroup])
    REFERENCES [dbo].[CustomerGroups]
        ([IdCustomerGroup])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertGroup_ReceiverGroup'
CREATE INDEX [IX_fk_TransfertGroup_ReceiverGroup]
ON [dbo].[TransfertGroups]
    ([IdReceiverGroup]);
GO

-- Creating foreign key on [IdReceiverGroup] in table 'TransfertGroupScheduleds'
ALTER TABLE [dbo].[TransfertGroupScheduleds]
ADD CONSTRAINT [fk_TransfertGroupScheduled_ReceiverGroup]
    FOREIGN KEY ([IdReceiverGroup])
    REFERENCES [dbo].[CustomerGroups]
        ([IdCustomerGroup])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertGroupScheduled_ReceiverGroup'
CREATE INDEX [IX_fk_TransfertGroupScheduled_ReceiverGroup]
ON [dbo].[TransfertGroupScheduleds]
    ([IdReceiverGroup]);
GO

-- Creating foreign key on [LoginStatusCode] in table 'CustomerLogins'
ALTER TABLE [dbo].[CustomerLogins]
ADD CONSTRAINT [fk_CustomerLogin_StatusCode]
    FOREIGN KEY ([LoginStatusCode])
    REFERENCES [dbo].[RefLoginStatus]
        ([LoginStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_CustomerLogin_StatusCode'
CREATE INDEX [IX_fk_CustomerLogin_StatusCode]
ON [dbo].[CustomerLogins]
    ([LoginStatusCode]);
GO

-- Creating foreign key on [IdCustomer] in table 'LoginAttempts'
ALTER TABLE [dbo].[LoginAttempts]
ADD CONSTRAINT [fk_LoginAttempt_Customer]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[CustomerLogins]
        ([IdCustomer])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_LoginAttempt_Customer'
CREATE INDEX [IX_fk_LoginAttempt_Customer]
ON [dbo].[LoginAttempts]
    ([IdCustomer]);
GO

-- Creating foreign key on [IdTag] in table 'CustomerTags'
ALTER TABLE [dbo].[CustomerTags]
ADD CONSTRAINT [fk_customertags_tag]
    FOREIGN KEY ([IdTag])
    REFERENCES [dbo].[Tags]
        ([IdTag])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_customertags_tag'
CREATE INDEX [IX_fk_customertags_tag]
ON [dbo].[CustomerTags]
    ([IdTag]);
GO

-- Creating foreign key on [IdExternalAccount] in table 'ExternalAccountHistories'
ALTER TABLE [dbo].[ExternalAccountHistories]
ADD CONSTRAINT [fk_ExternalAccount_History]
    FOREIGN KEY ([IdExternalAccount])
    REFERENCES [dbo].[ExternalAccounts]
        ([IdExternalAccount])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_ExternalAccount_History'
CREATE INDEX [IX_fk_ExternalAccount_History]
ON [dbo].[ExternalAccountHistories]
    ([IdExternalAccount]);
GO

-- Creating foreign key on [ExternalAccountTypeCode] in table 'ExternalAccounts'
ALTER TABLE [dbo].[ExternalAccounts]
ADD CONSTRAINT [fk_ExternalAccount_Type]
    FOREIGN KEY ([ExternalAccountTypeCode])
    REFERENCES [dbo].[RefExternalAccountTypes]
        ([ExternalAccountTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_ExternalAccount_Type'
CREATE INDEX [IX_fk_ExternalAccount_Type]
ON [dbo].[ExternalAccounts]
    ([ExternalAccountTypeCode]);
GO

-- Creating foreign key on [IdReceiverExternalAccount] in table 'TransfertE2e'
ALTER TABLE [dbo].[TransfertE2e]
ADD CONSTRAINT [fk_TransfertE2e_ExternalReceiver]
    FOREIGN KEY ([IdReceiverExternalAccount])
    REFERENCES [dbo].[ExternalAccounts]
        ([IdExternalAccount])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertE2e_ExternalReceiver'
CREATE INDEX [IX_fk_TransfertE2e_ExternalReceiver]
ON [dbo].[TransfertE2e]
    ([IdReceiverExternalAccount]);
GO

-- Creating foreign key on [IdSendingExternalAccount] in table 'TransfertE2e'
ALTER TABLE [dbo].[TransfertE2e]
ADD CONSTRAINT [fk_TransfertE2e_ExternalSender]
    FOREIGN KEY ([IdSendingExternalAccount])
    REFERENCES [dbo].[ExternalAccounts]
        ([IdExternalAccount])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertE2e_ExternalSender'
CREATE INDEX [IX_fk_TransfertE2e_ExternalSender]
ON [dbo].[TransfertE2e]
    ([IdSendingExternalAccount]);
GO

-- Creating foreign key on [IdCustomer] in table 'KoloUsers'
ALTER TABLE [dbo].[KoloUsers]
ADD CONSTRAINT [FK_User_Person]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[People]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [LoginStatusCode] in table 'KoloUsers'
ALTER TABLE [dbo].[KoloUsers]
ADD CONSTRAINT [FK_User_RefLoginStatus]
    FOREIGN KEY ([LoginStatusCode])
    REFERENCES [dbo].[RefLoginStatus]
        ([LoginStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_RefLoginStatus'
CREATE INDEX [IX_FK_User_RefLoginStatus]
ON [dbo].[KoloUsers]
    ([LoginStatusCode]);
GO

-- Creating foreign key on [ResultCode] in table 'LoginAttempts'
ALTER TABLE [dbo].[LoginAttempts]
ADD CONSTRAINT [fk_LoginAttempt_ResultCode]
    FOREIGN KEY ([ResultCode])
    REFERENCES [dbo].[RefResults]
        ([ResultCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_LoginAttempt_ResultCode'
CREATE INDEX [IX_fk_LoginAttempt_ResultCode]
ON [dbo].[LoginAttempts]
    ([ResultCode]);
GO

-- Creating foreign key on [PartnerTypeCode] in table 'Partners'
ALTER TABLE [dbo].[Partners]
ADD CONSTRAINT [fk_Partner]
    FOREIGN KEY ([PartnerTypeCode])
    REFERENCES [dbo].[RefPartnerTypes]
        ([PartnerTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Partner'
CREATE INDEX [IX_fk_Partner]
ON [dbo].[Partners]
    ([PartnerTypeCode]);
GO

-- Creating foreign key on [IdPartner] in table 'PartnerAddresses'
ALTER TABLE [dbo].[PartnerAddresses]
ADD CONSTRAINT [fk_PartnerAddress_Partner]
    FOREIGN KEY ([IdPartner])
    REFERENCES [dbo].[Partners]
        ([IdPartner])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdResellerPartnerAccount] in table 'Provisions'
ALTER TABLE [dbo].[Provisions]
ADD CONSTRAINT [fk_Provision_ResellerPartnerAccount]
    FOREIGN KEY ([IdResellerPartnerAccount])
    REFERENCES [dbo].[Partners]
        ([IdPartner])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Provision_ResellerPartnerAccount'
CREATE INDEX [IX_fk_Provision_ResellerPartnerAccount]
ON [dbo].[Provisions]
    ([IdResellerPartnerAccount]);
GO

-- Creating foreign key on [IdWholesalerPartnerAccount] in table 'Provisions'
ALTER TABLE [dbo].[Provisions]
ADD CONSTRAINT [fk_Provision_WholesalerPartnerAccount]
    FOREIGN KEY ([IdWholesalerPartnerAccount])
    REFERENCES [dbo].[Partners]
        ([IdPartner])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Provision_WholesalerPartnerAccount'
CREATE INDEX [IX_fk_Provision_WholesalerPartnerAccount]
ON [dbo].[Provisions]
    ([IdWholesalerPartnerAccount]);
GO

-- Creating foreign key on [IdPartner] in table 'Resellers'
ALTER TABLE [dbo].[Resellers]
ADD CONSTRAINT [fk_Reseller]
    FOREIGN KEY ([IdPartner])
    REFERENCES [dbo].[Partners]
        ([IdPartner])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPartnerAccount] in table 'Transfert2Cash'
ALTER TABLE [dbo].[Transfert2Cash]
ADD CONSTRAINT [fk_Transfert2Cash_PartnerAccount]
    FOREIGN KEY ([IdPartnerAccount])
    REFERENCES [dbo].[Partners]
        ([IdPartner])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Transfert2Cash_PartnerAccount'
CREATE INDEX [IX_fk_Transfert2Cash_PartnerAccount]
ON [dbo].[Transfert2Cash]
    ([IdPartnerAccount]);
GO

-- Creating foreign key on [IdPartner] in table 'Wholesalers'
ALTER TABLE [dbo].[Wholesalers]
ADD CONSTRAINT [fk_Wholesaler]
    FOREIGN KEY ([IdPartner])
    REFERENCES [dbo].[Partners]
        ([IdPartner])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPatnerHistory] in table 'Provisions'
ALTER TABLE [dbo].[Provisions]
ADD CONSTRAINT [fk_Provision_History]
    FOREIGN KEY ([IdPatnerHistory])
    REFERENCES [dbo].[PartnerBalanceHistories]
        ([IdPatnerHistory])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Provision_History'
CREATE INDEX [IX_fk_Provision_History]
ON [dbo].[Provisions]
    ([IdPatnerHistory]);
GO

-- Creating foreign key on [GenderCode] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [fk_Person_Gender]
    FOREIGN KEY ([GenderCode])
    REFERENCES [dbo].[RefGenders]
        ([GenderCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Person_Gender'
CREATE INDEX [IX_fk_Person_Gender]
ON [dbo].[People]
    ([GenderCode]);
GO

-- Creating foreign key on [MaritalStatusCode] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [fk_Person_MaritalStatus]
    FOREIGN KEY ([MaritalStatusCode])
    REFERENCES [dbo].[RefMaritalStatus]
        ([MaritalStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Person_MaritalStatus'
CREATE INDEX [IX_fk_Person_MaritalStatus]
ON [dbo].[People]
    ([MaritalStatusCode]);
GO

-- Creating foreign key on [IdCustomer] in table 'PersonRelationships'
ALTER TABLE [dbo].[PersonRelationships]
ADD CONSTRAINT [fk_Relationship_Customer]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[People]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPersonRelation] in table 'PersonRelationships'
ALTER TABLE [dbo].[PersonRelationships]
ADD CONSTRAINT [fk_Relationship_PersonRelation]
    FOREIGN KEY ([IdPersonRelation])
    REFERENCES [dbo].[People]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Relationship_PersonRelation'
CREATE INDEX [IX_fk_Relationship_PersonRelation]
ON [dbo].[PersonRelationships]
    ([IdPersonRelation]);
GO

-- Creating foreign key on [RelationshipTypeCode] in table 'PersonRelationships'
ALTER TABLE [dbo].[PersonRelationships]
ADD CONSTRAINT [fk_Relationship_TypeCode]
    FOREIGN KEY ([RelationshipTypeCode])
    REFERENCES [dbo].[RefPersonRelationshipTypes]
        ([RelationshipTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Relationship_TypeCode'
CREATE INDEX [IX_fk_Relationship_TypeCode]
ON [dbo].[PersonRelationships]
    ([RelationshipTypeCode]);
GO

-- Creating foreign key on [CodeRefProsisionStatus] in table 'Provisions'
ALTER TABLE [dbo].[Provisions]
ADD CONSTRAINT [fk_Provision_StatusCode]
    FOREIGN KEY ([CodeRefProsisionStatus])
    REFERENCES [dbo].[RefProvisionStatus]
        ([ProvisionStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Provision_StatusCode'
CREATE INDEX [IX_fk_Provision_StatusCode]
ON [dbo].[Provisions]
    ([CodeRefProsisionStatus]);
GO

-- Creating foreign key on [OperationTypeCode] in table 'TransfertE2e'
ALTER TABLE [dbo].[TransfertE2e]
ADD CONSTRAINT [fk_TransfertE2e_OperationtType]
    FOREIGN KEY ([OperationTypeCode])
    REFERENCES [dbo].[RefOperationTypes]
        ([OperationTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertE2e_OperationtType'
CREATE INDEX [IX_fk_TransfertE2e_OperationtType]
ON [dbo].[TransfertE2e]
    ([OperationTypeCode]);
GO

-- Creating foreign key on [RegistrationStatusCode] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [fk_Registration]
    FOREIGN KEY ([RegistrationStatusCode])
    REFERENCES [dbo].[RefRegistrationStatus]
        ([RegistrationStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Registration'
CREATE INDEX [IX_fk_Registration]
ON [dbo].[Registrations]
    ([RegistrationStatusCode]);
GO

-- Creating foreign key on [TransfertStatusCode] in table 'TransfertE2e'
ALTER TABLE [dbo].[TransfertE2e]
ADD CONSTRAINT [fk_TransfertE2e_StatusCode]
    FOREIGN KEY ([TransfertStatusCode])
    REFERENCES [dbo].[RefTransfertStatus]
        ([TransfertStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertE2e_StatusCode'
CREATE INDEX [IX_fk_TransfertE2e_StatusCode]
ON [dbo].[TransfertE2e]
    ([TransfertStatusCode]);
GO

-- Creating foreign key on [CodeTransfertStatus] in table 'TransfertGroups'
ALTER TABLE [dbo].[TransfertGroups]
ADD CONSTRAINT [fk_TransfertGroup_StatusCode]
    FOREIGN KEY ([CodeTransfertStatus])
    REFERENCES [dbo].[RefTransfertStatus]
        ([TransfertStatusCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_TransfertGroup_StatusCode'
CREATE INDEX [IX_fk_TransfertGroup_StatusCode]
ON [dbo].[TransfertGroups]
    ([CodeTransfertStatus]);
GO

-- Creating foreign key on [CustomerGroupAdmin_CustomerGroup_IdCustomer] in table 'CustomerGroupAdmin'
ALTER TABLE [dbo].[CustomerGroupAdmin]
ADD CONSTRAINT [FK_CustomerGroupAdmin_Customer]
    FOREIGN KEY ([CustomerGroupAdmin_CustomerGroup_IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CustomerGroupAdmin_Customer_IdCustomerGroup] in table 'CustomerGroupAdmin'
ALTER TABLE [dbo].[CustomerGroupAdmin]
ADD CONSTRAINT [FK_CustomerGroupAdmin_CustomerGroup]
    FOREIGN KEY ([CustomerGroupAdmin_Customer_IdCustomerGroup])
    REFERENCES [dbo].[CustomerGroups]
        ([IdCustomerGroup])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerGroupAdmin_CustomerGroup'
CREATE INDEX [IX_FK_CustomerGroupAdmin_CustomerGroup]
ON [dbo].[CustomerGroupAdmin]
    ([CustomerGroupAdmin_Customer_IdCustomerGroup]);
GO

-- Creating foreign key on [IdSendingCustomer] in table 'TransfertP2p'
ALTER TABLE [dbo].[TransfertP2p]
ADD CONSTRAINT [FK_TransfertP2p_Sender]
    FOREIGN KEY ([IdSendingCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransfertP2p_Sender'
CREATE INDEX [IX_FK_TransfertP2p_Sender]
ON [dbo].[TransfertP2p]
    ([IdSendingCustomer]);
GO

-- Creating foreign key on [IdCustomer] in table 'EneoBillPayments'
ALTER TABLE [dbo].[EneoBillPayments]
ADD CONSTRAINT [FK_EneoBillPayment_Customer]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EneoBillPayment_Customer'
CREATE INDEX [IX_FK_EneoBillPayment_Customer]
ON [dbo].[EneoBillPayments]
    ([IdCustomer]);
GO

-- Creating foreign key on [IdCustomer] in table 'TopUps'
ALTER TABLE [dbo].[TopUps]
ADD CONSTRAINT [FK_TopUp_Customer]
    FOREIGN KEY ([IdCustomer])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TopUp_Customer'
CREATE INDEX [IX_FK_TopUp_Customer]
ON [dbo].[TopUps]
    ([IdCustomer]);
GO

-- Creating foreign key on [KoloSenderId] in table 'TransferGravities'
ALTER TABLE [dbo].[TransferGravities]
ADD CONSTRAINT [FK_TransferGravity_Customer]
    FOREIGN KEY ([KoloSenderId])
    REFERENCES [dbo].[Customers]
        ([IdCustomer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransferGravity_Customer'
CREATE INDEX [IX_FK_TransferGravity_Customer]
ON [dbo].[TransferGravities]
    ([KoloSenderId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------