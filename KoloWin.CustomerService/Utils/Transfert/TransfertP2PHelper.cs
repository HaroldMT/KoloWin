using KoloWin.CustomerService.Utils.General;
using KoloWin.CustomerService.Utils.Transfert;
using System;
using System.Collections.Generic;
using System.Linq;
using KoloWin.Utilities.Office;

namespace KoloWin.CustomerService.Util
{
    public static class TransfertP2PHelper
    {
        public static TransfertP2p SendTransfertA2A(TransfertP2p tA2A, KoloAndroidEntities db, out string error)
        {
            error = "";
            if (TransfertVerification(tA2A))
            {
                try
                {
                    tA2A.TransfertDate = DateTime.Now;
                    tA2A.TransfertStatusCode = KoloConstants.Operation.Status.RECEIVE_PENDING.ToString();
                    tA2A.Reference = OfficeHelper.GenerateUniqueId();
                    List<KoloNotification> notifications = KoloNotifiactionHelper.GenerateNotification<TransfertP2p>(tA2A, KoloConstants.Operation.Category.SENDA2A, db, out error);
                    db.KoloNotifications.AddRange(notifications);
                    db.TransfertP2p.Add(tA2A);
                    db.SaveChanges();
                    return tA2A;
                }
                catch(Exception e)
                {
                    error = ExceptionHelper.GetExceptionMessage(e);
                }
            }
            return null;
        }

        public static TransfertP2p AcceptTransfertA2A(TransfertP2p tA2A, KoloAndroidEntities db, out string error)
        {
            error = "";
            if (TransfertVerification(tA2A))
            {
                if (tA2A.TransfertStatusCode != KoloConstants.Operation.Status.RECEIVE_PENDING.ToString())
                {
                    TransfertP2p tmp = db.TransfertP2p.FirstOrDefault(t => t.IdTransfertP2p == tA2A.IdTransfertP2p);
                    if (tA2A.Secret == tmp.Secret)
                    {
                        if (tA2A.NeedsConfirmation) return AskConfirmationOfTransfertA2A(tA2A, db, out error);
                        if (!tA2A.NeedsConfirmation) return ConfirmTransfertA2A(tA2A, db, out error);
                    }
                    return new TransfertP2p() { IdTransfertP2p = -30, TransfertStatusCode = "Code Secret Erroné Veuillez Ressaisir le demander a l'expediteur " };
                }
                return new TransfertP2p() { IdTransfertP2p = -20, TransfertStatusCode = "Le statut du transfert est inadequat pour une reception : "+ tA2A.TransfertStatusCode};
            }
            return new TransfertP2p() { IdTransfertP2p = -10 , TransfertStatusCode = "Parametres du transfert sont non conformes" };
        }

        public static TransfertP2p ConfirmTransfertA2A(TransfertP2p tA2A, KoloAndroidEntities db, out string error)
        {
            error = "";
            if (TransfertVerification(tA2A))
            {
                if (tA2A.TransfertStatusCode != KoloConstants.Operation.Status.CONFIRM_PENDING.ToString())
                {
                    try
                    {
                        TransfertP2p t = db.TransfertP2p.FirstOrDefault(tP2P => tP2P.IdTransfertP2p == tA2A.IdTransfertP2p);
                        t.TransfertStatusCode = tA2A.TransfertStatusCode;
                        t.Sender = db.Customers.FirstOrDefault(c => c.IdCustomer == t.IdSendingCustomer);
                        t.Receiver = db.Customers.FirstOrDefault(c => c.IdCustomer == t.IdSendingCustomer);
                        List<CustomerBalanceHistory> cBHs = CustomerHistoryHelper.GenerateCustomerHistories<TransfertP2p>(t, db, out error);
                        t.TransfertStatusCode = KoloConstants.Operation.Status.COMPLETED.ToString();
                        List<KoloNotification> notifications = KoloNotifiactionHelper.GenerateNotification<TransfertP2p>(tA2A, KoloConstants.Operation.Category.SENDA2A,db, out error);
                        db.KoloNotifications.AddRange(notifications);
                        db.SaveChanges();
                        return t;
                    }
                    catch (Exception ex)
                    {
                        error = ExceptionHelper.GetExceptionMessage(ex);
                    }
                    return new TransfertP2p() { IdTransfertP2p = -30, TransfertStatusCode = error };
                }
                return new TransfertP2p() { IdTransfertP2p = -20, TransfertStatusCode = "Le statut du transfert est inadequat pour une reception : " + tA2A.TransfertStatusCode };
            }
            return new TransfertP2p() { IdTransfertP2p = -10, TransfertStatusCode = "Parametres du transfert sont non conformes" };
        }

        public static TransfertP2p AskConfirmationOfTransfertA2A(TransfertP2p tA2A, KoloAndroidEntities db, out string error)
        {
            error = "";
            try
            {
                TransfertP2p t = db.TransfertP2p.FirstOrDefault(tP2P => tP2P.IdTransfertP2p == tA2A.IdTransfertP2p);
                t.TransfertStatusCode = tA2A.TransfertStatusCode;
                List<KoloNotification> notifications = KoloNotifiactionHelper.GenerateNotification<TransfertP2p>(tA2A, KoloConstants.Operation.Category.SENDA2A,db, out error);
                db.KoloNotifications.AddRange(notifications);
                db.SaveChanges();
                return t;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            return new TransfertP2p() { IdTransfertP2p = -30, TransfertStatusCode = error };
        }

        private static bool TransfertVerification(TransfertP2p tA2A)
        {
            if (tA2A.Amount <= 0) return false;
            if (tA2A.IdReceiverCustomer <= 0) return false;
            if (tA2A.IdSendingCustomer <= 0) return false;
            return true;
        }

        private static bool TransfertP2pExists(int idSender, int idReceiver, int amount, KoloAndroidEntities db)
        {
            return db.TransfertP2p.Count(e => e.IdSendingCustomer == idSender && e.IdReceiverCustomer == idReceiver && e.Amount == amount) > 0;
        }

        private static TransfertP2p GetTransfertP2p(TransfertP2p t, KoloAndroidEntities db)
        {
            return db.TransfertP2p.FirstOrDefault(e => e.IdReceiverCustomer == t.IdReceiverCustomer &&
                                                  e.IdSendingCustomer == t.IdSendingCustomer &&
                                                  e.IdTransfertP2p == t.IdTransfertP2p &&
                                                  e.IdTransfertScheduled == t.IdTransfertScheduled &&
                                                  e.NeedsConfirmation == t.NeedsConfirmation &&
                                                  e.Reference == t.Reference &&
                                                  e.Secret == t.Secret &&
                                                  e.Transfert2Cash == t.Transfert2Cash &&
                                                  e.TransfertDate == t.TransfertDate &&
                                                  e.TransfertStatusCode == t.TransfertStatusCode ) ;
        }

    }
}
