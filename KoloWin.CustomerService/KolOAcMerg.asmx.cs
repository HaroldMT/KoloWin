using KoloWin.CustomerService.Model;
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
        public string UpdateCustomerAccount(string jsonIdCustomer)
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
        public string ConvertToBusinessAccount(string jsonIdCustomer)
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
        public string UpdateBusinessAccount(string jsonIdCustomer)
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
        public string AddMobileDevice(string jsonIdCustomer)
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
        public string RevokeMobileDevice(string jsonIdCustomer)
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
