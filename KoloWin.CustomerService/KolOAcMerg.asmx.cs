using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Util.Entities;
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
