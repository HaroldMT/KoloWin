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
            var Context = new KoloAndroidEntities4Serialization();
            Customer ctmp = SerializationHelper.DeserializeFromJsonString<Customer>(jsonCustomer);
            Customer c = Context.Customers.Find(ctmp.IdCustomer);
            ExWebSrv4Kolo.WebService4KoloSoapClient exWS4Kolo = new ExWebSrv4Kolo.WebService4KoloSoapClient();
            string reference = exWS4Kolo.PayENEO(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER, 
                                                 jsonBillNumber, c.Person.Firstname + " " + c.Person.Lastname, c.MobileDevice.LineNumber);
            Context.Dispose();
            return "";
        }

        
        [WebMethod]
        public string GetEneoBillByBillNumber(string jsonBillNumber)
        {
            string error = "";
            ExWebSrv4Kolo.WebService4KoloSoapClient exWS4Kolo = new ExWebSrv4Kolo.WebService4KoloSoapClient();
            ExWebSrv4Kolo.UnpaidBill tmp = exWS4Kolo.FindEneoByBillNumber(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER, jsonBillNumber);
            List<EneoBillDetails> eBDs = new List<EneoBillDetails>();
            eBDs.Add(new EneoBillDetails(tmp));
            return SerializationHelper.SerializeToJson<List<EneoBillDetails>>(eBDs);
        }


        [WebMethod]
        public string GetEneoBillsByBillAccount(string jsonBillAccount)
        {
            string error = "";
            ExWebSrv4Kolo.WebService4KoloSoapClient exWS4Kolo = new ExWebSrv4Kolo.WebService4KoloSoapClient();
            ExWebSrv4Kolo.UnpaidBill[] tmp = exWS4Kolo.FindEneoByBillAccount(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER, jsonBillAccount);
            List<EneoBillDetails> eBDs = tmp.Select(e => new EneoBillDetails(e)).ToList();
            return SerializationHelper.SerializeToJson<List<EneoBillDetails>>(eBDs);
        }

        #endregion


        #region Kolo MAD Methods

        [WebMethod]
        public string DoSendMad( string jsonMad)
        {
            string error = "";
            return "";
        }


        [WebMethod]
        public string DoRecieveMad(string jsonMad)
        {
            string error = "";
            return "";
        }


        [WebMethod]
        public string GetMadByReference(string jsonReference)
        {
            string error = "";
            return "";
        }


        [WebMethod]
        public string GetMadByBordereau(string jsonBordereau)
        {
            string error = "";
            return "";
        }


        [WebMethod]
        public string GetMadByCustomer(string jsonCustomer)
        {
            string error = "";
            return "";
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
