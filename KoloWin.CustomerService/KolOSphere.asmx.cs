using KoloWin.CustomerService.Util;
using KoloWin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
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


    public class KolOSphere : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.TransfertP2p DoTransfertA2A(string jsonTransfertP2p)
        {
            var tP2P = SerializationHelper.DeserializeFromJsonString<Poco.TransfertP2p>(jsonTransfertP2p);
            var Context = new KoloEntities4Serialization();
            tP2P = TransfertP2PHelper.SendTransfertA2A(tP2P, Context);
            Context.Dispose();
            return tP2P;
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.Transfert2Cash DoTransfertA2C(string jsonTransfert2c)
        {
            var Context = new Poco.KoloEntities();
            Context.Dispose();
            return null;
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.Transfert2Cash DoTransfertC2A(string jsonTransfert2c)
        {
            var Context = new Poco.KoloEntities();
            Context.Dispose();
            return null;
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Poco.Transfert2Cash DoTransfertC2C(string jsonTransfert2c)
        {
            var Context = new Poco.KoloEntities();
            Context.Dispose();
            return null;
        }
    }
}
