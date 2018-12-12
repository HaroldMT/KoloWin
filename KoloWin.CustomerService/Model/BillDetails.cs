using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class BillDetails
    {
        public int IdBill { get; set; }
        public int IdIssuingCustomer { get; set; }
        public int IdPayingCustomer { get; set; }
        public String CodeRefBillType { get; set; }
        public String CodeRefBillStatus { get; set; }
        public DateTime DateIssued { get; set; }
        public int TotalBillAmount { get; set; }
        public int LeftToPay { get; set; }
        public bool AllowPartialPayment { get; set; }
        public DateTime DateCreation { get; set; }

        public int IdBillDetail { get; set; }
        public String Description { get; set; }
        public String Unit { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int Amount { get; set; }

        public BillDetails()
        {
            if (TotalBillAmount != LeftToPay)
                LeftToPay = TotalBillAmount;
        }

        public Tuple<Bill,BillDetail> GetBillAndDetails()
        {
            Bill bill = new Bill();
            BillDetail billDetail = new BillDetail();
            
            bill.IdBill = this.IdBill;
            bill.IdIssuingCustomer =  IdIssuingCustomer;
            bill.IdPayingCustomer = IdPayingCustomer;
            bill.CodeRefBillType = CodeRefBillType;
            bill.CodeRefBillStatus = CodeRefBillStatus;
            bill.DateIssued = DateIssued;
            bill.TotalBillAmount = TotalBillAmount;
            bill.LeftToPay = LeftToPay;
            bill.AllowPartialPayment = AllowPartialPayment;
            bill.DateCreation = DateCreation;

            billDetail.IdBillDetail = IdBillDetail;
            billDetail.Description = Description;
            billDetail.Unit = Unit;
            billDetail.Quantity = Quantity;
            billDetail.UnitPrice = UnitPrice;
            billDetail.Amount = Amount;


            Tuple<Bill, BillDetail> tuple = new Tuple<Bill, BillDetail>(bill,billDetail);
            return tuple;
        }

    }
}