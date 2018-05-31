using KoloWin.CustomerService.Utils.Transfert;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KoloWin.CustomerService.Util
{
    public static class TransfertP2PHelper
    {
        public static Poco.TransfertP2p SendTransfertA2A(Poco.TransfertP2p tA2A, Poco.KoloEntities db)
        {
            if (!TransfertVerification(tA2A))
            {
                var sender = db.Customers.Find(tA2A.IdSendingCustomer);
                var receiver = db.Customers.Find(tA2A.IdReceiverCustomer);

                var senderBalanceHistory = new Poco.CustomerBalanceHistory();
                var receiverBalanceHistory = new Poco.CustomerBalanceHistory();


                senderBalanceHistory = CustomerHistoryHelper.UpdateCustomerHistory(sender, tA2A.Amount, "SENDA2A");
                receiverBalanceHistory = CustomerHistoryHelper.UpdateCustomerHistory(receiver, tA2A.Amount, "RECVA2A");

                db.CustomerBalanceHistories.Add(senderBalanceHistory);
                db.CustomerBalanceHistories.Add(receiverBalanceHistory);

                tA2A.TransfertDate = DateTime.Now;

                tA2A.TransfertStatusCode = "RECEIVE";

                db.SaveChanges();

                return tA2A;
            }
            return null;
        }

        private static bool TransfertVerification(Poco.TransfertP2p tA2A)
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
                else
                {
                    if (tA2A.TransfertStatusCode != "SENDING")
                    {
                        return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private static bool TransfertP2pExists(int idSender, int idReceiver, int amount, Poco.KoloEntities db)
        {
            return db.TransfertP2p.Count(e => e.IdSendingCustomer == idSender && e.IdReceiverCustomer == idReceiver && e.Amount == amount) > 0;
        }
    }
}
