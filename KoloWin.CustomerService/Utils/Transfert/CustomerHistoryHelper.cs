using System;

namespace KoloWin.CustomerService.Utils.Transfert
{
    public static class CustomerHistoryHelper
    {
        public static CustomerBalanceHistory GenerateCustomerHistory(Customer customer, int amount, string operationTypeCode)
        {
            var cBH = new CustomerBalanceHistory();
            if (operationTypeCode.Contains("SEND") || operationTypeCode.Contains("DEPOSIT"))
            {
                cBH.Amount = amount;
                cBH.IdCustomerAccount = customer.IdCustomer;
                cBH.OperationTypeCode = operationTypeCode;
                cBH.OldBalance = customer.Balance;
                cBH.NewBalance = customer.Balance - amount;
                cBH.HistoryDate = DateTime.Now;
                customer.Balance -= amount;
            }
            if (operationTypeCode.Contains("RECV") || operationTypeCode.Contains("WITHDRAWAL"))
            {
                cBH.Amount = amount;
                cBH.IdCustomerAccount = customer.IdCustomer;
                cBH.OperationTypeCode = operationTypeCode;
                cBH.OldBalance = customer.Balance;
                cBH.NewBalance = customer.Balance + amount;
                cBH.HistoryDate = DateTime.Now;
                customer.Balance += amount;
            }
            return cBH;
        }
    }
}
