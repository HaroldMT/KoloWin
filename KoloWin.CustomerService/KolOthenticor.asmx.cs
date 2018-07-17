using System;
using System.Web.Services;
using KoloWin.CustomerService.Util;
using KoloWin.Utilities;
using KoloWin.CustomerService.Model;

namespace KoloWin.CustomerService
{
    /// <summary>
    /// Summary description for KolOthenticor
    /// </summary>
    [WebService(Namespace = "http://kolo.cyberix.fr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class KolOthenticor : System.Web.Services.WebService
    {
        [WebMethod]
        public string DoConfirmRegistration(string jsonReg)
        {
            string error = "";
            var registration = SerializationHelper.DeserializeFromJsonString<Registration>(jsonReg);
            var context = new KoloAndroidEntities4Serialization();
            var customer = RegistrationHelper.DoRegistrationConfirmation(registration, context, out error);
            KoloWsObject<Customer> koloWs = new KoloWsObject<Customer>(error, customer);
            context.Dispose();
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }

        [WebMethod]
        public string DoLogin(string jsonLogAttempt)
        {
            string error = "";
            var logAttempt = SerializationHelper.DeserializeFromJsonString<LoginAttempt>(jsonLogAttempt);
            var context = new KoloAndroidEntities4Serialization();
            LoginHelper.DoLogin(ref logAttempt, context, out error);
            KoloWsObject<LoginAttempt> koloWs = new KoloWsObject<LoginAttempt>(error, logAttempt);
            context.Dispose();
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }

        [WebMethod]
        public string DoRegistration(string jsonReg)
        {
            string error = "";
            var inReg = SerializationHelper.DeserializeFromJsonString<Registration>(jsonReg);
            var context = new KoloAndroidEntities4Serialization();
            var outReg = RegistrationHelper.DoRegistration(inReg, context, out error);
            KoloWsObject<Registration> koloWs = new KoloWsObject<Registration>(error, outReg);
            context.Dispose();
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }
        
        //[WebMethod]
        //public LoginAttempt SignIn(LoginAttempt loginAttempt)
        //{
        //    string error = "";
        //    var context = new KoloAndroidEntities4Serialization();
        //    LoginHelper.DoLogin(ref loginAttempt, context, out error);
        //    context.Dispose();
        //    return loginAttempt;
        //}

        //[WebMethod]
        //public Registration SignUp(Registration registration)
        //{
        //    string error = "";
        //    var context = new KoloAndroidEntities4Serialization();
        //    var outReg = RegistrationHelper.DoRegistration(registration, context, out error);
        //    context.Dispose();
        //    return outReg;
        //}

        //[WebMethod]
        //public Customer SignUpVerification(Registration registration)
        //{
        //    string error = "";
        //    var context = new KoloAndroidEntities4Serialization();
        //    var customer = RegistrationHelper.DoRegistrationConfirmation(registration, context, out error);
        //    context.Dispose();
        //    return customer;
        //}
    }
}