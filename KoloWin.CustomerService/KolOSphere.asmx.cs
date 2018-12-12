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
        public string DoAcceptTransfertA2A(string jsonP2pTransfertDetails)
        {
            string error = "";
            var Context = new KoloAndroidEntities();
            var p2pTransfertDetails = SerializationHelper.DeserializeFromJsonString<P2pTransferDetails>(jsonP2pTransfertDetails);
            var p2P = Context.TransfertP2p.FirstOrDefault(t => t.IdReceiverCustomer == p2pTransfertDetails.ReceiverIdCustomer && t.IdSendingCustomer == p2pTransfertDetails.ReceiverIdCustomer && t.Reference == p2pTransfertDetails.Reference);
            if (p2P.NeedsConfirmation) p2P = TransfertP2PHelper.AskConfirmationOfTransfertA2A(p2P, Context, out error);
            if (!p2P.NeedsConfirmation) p2P = TransfertP2PHelper.ConfirmTransfertA2A(p2P, Context, out error);
            if (string.IsNullOrEmpty(p2P.Secret))
                p2P.Secret = "HIDDEN BY CYBERIX";
            p2pTransfertDetails = new P2pTransferDetails(p2P);
            KoloWsObject<P2pTransferDetails> koloWs = new KoloWsObject<P2pTransferDetails>(error, p2pTransfertDetails);
            var result = SerializationHelper.SerializeToJson(koloWs);
            Context.Dispose();
            return result;
        }
        
        [WebMethod]
        public string DoConfirmTransfertA2A(string jsonP2pTransfertDetails)
        {
            string error = "";
            var Context = new KoloAndroidEntities();
            var p2pTransfertDetails = SerializationHelper.DeserializeFromJsonString<P2pTransferDetails>(jsonP2pTransfertDetails);
            var p2P = Context.TransfertP2p.FirstOrDefault(t => t.IdReceiverCustomer == p2pTransfertDetails.ReceiverIdCustomer && t.IdSendingCustomer == p2pTransfertDetails.ReceiverIdCustomer && t.Reference == p2pTransfertDetails.Reference);
            if (!p2P.NeedsConfirmation) p2P = TransfertP2PHelper.ConfirmTransfertA2A(p2P, Context, out error);
            if (string.IsNullOrEmpty(p2P.Secret))
                p2P.Secret = "HIDDEN BY CYBERIX";
            p2pTransfertDetails = new P2pTransferDetails(p2P);
            KoloWsObject<P2pTransferDetails> koloWs = new KoloWsObject<P2pTransferDetails>(error, p2pTransfertDetails);
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


        #endregion


        #region Bill Methods  (Without Any Control => Balance notifications , .....)


        [WebMethod]
        public string SendBill(string jsonBillDetails)
        {
            BillDetails billDetails = SerializationHelper.DeserializeFromJsonString<BillDetails>(jsonBillDetails);
            KoloAndroidEntities context = new KoloAndroidEntities();
            Tuple<Bill, BillDetail> tuple = billDetails.GetBillAndDetails();
            Bill bill = tuple.Item1;
            BillDetail billDetail = tuple.Item2;
            bill.BillDetails.Add(billDetail);
            context.Bills.Add(bill);
            context.SaveChanges();
            KoloWsObject<Bill> koloWs = new KoloWsObject<Bill>("", bill);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }

        [WebMethod]
        public string CancelBill(int jsonIdBill)
        {
            KoloAndroidEntities context = new KoloAndroidEntities();
            Bill bill = context.Bills.FirstOrDefault(b => b.IdBill == jsonIdBill);
            bill.CodeRefBillStatus = KoloConstants.Operation.BillStatus.CANCELED.ToString();
            context.SaveChanges();
            KoloWsObject<Bill> koloWs = new KoloWsObject<Bill>(true,"",null);
            var result = SerializationHelper.SerializeToJson(koloWs);
            context.Dispose();
            return result;
        }

        [WebMethod]
        public string PayBill(string jsonBillPayement)
        {
            BillPayment billPayment = SerializationHelper.DeserializeFromJsonString<BillPayment>(jsonBillPayement);
            KoloAndroidEntities context = new KoloAndroidEntities();
            Bill bill = context.Bills.FirstOrDefault(b => b.IdBill == billPayment.IdBill);
            if(bill == null)
            {
                KoloWsObject<Bill> koloWs = new KoloWsObject<Bill>(false, "Bill Not Found", null);
                var result = SerializationHelper.SerializeToJson(koloWs);
                context.Dispose();
                return result;
            }
            if(!bill.AllowPartialPayment && bill.TotalBillAmount > billPayment.PaidAmount)
            {
                KoloWsObject<Bill> koloWs = new KoloWsObject<Bill>(false, "This bill don't allow partial paiment please send all money", null);
                var result = SerializationHelper.SerializeToJson(koloWs);
                context.Dispose();
                return result;
            }
            else if(!bill.AllowPartialPayment && bill.TotalBillAmount == billPayment.PaidAmount)
            {
                billPayment.DatePaid = DateTime.Now;
                billPayment.LastPayment = true;

                bill.CodeRefBillStatus = KoloConstants.Operation.BillStatus.PAID.ToString();
                bill.LeftToPay -= billPayment.PaidAmount;

                KoloWsObject<Bill> koloWs = new KoloWsObject<Bill>(true, "", bill);
                var result = SerializationHelper.SerializeToJson(koloWs);
                context.Dispose();
                return result;

            }
            if(bill.AllowPartialPayment)
            {
                if (bill.LeftToPay == billPayment.PaidAmount)
                {
                    billPayment.DatePaid = DateTime.Now;
                    billPayment.LastPayment = true;

                    bill.CodeRefBillStatus = KoloConstants.Operation.BillStatus.PAID.ToString();
                    bill.LeftToPay -= billPayment.PaidAmount;

                    KoloWsObject<Bill> koloWs = new KoloWsObject<Bill>(true, "", bill);
                    var result = SerializationHelper.SerializeToJson(koloWs);
                    context.Dispose();
                    return result;
                }
                if (bill.LeftToPay > billPayment.PaidAmount)
                {
                    billPayment.DatePaid = DateTime.Now;
                    billPayment.LastPayment = false;

                    bill.CodeRefBillStatus = KoloConstants.Operation.BillStatus.PAY_PROCESSING.ToString();
                    bill.LeftToPay -= billPayment.PaidAmount;

                    KoloWsObject<Bill> koloWs = new KoloWsObject<Bill>(true, "", bill);
                    var result = SerializationHelper.SerializeToJson(koloWs);
                    context.Dispose();
                    return result;
                }
            }
            return "";
        }

        [WebMethod]
        public string RejectBill(string jsonIdBill)
        {
            KoloAndroidEntities context = new KoloAndroidEntities();
            int idBill = 0;
            if (!Int32.TryParse(jsonIdBill, out idBill))
            {
                KoloWsObject<Bill> koloWs = new KoloWsObject<Bill>(false, "Bill Not Found", null);
                var result = SerializationHelper.SerializeToJson(koloWs);
                context.Dispose();
                return result;
            }
            else
            {
                Bill bill = context.Bills.FirstOrDefault(b => b.IdBill == idBill);
                bill.CodeRefBillStatus = KoloConstants.Operation.BillStatus.CANCELED.ToString();
                context.SaveChanges();
                KoloWsObject<Bill> koloWs = new KoloWsObject<Bill>(true, "", bill);
                var result = SerializationHelper.SerializeToJson(koloWs);
                context.Dispose();
                return result;
            }
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