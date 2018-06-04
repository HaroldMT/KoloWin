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
                    //var sender = db.Customers.Find(tA2A.IdSendingCustomer);
                    //var receiver = db.Customers.Find(tA2A.IdReceiverCustomer);

                    //var senderBalanceHistory = new CustomerBalanceHistory();
                    //var receiverBalanceHistory = new CustomerBalanceHistory();
                    
                    //senderBalanceHistory = CustomerHistoryHelper.UpdateCustomerHistory(sender, tA2A.Amount, KoloConstants.TRANSFERT_TYPE_SEND_ACCOUNT_TO_ACCOUNT);
                    //receiverBalanceHistory = CustomerHistoryHelper.UpdateCustomerHistory(receiver, tA2A.Amount, KoloConstants.TRANSFERT_TYPE_RECIEVE_ACCOUNT_TO_ACCOUNT);

                    //db.CustomerBalanceHistories.Add(senderBalanceHistory);
                    //db.CustomerBalanceHistories.Add(receiverBalanceHistory);

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

        private static bool TransfertVerification(TransfertP2p tA2A)
        {
            if (tA2A.Amount <= 0)
            {
                return false;
            }
            else
            {
                if (tA2A.IdReceiverCustomer <= 0)
                {
                    return false;
                }
            }
            if (tA2A.IdSendingCustomer <= 0)
            {
                return false;
            }
            else
            {
                if (tA2A.IdTransfertScheduled <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool TransfertP2pExists(int idSender, int idReceiver, int amount, KoloAndroidEntities db)
        {
            return db.TransfertP2p.Count(e => e.IdSendingCustomer == idSender && e.IdReceiverCustomer == idReceiver && e.Amount == amount) > 0;
        }
    }
}
