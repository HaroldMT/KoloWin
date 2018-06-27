using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Util;
using KoloWin.CustomerService.Utils.General;
using KoloWin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace KoloWin.CustomerService
{
    /// <summary>
    /// Summary description for KolOPartVice
    /// </summary>
    [WebService(Namespace = "http://kolo.cyberix.fr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KolOPartVice : System.Web.Services.WebService
    {

        #region Kolo Eneo Methods

        [WebMethod]
        public string DoPayEneoBill(string jsonBillNumber, string jsonCustomer)
        {
            string error = "";
            var reference = EneoHelper.DoPayENEO(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER,jsonBillNumber, jsonCustomer,out error);
            return reference;
        }
        
        [WebMethod]
        public string GetEneoBillByBillNumber(string jsonBillNumber)
        {
            string error = "";
            List<EneoBillDetails> eBDs = EneoHelper.GetEneoBillByBillNumber(jsonBillNumber,out error);
            return SerializationHelper.SerializeToJson<List<EneoBillDetails>>(eBDs);
        }
        
        [WebMethod]
        public string GetEneoBillsByBillAccount(string jsonBillAccount)
        {
            string error = "";
            List<EneoBillDetails> eBDs = EneoHelper.GetEneoBillsByBillAccount(jsonBillAccount, out error);
            return SerializationHelper.SerializeToJson<List<EneoBillDetails>>(eBDs);
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
        public string DoSendMad(string jsonKoloMadDetails)
        {
            string error = "";
            KoloMadDetails koloMadDetails = SerializationHelper.DeserializeFromJsonString<KoloMadDetails>(jsonKoloMadDetails);
            Madhelper.DoSendMad(ref koloMadDetails, out error);
            return SerializationHelper.SerializeToJson<KoloMadDetails>(koloMadDetails);
        }

        [WebMethod]
        public string GetMADFees(int montant)
        {
            string error = "";
            var idMad = Madhelper.GetMADFees(montant, out  error);
            return SerializationHelper.SerializeToJson<int>(idMad);
        }



        #endregion
        
        #region TopUp Methods


        [WebMethod]
        public string DoTopUp(string jsonTopUp)
        {
            string error = "";
            return "";
        }


        #endregion

    }
}
