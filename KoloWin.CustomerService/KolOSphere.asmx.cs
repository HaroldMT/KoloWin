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
            var Context = new KoloAndroidEntities();
            tP2P = TransfertP2PHelper.SendTransfertA2A(tP2P, Context, out error);
            if (string.IsNullOrEmpty(tP2P.Secret))
                tP2P.Secret = "HIDDEN BY CYBERIX";
            KoloWsObject<TransfertP2p> koloWs = new KoloWsObject<TransfertP2p>(error,tP2P);
            var result = SerializationHelper.SerializeToJson(koloWs);
            Context.Dispose();
            return result;
        }

        [WebMethod]
        public string DoAcceptTransfertA2A(string jsonTransfertP2p)
        {
            string error = "";
            var tP2P = SerializationHelper.DeserializeFromJsonString<TransfertP2p>(jsonTransfertP2p);
            var Context = new KoloAndroidEntities();
            //  Conversion et recherche  Pour la future methode utilisant P2pTransferDetails
            //var p2pTransfertDetails = SerializationHelper.DeserializeFromJsonString<P2pTransferDetails>(jsonTransfertP2p);
            //var p2P = Context.TransfertP2p.FirstOrDefault(t => t.IdReceiverCustomer == p2pTransfertDetails.ReceiverIdCustomer && t.IdSendingCustomer == p2pTransfertDetails.ReceiverIdCustomer && t.Reference == p2pTransfertDetails.Reference);
            if (tP2P.NeedsConfirmation) tP2P = TransfertP2PHelper.AskConfirmationOfTransfertA2A(tP2P, Context, out error);
            if (!tP2P.NeedsConfirmation) tP2P = TransfertP2PHelper.ConfirmTransfertA2A(tP2P, Context, out error);
            if (string.IsNullOrEmpty(tP2P.Secret))
                tP2P.Secret = "HIDDEN BY CYBERIX";
            KoloWsObject<TransfertP2p> koloWs = new KoloWsObject<TransfertP2p>(error, tP2P);
            var result = SerializationHelper.SerializeToJson(koloWs);
            Context.Dispose();
            return result;
        }
        
        [WebMethod]
        public string DoConfirmTransfertA2A(string jsonTransfertP2p)
        {
            string error = "";
            var tP2P = SerializationHelper.DeserializeFromJsonString<TransfertP2p>(jsonTransfertP2p);
            var Context = new KoloAndroidEntities();
            //  Conversion et recherche  Pour la future methode utilisant P2pTransferDetails
            //var p2pTransfertDetails = SerializationHelper.DeserializeFromJsonString<P2pTransferDetails>(jsonTransfertP2p);
            //var p2P = Context.TransfertP2p.FirstOrDefault(t => t.IdReceiverCustomer == p2pTransfertDetails.ReceiverIdCustomer && t.IdSendingCustomer == p2pTransfertDetails.ReceiverIdCustomer && t.Reference == p2pTransfertDetails.Reference);
            if (!tP2P.NeedsConfirmation) tP2P = TransfertP2PHelper.ConfirmTransfertA2A(tP2P, Context, out error);
            if (string.IsNullOrEmpty(tP2P.Secret))
                tP2P.Secret = "HIDDEN BY CYBERIX";
            KoloWsObject<TransfertP2p> koloWs = new KoloWsObject<TransfertP2p>(error, tP2P);
            var result = SerializationHelper.SerializeToJson(koloWs);
            Context.Dispose();
            return result;
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

        [WebMethod]
        public string SendBill(string jsonBill)
        {
            return "";
        }

        [WebMethod]
        public string CancelBill(string jsonBill)
        { 
            return "";
        }

        [WebMethod]
        public string PayBill(string jsonBill)
        {
            return "";
        }

        [WebMethod]
        public string RejectBill(string jsonBill)
        {
            return "";
        }
        #endregion

        #region Transfert Method For Good WOrkFlow
        [WebMethod]
        public string GetTransfertP2pByIdTransfert(int idTransfertP2p)
        {
            var Context = new KoloAndroidEntities();
            var outTransfertP2p = Context.TransfertP2p.FirstOrDefault(t => t.IdTransfertP2p == idTransfertP2p);
            var result = SerializationHelper.SerializeToJson(outTransfertP2p);
            Context.Dispose();
            return result;
        }

        [WebMethod]
        public string GetTransfert2CashByIdTransfert(int idTransfert2Cash)
        {
            var Context = new KoloAndroidEntities();
            var outTransfert2Cash = Context.Transfert2Cash.FirstOrDefault(t => t.IdTransfert2Cash == idTransfert2Cash);
            var result = SerializationHelper.SerializeToJson(outTransfert2Cash);
            Context.Dispose();
            return result;
            
        }


        [WebMethod]
        public string GetTransfert2CashDetailsByIdTransfert2CashDetails(int idTransfert2CashDetails)
        {
            var Context = new KoloAndroidEntities();
            var outTransfert2CashDetails = Context.Transfert2CashDetails.FirstOrDefault(t => t.IdTransfert2CashDetails == idTransfert2CashDetails);
            var result = SerializationHelper.SerializeToJson(outTransfert2CashDetails);
            Context.Dispose();
            return result;
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
            var result = SerializationHelper.SerializeToJson(transfersDetails);
            Context.Dispose();
            return result;
        }

        [WebMethod]
        public string GetTransfert2CashList(int idTransfert2CashDetails)
        {
            var Context = new KoloAndroidEntities();
            var outTransfert2CashList = Context.Transfert2Cash.Where(e => e.IdReceiverTransfert2CashDetails == idTransfert2CashDetails || e.IdSendingTransfert2CashDetails == idTransfert2CashDetails).ToList();
            var result = SerializationHelper.SerializeToJson(outTransfert2CashList);
            Context.Dispose();
            return result;
        }

        #endregion

    }
}