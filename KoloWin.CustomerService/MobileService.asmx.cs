using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Util;
using KoloWin.CustomerService.Util.Entities;
using KoloWin.CustomerService.Utils.General;
using KoloWin.Utilities;

namespace KoloWin.CustomerService
{
    /// <summary>
    /// Summary description for MobileService
    /// </summary>
    [WebService(Namespace = "http://kolo.cyberix.fr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]


    public class MobileService : System.Web.Services.WebService
    {
        #region Method De Test

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public RefGender GetRefGender()
        {
            var refGender = new RefGender()
            {
                GenderCode = "M",
                GenderDescription = "Male",
            };


            return refGender;
        }

        //[WebMethod]
        //public void CreatePerson(string jsonPerson)
        //{
        //    var person = SerializationHelper.DeserializeFromJsonString<Person>(jsonPerson);
        //    var Context = new KoloAndroidEntities();
        //    Context.People.Add(person);
        //    Context.Dispose();
        //}

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public MyRefTypes TestService(MyRefTypes myRefTypes)
        {
            return myRefTypes;
        }


        #endregion

        #region Generals Methods

        //[WebMethod]
        //public string InsertMobileDevice(string jsonMobileDevice)
        //{
        //    string error = "";
        //    MobileDevice mobileDevice = SerializationHelper.DeserializeFromJsonString<MobileDevice>(jsonMobileDevice) as MobileDevice;
        //    var context = new KoloAndroidEntities4Serialization();
        //    mobileDevice = MobileDeviceHelper.InsertMobileDevice(ref mobileDevice, context, out error);
        //    KoloWsObject<MobileDevice> koloWs = new KoloWsObject<MobileDevice>(error, mobileDevice);
        //    var result = SerializationHelper.SerializeToJson(koloWs);
        //    context.Dispose();
        //    return result;
        //}

        [WebMethod]
        public string GetCustomerByIdCustomerAndNumber(int idCustomer, string number)
        {
            var Context = new KoloAndroidEntities();
            SimpleContact simpleContact = new SimpleContact()
            {
                FirstName = "name...",
                LastName = "Full",
                Telephone = "Phone number..."
            };
            Customer outCustomer;
            var customerQuery = Context.Customers.Include("MobileDevice").Include("Person").Include("Registration");
            if (idCustomer > 0)
                outCustomer = customerQuery.Where(e => e.IdCustomer == idCustomer).FirstOrDefault();
            else
                outCustomer = customerQuery.Where(e => e.Registration.PhoneNumber == number).FirstOrDefault();
            if (outCustomer != null)
                simpleContact = new SimpleContact(outCustomer);
            KoloWsObject<SimpleContact> koloWs = new KoloWsObject<SimpleContact>("", simpleContact);
            var result = SerializationHelper.SerializeToJson(koloWs);
            Context.Dispose();
            return result;
        }

        [WebMethod]
        public string GetCustomerAccount(int idCustomer)
        {
            var Context = new KoloAndroidEntities();
            Customer outCustomer = Context.Customers
                .Include("MobileDevice").Include("Person").Include("Registration")
                .FirstOrDefault(e => e.IdCustomer == idCustomer);
            KoloWsObject<Customer> koloWs = new KoloWsObject<Customer>("", outCustomer);
            var result = SerializationHelper.SerializeToJson(koloWs);
            Context.Dispose();
            return result;
        }

        [WebMethod]
        public string GetParameters()
        {
            var Context = new KoloAndroidEntities();
            ParameterInfo parameters = new ParameterInfo();
            String error;
            parameters.Refresh(Context, out error);
            KoloWsObject<ParameterInfo> koloWs = new KoloWsObject<ParameterInfo>(error, parameters);
            var result = SerializationHelper.SerializeToJson(koloWs);
            Context.Dispose();
            return result;
        }

        [WebMethod]
        public string GetCustomerContacts(string contacts, string idCustomer)
        {
            var Context = new KoloAndroidEntities();
            var result = SerializationHelper.SerializeToJson("");
            Context.Dispose();
            return result;
        }
        
        
        [WebMethod]
        public string GetAccountDatas(int idCustomer)
        {
            var Context = new KoloAndroidEntities();
            Context.Configuration.ProxyCreationEnabled = false;
            Customer customer = Context.Customers.FirstOrDefault(c => c.IdCustomer == idCustomer);
            List<ExternalAccount> externalAccounts = Context.ExternalAccounts.Where(c => c.IdCustomer == idCustomer).ToList();
            List<CreditCardInfo> cards = new List<CreditCardInfo>();
            foreach(ExternalAccount e in externalAccounts)
                if (e.IdCreditCard > 0)
                    cards.Add(Context.CreditCardInfoes.FirstOrDefault(c => c.IdCreditCardInfo == e.IdCreditCard));
            Person person = Context.People.FirstOrDefault(p => p.IdCustomer == idCustomer);
            var tuple = new Tuple<Customer, List<ExternalAccount>, List<CreditCardInfo>, Person>(customer, externalAccounts, cards, person);
            KoloWsObject<Tuple<Customer, List<ExternalAccount>, List<CreditCardInfo>, Person>> koloWs = new KoloWsObject<Tuple<Customer, List<ExternalAccount>, List<CreditCardInfo>, Person>>("", tuple);
            Context.Dispose();
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }

        #endregion

        #region Kolo MAD Methods

        [WebMethod]
        public string FindCustomerMad(string jsonMadCustomer)
        {
            string error = "";
            KoloMadCustomer madCustomer = SerializationHelper.DeserializeFromJsonString<KoloMadCustomer>(jsonMadCustomer);
            Madhelper.FindCustomerMad(ref madCustomer, out error);
            KoloWsObject<KoloMadCustomer> koloWs = new KoloWsObject<KoloMadCustomer>("", madCustomer);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }

        [WebMethod]
        public string FindManagerCustomerByPhone(string phone)
        {
            string error = "";
            var managerCustomer = Madhelper.FindManagerCustomerByPhone(phone, out error);
            KoloWsObject<string> koloWs = new KoloWsObject<string>(error, managerCustomer);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }

        [WebMethod]
        public string FindManagerCustomerByCustomerCode(string customerCode)
        {
            string error = "";
            var managerCustomer = Madhelper.FindManagerCustomerByCustomerCode(customerCode, out error);
            KoloWsObject<string> koloWs = new KoloWsObject<string>(error, managerCustomer);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }


        [WebMethod]
        public string GetMADFees(int montant)
        {
            string error = "";
            var idMad = Madhelper.GetMADFees(montant, out error);
            KoloWsObject<int> koloWs = new KoloWsObject<int>(error, idMad);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }



        #endregion
        
        #region Histories Methods

        [WebMethod]
        public string GetEneoBillPaymentHistory(int jsonIdCustomer)
        {
            string error = "";
            List<EneoBillPayment> eBPs = null;
            var context = new KoloAndroidEntities4Serialization();
            Customer customer = context.Customers.FirstOrDefault(c => c.IdCustomer == jsonIdCustomer);
            eBPs = context.EneoBillPayments.Where(e => e.IdCustomer == jsonIdCustomer).ToList();
            List<EneoBillDetails> eBDs = null;
            if (eBPs != null)
                eBDs = eBPs.Select(e => new EneoBillDetails(e)).ToList();
            KoloWsObject<List<EneoBillDetails>> koloWs = new KoloWsObject<List<EneoBillDetails>>(error, eBDs);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }
        
        [WebMethod]
        public string GetCustomerBalanceHistory(int jsonIdCustomer)
        {
            string error = "";
            List<CustomerBalanceHistory> cBHs = null;
            var context = new KoloAndroidEntities();
            cBHs = context.CustomerBalanceHistories.Where(c => c.IdCustomerAccount == jsonIdCustomer).ToList();
            KoloWsObject<List<CustomerBalanceHistory>> koloWs = new KoloWsObject<List<CustomerBalanceHistory>>(error, cBHs);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }

        [WebMethod]
        public string GetCustomerNotifications(int jsonIdCustomer)
        {
            string error = "";
            List<KoloNotification> cBHs = null;
            var context = new KoloAndroidEntities();
            context.Configuration.ProxyCreationEnabled = false;
            cBHs = context.KoloNotifications.Where(c => c.IdCustomer == jsonIdCustomer).ToList();
            KoloWsObject<List<KoloNotification>> koloWs = new KoloWsObject<List<KoloNotification>>(error, cBHs);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }


        [WebMethod]
        public string GetExternalAccountsHistoriesGlobal(int jsonIdCustomer)
        {
            string error = "";
            List<ExternalAccountHistory> externalAccountHistories = ExternalAccountHelper.GetExternalAccountsHistoriesGlobal(jsonIdCustomer, out error);
            KoloWsObject<List<ExternalAccountHistory>> koloWs = new KoloWsObject<List<ExternalAccountHistory>>( error, externalAccountHistories);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }


        [WebMethod]
        public string GetExternalAccountsHistoriesSpecific(string jsonExternalAccount)
        {
            string error = "";
            ExternalAccount externalAccount = SerializationHelper.DeserializeFromJsonString<ExternalAccount>(jsonExternalAccount);
            List<ExternalAccountHistory> externalAccountHistories = ExternalAccountHelper.GetExternalAccountsHistoriesSpecific(externalAccount, out error);
            KoloWsObject<List<ExternalAccountHistory>> koloWs = new KoloWsObject<List<ExternalAccountHistory>>(error, externalAccountHistories);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }


        #endregion

    }
}