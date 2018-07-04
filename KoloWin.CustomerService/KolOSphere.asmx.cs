using KoloWin.CustomerService.Util;
using KoloWin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Utils.General;

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
        public string DoTransfertA2A(string jsonTransfertP2p)
        {
            string error = "";
            var tP2P = SerializationHelper.DeserializeFromJsonString<TransfertP2p>(jsonTransfertP2p);
            var Context = new KoloAndroidEntities4Serialization();
            if (tP2P.TransfertStatusCode.Equals(KoloConstants.Operation.Status.CONFIRM_PENDING.ToString()))
                tP2P = TransfertP2PHelper.AcceptTransfertA2A(tP2P, Context, out error);
            else if (tP2P.TransfertStatusCode.Equals(KoloConstants.Operation.Status.COMPLETED.ToString()))
                tP2P = TransfertP2PHelper.AcceptTransfertA2A(tP2P, Context, out error);
            else
                tP2P = TransfertP2PHelper.SendTransfertA2A(tP2P, Context, out error);
            Context.Dispose();
            tP2P.Secret = "HIDDEN BY CYBERIX";
            return SerializationHelper.SerializeToJson(tP2P);
        }

        [WebMethod]
        public string DoTransfertA2C(string jsonTransfert2c)
        {
            var Context = new KoloAndroidEntities();
            Context.Dispose();
            return null;
        }

        [WebMethod]
        public string DoTransfertC2A(string jsonTransfert2c)
        {
            var Context = new KoloAndroidEntities();
            Context.Dispose();
            return null;
        }

        [WebMethod]
        public string DoTransfertC2C(string jsonTransfert2c)
        {
            var Context = new KoloAndroidEntities();
            Context.Dispose();
            return null;
        }

        #endregion


        #region Transfert Method For Good WOrkFlow


        [WebMethod]
        public string GetTransfertP2pByIdTransfert(int idTransfertP2p)
        {
            var Context = new KoloAndroidEntities();
            var outTransfertP2p = Context.TransfertP2p.Find(idTransfertP2p);
            Context.Dispose();
            return SerializationHelper.SerializeToJson(outTransfertP2p);
        }

        [WebMethod]
        public string GetTransfert2CashByIdTransfert(int idTransfert2Cash)
        {
            var Context = new KoloAndroidEntities();
            var outTransfert2Cash = Context.Transfert2Cash.Find(idTransfert2Cash);
            Context.Dispose();
            return SerializationHelper.SerializeToJson(outTransfert2Cash);
        }


        [WebMethod]
        public string GetTransfert2CashDetailsByIdTransfert2CashDetails(int idTransfert2CashDetails)
        {
            var Context = new KoloAndroidEntities();
            var outTransfert2CashDetails = Context.Transfert2CashDetails.Find(idTransfert2CashDetails);
            Context.Dispose();
            return SerializationHelper.SerializeToJson(outTransfert2CashDetails);
        }

        [WebMethod]
        public string GetTransfertP2pList(int idCustomer)
        {
            var Context = new KoloAndroidEntities();
            var outTransfertP2pList = Context.TransfertP2p
                .Include("Receiver.Person").Include("Receiver.MobileDevice")
                .Include("Sender.Person").Include("Receiver.MobileDevice")
                .Where(e => e.IdReceiverCustomer == idCustomer || e.IdSendingCustomer == idCustomer).ToList();
            var transfersDetails = outTransfertP2pList.Select(t =>  new P2pTransferDetails(t)).ToList();
            Context.Dispose();
            return SerializationHelper.SerializeToJson(transfersDetails);
        }

        [WebMethod]
        public string GetTransfert2CashList(int idTransfert2CashDetails)
        {
            var Context = new KoloAndroidEntities();
            var outTransfert2CashList = Context.Transfert2Cash.Where(e => e.IdReceiverTransfert2CashDetails == idTransfert2CashDetails || e.IdSendingTransfert2CashDetails == idTransfert2CashDetails).ToList();
            Context.Dispose();
            return SerializationHelper.SerializeToJson(outTransfert2CashList);
        }

        #endregion

    }
}
