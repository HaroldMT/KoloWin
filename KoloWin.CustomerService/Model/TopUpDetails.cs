using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class TopUpDetails
    {
        public string SelectedPartner { get; set; }
        public int CustomerId { get; set; }
        public int Amount { get; set; }
        public string Number { get; set; }

        public TopUp GeneraTopUp()
        {
            TopUp topUp = new TopUp();

            topUp.IdCustomer = this.CustomerId;
            topUp.Amount = this.Amount.ToString();
            topUp.PhoneNumber = this.Number;
            topUp.OperatorCode = this.SelectedPartner;

            return topUp;
        }

    }
}