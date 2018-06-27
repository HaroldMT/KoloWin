using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class EneoBillDetails
    {
        public DateTime DueDate { get; set; }
        public int Amount { get; set; }
        public String BillNumber { get; set; }
        public String ContractNumber { get; set; }
        public String Reference { get; set; }

        public EneoBillDetails()
        {

        }


        public EneoBillDetails(ExWebSvc4ExTools.UnpaidBill uPB)
        {
            this.DueDate = uPB.BillDueDate;
            this.Amount = (int) uPB.BillAmount;
            this.BillNumber = uPB.BillNumber;
            this.ContractNumber = uPB.BillAccountId;
        }
        
    }
}