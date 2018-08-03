using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Util.Entities;
using KoloWin.CustomerService.Utils.Entities;
using KoloWin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace KoloWin.CustomerService
{
    /// <summary>
    /// Summary description for KolOAcMerg
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KolOAcMerg : System.Web.Services.WebService
    {


        #region Personal Account Management Methods


        [WebMethod]
        public string UpdateCustomerAccount(string jsonCustomer)
        {
            string error = "";
            Customer customer = SerializationHelper.DeserializeFromJsonString<Customer>(jsonCustomer);
            var context = new KoloAndroidEntities();
            var tmp = context.Customers.Include("Person").FirstOrDefault(c => c.IdCustomer == customer.IdCustomer);
            MobileDevice mobileDevice = null;
            if (customer.MobileDevices[0] != null)
                mobileDevice = context.MobileDevices.FirstOrDefault(m => m.IdCustomer == customer.IdCustomer && m.IdMobileDevice == customer.MobileDevices[0].IdMobileDevice);
            CustomerHelper.UpdateCustomerAccount(ref tmp, customer,ref mobileDevice, context, out error);
            context.SaveChanges();
            KoloWsObject<Customer> koloWs = new KoloWsObject<Customer>(error, tmp);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }
        
        [WebMethod]
        public string ConvertToBusinessAccount(string jsonCustomer)
        {
            string error = "";
            Customer customer = SerializationHelper.DeserializeFromJsonString<Customer>(jsonCustomer);
            if(customer.Business == null )
            {
                error = "Aucun paramtres de Compte Business Entrée";
                KoloWsObject<Customer> koloWs = new KoloWsObject<Customer>(error);
                var result = SerializationHelper.SerializeToJson(koloWs);
                return result;
            }
            else if(customer.Person == null)
            {
                error = "Aucun paramtres de la personne Entrée";
                KoloWsObject<Customer> koloWs = new KoloWsObject<Customer>(error);
                var result = SerializationHelper.SerializeToJson(koloWs);
                return result;
            }
            else
            {
                var context = new KoloAndroidEntities();
                Business business = context.Businesses.Add(customer.Business);
                BusinessContact businessContact = context.BusinessContacts.Add(new BusinessContact()
                {
                    IdBusiness = customer.IdCustomer,
                    IdContact = customer.IdCustomer
                } );
                context.SaveChanges();
                KoloWsObject<Business> koloWs = new KoloWsObject<Business>(error, business);
                var result = SerializationHelper.SerializeToJson(koloWs);
                context.Dispose();
                return result;
            }
            
        }

        [WebMethod]
        public string UpdateBusinessAccount(string jsonBusinessAccount)
        {
            string error = "";
            Business business = SerializationHelper.DeserializeFromJsonString<Business>(jsonBusinessAccount);
            if (business == null)
            {
                error = "Aucun paramtres de Compte Business Entrée";
                KoloWsObject<Customer> koloWs = new KoloWsObject<Customer>(error);
                var result = SerializationHelper.SerializeToJson(koloWs);
                return result;
            }
            else
            {
                var context = new KoloAndroidEntities();
                Business businessAccount = context.Businesses.FirstOrDefault(b => b.IdCustomer == business.IdCustomer);
                businessAccount.BusinessName = businessAccount.BusinessName ?? businessAccount.BusinessName;
                businessAccount.IndustryCategoryCode = business.IndustryCategoryCode ?? businessAccount.IndustryCategoryCode;
                businessAccount.RefIndustryCategory = business.RefIndustryCategory ?? businessAccount.RefIndustryCategory;
                context.SaveChanges();
                KoloWsObject<Business> koloWs = new KoloWsObject<Business>(error, businessAccount);
                var result = SerializationHelper.SerializeToJson(koloWs);
                context.Dispose();
                return result;
            }
        }


        [WebMethod]
        public string UpdateBusinessContact(string jsonBusinessContact)
        {
            string error = "";
            BusinessContact businessContact = SerializationHelper.DeserializeFromJsonString<BusinessContact>(jsonBusinessContact);
            if (businessContact == null)
            {
                error = "Aucun paramtres de Compte Business Contact";
                KoloWsObject<BusinessContact> koloWs = new KoloWsObject<BusinessContact>(error);
                var result = SerializationHelper.SerializeToJson(koloWs);
                return result;
            }
            else
            {
                var context = new KoloAndroidEntities();
                BusinessContact businessContactEF = context.BusinessContacts.FirstOrDefault(b => b.IdBusiness == businessContact.IdBusiness);
                ////////////////////////////////////////////////////////

                BusinessContactUpdateHistory businessContactUpdateHistory = new BusinessContactUpdateHistory();
                businessContactUpdateHistory.Date = DateTime.Now;
                businessContactUpdateHistory.IdBusiness = businessContact.IdBusiness;
                businessContactUpdateHistory.IdContact = businessContact.IdContact;
                businessContactUpdateHistory.OldJobTitle = businessContactEF.JobTitle;
                businessContactUpdateHistory.NewJobTitle = businessContact.JobTitle;
                context.BusinessContactUpdateHistories.Add(businessContactUpdateHistory);

                ////////////////////////////////////////////////////////
                businessContactEF.IdContact = businessContact.IdContact != 0 ? businessContact.IdContact : businessContactEF.IdContact;
                businessContactEF.JobTitle = businessContact.JobTitle ?? businessContactEF.JobTitle;

                context.SaveChanges();
                KoloWsObject<BusinessContact> koloWs = new KoloWsObject<BusinessContact>(error, businessContactEF);
                var result = SerializationHelper.SerializeToJson(koloWs);
                context.Dispose();
                return result;
            }
        }


        [WebMethod]
        public string AddMobileDevice(string jsonMobileDevice)
        {
            string error = "";
            MobileDevice mobileDevice = SerializationHelper.DeserializeFromJsonString<MobileDevice>(jsonMobileDevice);
            var context = new KoloAndroidEntities();
            context.MobileDevices.Add(mobileDevice);
            context.SaveChanges();
            KoloWsObject<MobileDevice> koloWs = new KoloWsObject<MobileDevice> (error, mobileDevice);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }
        
        [WebMethod]
        public string RevokeMobileDevice(string jsonIdMobileDevice)
        {
            string error = "";
            MobileDevice mobileDevice = SerializationHelper.DeserializeFromJsonString<MobileDevice>(jsonIdMobileDevice);
            var context = new KoloAndroidEntities();
            context.Configuration.ProxyCreationEnabled = false;
            var tmp = context.MobileDevices.FirstOrDefault(c => c.IdMobileDevice == mobileDevice.IdMobileDevice);
            tmp.isActive = false;
            context.SaveChanges();
            KoloWsObject<MobileDevice> koloWs = new KoloWsObject<MobileDevice>(error, tmp);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }


        [WebMethod]
        public string GetProfileImage(string jsonIdCustomer)
        {
            string error = "";
            List<KoloNotification> cBHs = null;
            var context = new KoloAndroidEntities();
            cBHs = context.KoloNotifications.Where(c => c.IdCustomer == 1).ToList();
            KoloWsObject<List<KoloNotification>> koloWs = new KoloWsObject<List<KoloNotification>>(error, cBHs);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }
         
        [WebMethod]
        public string UpdateProfileImage(string jsonIdCustomer)
        {
            string error = "";
            List<KoloNotification> cBHs = null;
            var context = new KoloAndroidEntities();
            cBHs = context.KoloNotifications.Where(c => c.IdCustomer == 1).ToList();
            KoloWsObject<List<KoloNotification>> koloWs = new KoloWsObject<List<KoloNotification>>(error, cBHs);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }


        #endregion



        #region Device Management Methods

        #endregion



        #region Device Management Methods

        #endregion




    }
}
