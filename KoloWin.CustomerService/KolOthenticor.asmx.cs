using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using KoloWin.CustomerService.Util;
using KoloWin.Utilities;

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
        public Poco.Registration DoRegistration(string jsonReg)
        {
            string error = "";
            var inReg = SerializationHelper.DeserializeFromJsonString<Poco.Registration>(jsonReg);
            var context = new Poco.KoloEntities();
            var outReg = RegistrationHelper.DoRegistration(inReg, context,out error);
            return outReg;
        }



        [WebMethod]
        public Poco.Customer DoConfirmRegistration(string jsonReg)
        {
            string error = "";
            var registration = SerializationHelper.DeserializeFromJsonString<Poco.Registration>(jsonReg);
            var context = new KoloEntities4Serialization();
            var customer = RegistrationHelper.DoRegistrationConfirmation(registration, context,out error);
            return customer;
        }


        [WebMethod]
        public Poco.LoginAttempt DoLogin(string jsonLogAttempt)
        {
            string error = "";
            var logAttempt = SerializationHelper.DeserializeFromJsonString<Poco.LoginAttempt>(jsonLogAttempt);
            var context = new Poco.KoloEntities();
            var context4Serialization = new KoloEntities4Serialization();
            logAttempt = context4Serialization.LoginAttempts.Find(LoginHelper.DoLogin(logAttempt, context,out error));
            return logAttempt;
        }
    }
}
