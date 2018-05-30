using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using KoloWin.Poco;
using KoloWin.Utilities;

namespace KoloWin.CustomerService
{
    /// <summary>
    /// Summary description for MobileService
    /// </summary>
    [WebService(Namespace = "http://kolo.cyberix.fr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MobileService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.RefGender GetRefGender()
        {
            KoloEntities Context = new KoloEntities();
            Poco.RefGender refGender = new RefGender()
            {
                GenderCode = "M",
                GenderDescription = "Male",
            };
            //string jsonPerson = SerializationHelper.SerializeToJson(person);
            //Context.Dispose();
            return refGender;
        }

        [WebMethod]
        public void CreatePerson(string jsonPerson)
        {
            Poco.Person person = SerializationHelper.DeserializeFromJsonString<Poco.Person>(jsonPerson);
            KoloEntities Context = new KoloEntities();
            Context.People.Add(person);
            Context.Dispose();
        }
    }
}
