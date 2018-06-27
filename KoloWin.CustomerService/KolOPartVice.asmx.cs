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
        public string FindCustomerMad(int amount, string phone, string customerCode, string reference)
        {
            string error = "";
            var mad = Madhelper.FindCustomerMad(amount, phone, customerCode, reference, out error);
            return mad;
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
        public int DoSendMad(int idSender, int idReciever, int amount)
        {
            string error = "";
            var idMad = Madhelper.DoSendMad(idSender, idReciever, amount, out error);
            return idMad;
        }

        [WebMethod]
        public int GetMADFees(int montant)
        {
            string error = "";
            var idMad = Madhelper.GetMADFees( montant, out  error);
            return idMad;
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
