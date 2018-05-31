using System;

namespace KoloWin.CustomerService.Utils.Transfert
{
    public static class CustomerHistoryHelper
    {
        public static Poco.CustomerBalanceHistory UpdateCustomerHistory(Poco.Customer customer, int amount, string transfertType)
        {
            var cBH = new Poco.CustomerBalanceHistory();
            if (transfertType.Contains("SEND"))
            {
                cBH.Amount = amount;
                cBH.IdCustomerAccount = customer.IdCustomer;
                cBH.OperationTypeCode = transfertType;
                cBH.OldBalance = customer.Balance;
                cBH.NewBalance = customer.Balance - amount;
                cBH.HistoryDate = DateTime.Now;
                customer.Balance -= amount;
            }
            else
            {
                if (transfertType.Contains("RECV"))
                {
                    cBH.Amount = amount;
                    cBH.IdCustomerAccount = customer.IdCustomer;
                    cBH.OperationTypeCode = transfertType;
                    cBH.OldBalance = customer.Balance;
                    cBH.NewBalance = customer.Balance + amount;
                    cBH.HistoryDate = DateTime.Now;
                    customer.Balance += amount;
                }
                else
                {
                    if (transfertType.Contains("DEPOSIT"))
                    {
                        cBH.Amount = amount;
                        cBH.IdCustomerAccount = customer.IdCustomer;
                        cBH.OperationTypeCode = transfertType;
                        cBH.OldBalance = customer.Balance;
                        cBH.NewBalance = customer.Balance + amount;
                        cBH.HistoryDate = DateTime.Now;
                        customer.Balance += amount;
                    }
                    else
                    {
                        if (transfertType.Contains("WITHDRAWAL"))
                        {
                            cBH.Amount = amount;
                            cBH.IdCustomerAccount = customer.IdCustomer;
                            cBH.OperationTypeCode = transfertType;
                            cBH.OldBalance = customer.Balance;
                            cBH.NewBalance = customer.Balance - amount;
                            cBH.HistoryDate = DateTime.Now;
                            customer.Balance -= amount;
                        }
                    }
                }
            }
            return cBH;
        }
    }
}
