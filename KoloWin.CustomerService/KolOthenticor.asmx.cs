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
            var inReg = SerializationHelper.DeserializeFromJsonString<Poco.Registration>(jsonReg);
            var context = new Poco.KoloEntities();
            var outReg = RegistrationHelper.DoRegistration(inReg, context);
            return outReg;
        }



        [WebMethod]
        public Poco.Customer DoConfirmRegistration(string jsonReg)
        {
            var registration = SerializationHelper.DeserializeFromJsonString<Poco.Registration>(jsonReg);
            var context = new KoloEntities4Serialization();
            var customer = RegistrationHelper.DoRegistrationConfirmation(registration, context);
            return customer;
        }


        [WebMethod]
        public Poco.LoginAttempt DoLogin(string jsonLogAttempt)
        {
            var logAttempt = SerializationHelper.DeserializeFromJsonString<Poco.LoginAttempt>(jsonLogAttempt);
            var context = new Poco.KoloEntities();
            var context4Serialization = new KoloEntities4Serialization();
            logAttempt = context4Serialization.LoginAttempts.Find(LoginHelper.DoLogin(logAttempt, context));

            return logAttempt;
        }
    }
}
