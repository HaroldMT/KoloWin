using KoloWin.CustomerService.Utils.General;
using KoloWin.CustomerService.Utils.Transfert;
using System;
using System.Collections.Generic;
using System.Linq;

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
                    tA2A.TransfertStatusCode = KoloConstants.TRANSFERT_STATUS_CODE_RECEIVE_PENDING;
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
                if (tA2A.TransfertStatusCode != KoloConstants.TRANSFERT_STATUS_CODE_RECEIVE_PENDING)
                {
                    if(tA2A.NeedsConfirmation)
                    {
                        try
                        {
                            TransfertP2p t = db.TransfertP2p.Find(tA2A.IdTransfertP2p);
                            t.TransfertStatusCode = KoloConstants.TRANSFERT_STATUS_CODE_CONFIRM_PENDING;
                            db.SaveChanges();
                            return t;
                        }
                        catch(Exception e)
                        {
                            error = ExceptionHelper.GetExceptionMessage(e);
                        }
                        return new TransfertP2p() { IdTransfertP2p = -30, TransfertStatusCode = error };
                    }
                    if (!tA2A.NeedsConfirmation)
                    {
                        try
                        {
                            TransfertP2p t = db.TransfertP2p.Find(tA2A.IdTransfertP2p);

                            Customer sender = db.Customers.Find(t.IdSendingCustomer);
                            Customer reciever = db.Customers.Find(t.IdReceiverCustomer);

                            CustomerBalanceHistory senderBalanceHistory = CustomerHistoryHelper.GenerateCustomerHistory(sender, t.Amount, KoloConstants.TRANSFERT_TYPE_SEND_ACCOUNT_TO_ACCOUNT);
                            CustomerBalanceHistory recieverBalanceHistory = CustomerHistoryHelper.GenerateCustomerHistory(sender, t.Amount, KoloConstants.TRANSFERT_TYPE_RECIEVE_ACCOUNT_TO_ACCOUNT);

                            db.CustomerBalanceHistories.Add(senderBalanceHistory);
                            db.CustomerBalanceHistories.Add(recieverBalanceHistory);

                            t.TransfertStatusCode = KoloConstants.TRANSFERT_STATUS_CODE_COMPLETED;
                            db.SaveChanges();
                            return t;
                        }
                        catch (Exception e)
                        {
                            error = ExceptionHelper.GetExceptionMessage(e);
                        }
                        return new TransfertP2p() { IdTransfertP2p = -30, TransfertStatusCode = error };
                    }
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
                if (tA2A.TransfertStatusCode != KoloConstants.TRANSFERT_STATUS_CODE_CONFIRM_PENDING)
                {
                    try
                    {
                        TransfertP2p t = db.TransfertP2p.Find(tA2A.IdTransfertP2p);

                        Customer sender = db.Customers.Find(t.IdSendingCustomer);
                        Customer reciever = db.Customers.Find(t.IdReceiverCustomer);

                        CustomerBalanceHistory senderBalanceHistory = CustomerHistoryHelper.GenerateCustomerHistory(sender, t.Amount, KoloConstants.TRANSFERT_TYPE_SEND_ACCOUNT_TO_ACCOUNT);
                        CustomerBalanceHistory recieverBalanceHistory = CustomerHistoryHelper.GenerateCustomerHistory(sender, t.Amount, KoloConstants.TRANSFERT_TYPE_RECIEVE_ACCOUNT_TO_ACCOUNT);

                        db.CustomerBalanceHistories.Add(senderBalanceHistory);
                        db.CustomerBalanceHistories.Add(recieverBalanceHistory);

                        t.TransfertStatusCode = KoloConstants.TRANSFERT_STATUS_CODE_COMPLETED;
                        db.SaveChanges();
                        return t;
                    }
                    catch (Exception e)
                    {
                        error = ExceptionHelper.GetExceptionMessage(e);
                    }
                    return new TransfertP2p() { IdTransfertP2p = -30, TransfertStatusCode = error };
                }
                return new TransfertP2p() { IdTransfertP2p = -20, TransfertStatusCode = "Le statut du transfert est inadequat pour une reception : " + tA2A.TransfertStatusCode };
            }
            return new TransfertP2p() { IdTransfertP2p = -10, TransfertStatusCode = "Parametres du transfert sont non conformes" };
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
