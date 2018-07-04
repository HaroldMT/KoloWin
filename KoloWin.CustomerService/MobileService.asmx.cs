using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Util;
using KoloWin.CustomerService.Util.Entities;
using KoloWin.Utilities;
using KoloWin.CustomerService.Utils.General;

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
            { GenderCode = "M",
                GenderDescription = "Male", };


            return refGender;
        }

        [WebMethod]
        public void CreatePerson(string jsonPerson)
        {
            var person = SerializationHelper.DeserializeFromJsonString<Person>(jsonPerson);
            var Context = new KoloAndroidEntities();
            Context.People.Add(person);
            Context.Dispose();
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public MyRefTypes TestService(MyRefTypes myRefTypes)
        {
            return myRefTypes;
        }


        #endregion

        #region Generals Methods

        [WebMethod]
        public MobileDevice InsertMobileDevice(string jsonMobileDevice)
        {
            string error = "";
            MobileDevice mobileDevice = SerializationHelper.DeserializeFromJsonString<MobileDevice>(jsonMobileDevice) as MobileDevice;
            var context = new KoloAndroidEntities4Serialization();
            mobileDevice = MobileDeviceHelper.InsertMobileDevice(ref mobileDevice, context, out  error);
            context.Dispose();
            return mobileDevice;
        }

        [WebMethod]
        public string GetCustomerByIdCustomerAndNumber(int idCustomer, string number)
        {
            var Context = new KoloAndroidEntities();
            SimpleContact simpleContact = new SimpleContact()
            {
                FirstName = "name...", LastName = "Full",
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
            Context.Dispose();
            return SerializationHelper.SerializeToJson(simpleContact);
        }

        [WebMethod]
        public string GetCustomerContacts(string contacts, string idCustomer)
        {
            var Context = new KoloAndroidEntities();
            Customer outCustomer;
            
            Context.Dispose();
            return SerializationHelper.SerializeToJson("");
        }

        #endregion

        #region Kolo MAD Methods

        [WebMethod]
        public string FindCustomerMad(string jsonMadCustomer)
        {
            string error = "";
            KoloMadCustomer madCustomer = SerializationHelper.DeserializeFromJsonString<KoloMadCustomer>(jsonMadCustomer);
            Madhelper.FindCustomerMad(ref madCustomer, out error);
            return SerializationHelper.SerializeToJson<KoloMadCustomer>(madCustomer);
        }

        [WebMethod]
        public string FindManagerCustomerByPhone(string phone)
        {
            string error = "";
            var managerCustomer = Madhelper.FindManagerCustomerByPhone(phone, out error);
            return managerCustomer;
        }

        [WebMethod]
        public string FindManagerCustomerByCustomerCode(string customerCode)
        {
            string error = "";
            var managerCustomer = Madhelper.FindManagerCustomerByCustomerCode(customerCode, out error);
            return managerCustomer;
        }

        
        [WebMethod]
        public string GetMADFees(int montant)
        {
            string error = "";
            var idMad = Madhelper.GetMADFees(montant, out error);
            return SerializationHelper.SerializeToJson<int>(idMad);
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
            return SerializationHelper.SerializeToJson<List<EneoBillDetails>>(eBDs);
        }


        [WebMethod]
        public string GetCustomerBalanceHistory(int jsonIdCustomer)
        {
            string error = "";
            List<CustomerBalanceHistory> cBHs = null;
            var context = new KoloAndroidEntities();
            cBHs = context.CustomerBalanceHistories.Where(c => c.IdCustomerAccount == jsonIdCustomer).ToList();
            return SerializationHelper.SerializeToJson<List<CustomerBalanceHistory>>(cBHs);
        }


        //[WebMethod]
        //public string GetKoloMadDetailsHistory(int jsonIdCustomer)
        //{
        //    string error = "";
        //    List<KoloMadDetails> kMDs = null;
        //    var context = new KoloAndroidEntities4Serialization();
        //    Customer customer = context.Customers.FirstOrDefault(c => c.IdCustomer == jsonIdCustomer);
        //    //kMDs = context.EneoBillPayments.Where(e => e.IdCustomer == jsonIdCustomer).ToList();
        //    List<EneoBillDetails> eBDs = null;
        //    //if (kMDs != null)
        //        //eBDs = kMDs.Select(e => new EneoBillDetails(e)).ToList();
        //    return SerializationHelper.SerializeToJson<List<EneoBillDetails>>(null);
        //}

        #endregion

    }
}
