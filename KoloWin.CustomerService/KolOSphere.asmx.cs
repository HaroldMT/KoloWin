using KoloWin.CustomerService.Util;
using KoloWin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace KoloWin.CustomerService
{
    /// <summary>
    /// Summary description for KolOSphere
    /// </summary>
    [WebService(Namespace = "http://kolo.cyberix.fr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KolOSphere : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.TransfertP2p DoTransfertA2A(string jsonTransfertP2p)
        {
            Poco.TransfertP2p tP2P = SerializationHelper.DeserializeFromJsonString<Poco.TransfertP2p>(jsonTransfertP2p);
            KoloEntities4Serialization Context = new KoloEntities4Serialization();
            tP2P = TransfertP2PHelper.SendTransfertA2A(tP2P, Context);
            Context.Dispose();
            return tP2P;
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string DoTransfertA2C()
        {
            Poco.KoloEntities Context = new Poco.KoloEntities();
            Context.Dispose();
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string DoTransfertC2A()
        {
            Poco.KoloEntities Context = new Poco.KoloEntities();
            Context.Dispose();
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string DoTransfertC2C()
        {
            Poco.KoloEntities Context = new Poco.KoloEntities();
            Context.Dispose();
            return "Hello World";
        }


    }
}
