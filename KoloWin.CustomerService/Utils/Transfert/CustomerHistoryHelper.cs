using KoloWin.CustomerService.Utils.General;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KoloWin.CustomerService.Utils.Transfert
{
    public static class CustomerHistoryHelper
    {
        public static List<CustomerBalanceHistory> GenerateCustomerHistories<T>(T t, KoloAndroidEntities db, out string error)
        {
            List<CustomerBalanceHistory> customerBalanceHistories = new List<CustomerBalanceHistory>();
            error = "";
            if (t.GetType() == typeof(TransfertP2p))
            {
                var temp = t as TransfertP2p;

                if (temp.Sender == null)
                    temp.Sender = db.Customers.FirstOrDefault(c => c.IdCustomer == temp.IdSendingCustomer);
                if (temp.Receiver == null)
                    temp.Receiver = db.Customers.FirstOrDefault(c => c.IdCustomer == temp.IdReceiverCustomer);
                
                CustomerBalanceHistory senderBalanceHistory = CreateCustomerHistory(temp.Sender, KoloConstants.Operation.Category.SENDA2A, KoloConstants.Operation.BalanceUpdateDirection.REMOVE, temp.Amount, out  error);
                CustomerBalanceHistory recieverBalanceHistory = CreateCustomerHistory(temp.Sender, KoloConstants.Operation.Category.RECVA2A, KoloConstants.Operation.BalanceUpdateDirection.ADD, temp.Amount, out error);

                customerBalanceHistories.Add(recieverBalanceHistory);
                customerBalanceHistories.Add(senderBalanceHistory);

            }
            else if (t.GetType() == typeof(EneoBillPayment))
            {
                var temp = t as EneoBillPayment;
                if (temp.Customer == null)
                    temp.Customer = db.Customers.FirstOrDefault(c => c.IdCustomer == temp.IdCustomer);

                CustomerBalanceHistory eneoBalanceHistory = CreateCustomerHistory(temp.Customer, KoloConstants.Operation.Category.PAYENEOBILL, KoloConstants.Operation.BalanceUpdateDirection.REMOVE, temp.BillAmount, out error);


                customerBalanceHistories.Add(eneoBalanceHistory);
            }
            else if (t.GetType() == typeof(TopUp))
            {
                var temp = t as TopUp;
            }


            return customerBalanceHistories;
        }

        private static CustomerBalanceHistory CreateCustomerHistory(Customer customer, KoloConstants.Operation.Category category, KoloConstants.Operation.BalanceUpdateDirection balanceDirection, int amount, out string error)
        {
            CustomerBalanceHistory cBH = new CustomerBalanceHistory();
            error = "";
            cBH.Amount = amount;
            cBH.IdCustomerAccount = customer.IdCustomer;
            cBH.OperationTypeCode = category.ToString();
            cBH.OldBalance = customer.Balance;
            if (balanceDirection == KoloConstants.Operation.BalanceUpdateDirection.REMOVE)
            {
                cBH.NewBalance = customer.Balance - amount;
                customer.Balance -= amount;
            }
            if (balanceDirection == KoloConstants.Operation.BalanceUpdateDirection.ADD)
            {
                cBH.NewBalance = customer.Balance + amount;
                customer.Balance += amount;
            }
            cBH.HistoryDate = DateTime.Now;
            return cBH;
        }
    }
}
