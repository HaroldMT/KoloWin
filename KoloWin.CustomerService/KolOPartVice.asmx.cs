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
            Customer c = Context.Customers.Find(Int32.Parse(jsonCustomer));
            c.Person = Context.People.Find(c.IdCustomer);
            c.MobileDevice = Context.MobileDevices.FirstOrDefault(m => m.IdMobileDevice == c.IdCustomer);
            ExWebSrv4Kolo.WebService4KoloSoapClient exWS4Kolo = new ExWebSrv4Kolo.WebService4KoloSoapClient();
            var reference = exWS4Kolo.PayENEO(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER, 
                                                 jsonBillNumber, c.Person.Firstname + " " + c.Person.Lastname, c.MobileDevice.LineNumber);
            Context.Dispose();
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
