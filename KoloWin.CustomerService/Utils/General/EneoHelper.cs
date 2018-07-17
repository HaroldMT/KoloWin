using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
    public static class EneoHelper
    {

        public static List<EneoBillDetails> GetEneoBillByBillNumber(string billNumber, out string error)
        {
            error = "";
            ExEneoSvc.ExEneoSoapClient exWS4Kolo = new ExEneoSvc.ExEneoSoapClient();
            try
            {
                var s = exWS4Kolo.FindEneoByBillNumber( billNumber);
                List<EneoBillDetails> eBDs = new List<EneoBillDetails>();
                if (s.IsSucces)
                    eBDs.Add(new EneoBillDetails(s.DataObject));
                return eBDs;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
                return null;
            }
        }
        
        public static List<EneoBillDetails> GetEneoBillsByBillAccount(string billAccount, out string error)
        {
            error = "";
            ExEneoSvc.ExEneoSoapClient exWS4Kolo = new ExEneoSvc.ExEneoSoapClient();
            //ExWebSvc4ExTools.UnpaidBill[] tmp = null;
            try
            {
                var tmp = exWS4Kolo.FindEneoByBillAccount(billAccount);
                List<EneoBillDetails> eBDs = null;
                if (tmp.IsSucces)
                    eBDs = tmp.DataObject.Select(e => new EneoBillDetails(e)).ToList();
                return eBDs;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
                return null;
            }
        }

        public static string DoPayENEO( string numeroFacture, string idCustomer,out string error)
        {
            error = "";
            try
            {
                int id = Int32.Parse(idCustomer);
                var Context = new KoloAndroidEntities4Serialization();
                Customer c = Context.Customers.Include("Person").Include("MobileDevice").FirstOrDefault(customer =>  customer.IdCustomer == id);
                ExEneoSvc.ExEneoSoapClient exWS4Kolo = new ExEneoSvc.ExEneoSoapClient();
                var tmp = exWS4Kolo.PayENEO(c.MobileDevice.LineNumber,numeroFacture, c.Person.Firstname + " " + c.Person.Lastname);
                EneoBillPayment eBP = new EneoBillPayment();
                if (tmp.IsSucces)
                {
                    eBP.BillAmount  = (int)tmp.DataObject.PaidAmount;
                    eBP.BillNumber  = numeroFacture;
                    eBP.Ccion       = (int)tmp.DataObject.Ccions;
                    eBP.ContractNo  = tmp.DataObject.BillAccountNumber;
                    eBP.IdCustomer  = c.IdCustomer;
                    eBP.Customer    = c;
                    eBP.PaymentDate = tmp.DataObject.PaidDate;
                    eBP.Reference   = tmp.DataObject.TransactionId;
                }
                else
                {
                    error = tmp.ErrorMessage;
                    return null;
                }
                Tuple<List<KoloNotification>, List<CustomerBalanceHistory>> tuple =  OperationHelper.MakeOperation<EneoBillPayment>(eBP, Context, out error);
                Context.KoloNotifications.AddRange(tuple.Item1);
                Context.CustomerBalanceHistories.AddRange(tuple.Item2);
                Context.EneoBillPayments.Add(eBP);
                Context.SaveChanges();
                Context.Dispose();
                return tmp.DataObject.TransactionId;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
                return null;
            }
        }
        
    }
}