using System;
using System.Collections.Generic;
using System.Linq;
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


    public class MobileService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.RefGender GetRefGender()
        {
            var refGender = new RefGender()
            { GenderCode = "M",
                GenderDescription = "Male", };


            return refGender;
        }

        [WebMethod]
        public void CreatePerson(string jsonPerson)
        {
            var person = SerializationHelper.DeserializeFromJsonString<Poco.Person>(jsonPerson);
            var Context = new KoloEntities();
            Context.People.Add(person);
            Context.Dispose();
        }

        [WebMethod]
        public bool TestService(MyRefTypes myRefTypes)
        {
            return true;
        }
    }
}
