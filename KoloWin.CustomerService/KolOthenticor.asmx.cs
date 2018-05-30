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
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KolOthenticor : System.Web.Services.WebService
    {

        #region Method For Test

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.RefGender GetRefGender()
        {
            Poco.KoloEntities Context = new Poco.KoloEntities();
            Poco.RefGender refGender = new Poco.RefGender()
            {
                GenderCode = "M",
                GenderDescription = "Male",
            };
            return refGender;
        }

        [WebMethod]
        public void CreatePerson(string jsonPerson)
        {
            Poco.Person person = SerializationHelper.DeserializeFromJsonString<Poco.Person>(jsonPerson);
            Poco.KoloEntities Context = new Poco.KoloEntities();
            Context.People.Add(person);
            Context.Dispose();
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public List<Poco.Person> GetPeople()
        {
            KoloEntities4Serialization Context = new KoloEntities4Serialization();
            Context.Configuration.ProxyCreationEnabled = false;
            var people = Context.People.ToList();
            return people;
        }


        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.Person GetPerson()
        {
            KoloEntities4Serialization Context = new KoloEntities4Serialization();
            Poco.Person person = Context.People.FirstOrDefault();
            return person;
        }


        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.Customer GetCustomer()
        {
            KoloEntities4Serialization Context = new KoloEntities4Serialization();
            Context.Configuration.ProxyCreationEnabled = false;
            Poco.Customer customer = Context.Customers.FirstOrDefault();
            return customer;
        }


        #endregion



        #region Method For Registration

        [WebMethod]
        public Poco.Registration DoRegistration(string jsonReg)
        {
            Poco.Registration inReg = SerializationHelper.DeserializeFromJsonString<Poco.Registration>(jsonReg);
            Poco.KoloEntities context = new Poco.KoloEntities();
            Poco.Registration outReg = RegistrationHelper.DoRegistration(inReg, context);
            return outReg;
        }



        [WebMethod]
        public Poco.Customer DoConfirmRegistration(string jsonReg)
        {
            Poco.Registration registration = SerializationHelper.DeserializeFromJsonString<Poco.Registration>(jsonReg);
            KoloEntities4Serialization context = new KoloEntities4Serialization();
            Poco.Customer customer = RegistrationHelper.DoRegistrationConfirmation(registration, context);
            return customer;
        }


        [WebMethod]
        public Poco.LoginAttempt DoLogin(string jsonLogAttempt)
        {
            Poco.LoginAttempt logAttempt = SerializationHelper.DeserializeFromJsonString<Poco.LoginAttempt>(jsonLogAttempt);
            Poco.KoloEntities context = new Poco.KoloEntities();
            KoloEntities4Serialization context4Serialization = new KoloEntities4Serialization();
            logAttempt = context4Serialization.LoginAttempts.Find(LoginHelper.DoLogin(logAttempt, context));

            return logAttempt;
        }



        #endregion

    }
}
