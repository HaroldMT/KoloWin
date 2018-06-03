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


        #region Transfert Basic Methods

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public TransfertP2p DoTransfertA2A(string jsonTransfertP2p)
        {
            string error = "";
            var tP2P = SerializationHelper.DeserializeFromJsonString<TransfertP2p>(jsonTransfertP2p);
            var Context = new KoloAndroidEntities4Serialization();
            tP2P = TransfertP2PHelper.SendTransfertA2A(tP2P, Context, out error);
            Context.Dispose();
            return tP2P;
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Transfert2Cash DoTransfertA2C(string jsonTransfert2c)
        {
            var Context = new KoloAndroidEntities();
            Context.Dispose();
            return null;
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Transfert2Cash DoTransfertC2A(string jsonTransfert2c)
        {
            var Context = new KoloAndroidEntities();
            Context.Dispose();
            return null;
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Transfert2Cash DoTransfertC2C(string jsonTransfert2c)
        {
            var Context = new KoloAndroidEntities();
            Context.Dispose();
            return null;
        }

        #endregion


        #region Transfert Method For Good WOrkFlow


        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public TransfertP2p GetTransfertP2p(int idCustomer)
        {
            var Context = new KoloAndroidEntities();
            Context.Dispose();
            return null;
        }

        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Transfert2Cash GetTransfert2Cash(int idCustomer)
        {
            var Context = new KoloAndroidEntities();
            Context.Dispose();
            return null;
        }


        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public Transfert2CashDetails GetTransfert2CashDetails(int idTransfert2CashDetails)
        {
            var Context = new KoloAndroidEntities();
            Context.Dispose();
            return null;
        }


        #endregion

    }
}
