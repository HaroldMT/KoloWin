using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Util;
using KoloWin.CustomerService.Utils.Transfert;
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
            ExWebSvc4ExTools.WebService4KoloSoapClient exWS4Kolo = new ExWebSvc4ExTools.WebService4KoloSoapClient();
            ExWebSvc4ExTools.UnpaidBill tmp = null;
            try
            {
                tmp = exWS4Kolo.FindEneoByBillNumber(KoloConstants.EneoExTermAuth.KOLO_ENEO_CODETERM, KoloConstants.EneoExTermAuth.KOLO_ENEO_PASSTERM, KoloConstants.EneoExTermAuth.KOLO_ENEO_CODEUSER, KoloConstants.EneoExTermAuth.KOLO_ENEO_PASSUSER, billNumber);
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            List<EneoBillDetails> eBDs = new List<EneoBillDetails>();
            if(tmp != null)
                eBDs.Add(new EneoBillDetails(tmp));
            return eBDs;
        }
        
        public static List<EneoBillDetails> GetEneoBillsByBillAccount(string billAccount, out string error)
        {
            error = "";
            ExWebSvc4ExTools.WebService4KoloSoapClient exWS4Kolo = new ExWebSvc4ExTools.WebService4KoloSoapClient();
            ExWebSvc4ExTools.UnpaidBill[] tmp = null;
            try
            {
                tmp = exWS4Kolo.FindEneoByBillAccount(KoloConstants.EneoExTermAuth.KOLO_ENEO_CODETERM, KoloConstants.EneoExTermAuth.KOLO_ENEO_PASSTERM, KoloConstants.EneoExTermAuth.KOLO_ENEO_CODEUSER, KoloConstants.EneoExTermAuth.KOLO_ENEO_PASSUSER, billAccount);
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            List<EneoBillDetails> eBDs = null;
            if(tmp !=null)
                eBDs = tmp.Select(e => new EneoBillDetails(e)).ToList();
            return eBDs;
        }

        public static string DoPayENEO(string codeTerm, string passTerm, string codeUser, string passUser, string numeroFacture, string idCustomer,out string error)
        {
            error = "";
            try
            {
                int id = Int32.Parse(idCustomer);
                var Context = new KoloAndroidEntities4Serialization();
                Customer c = Context.Customers.Include("Person").Include("MobileDevice").FirstOrDefault(customer =>  customer.IdCustomer == id);
                ExWebSvc4ExTools.WebService4KoloSoapClient exWS4Kolo = new ExWebSvc4ExTools.WebService4KoloSoapClient();
                var reference = exWS4Kolo.PayENEO(codeTerm, passTerm, codeUser, passUser, numeroFacture, c.Person.Firstname + " " + c.Person.Lastname, c.MobileDevice.LineNumber);
                if(reference != null)
                {
                    EneoBillPayment eBP = new EneoBillPayment();
                    ExWebSvc4ExTools.PaidBill paidBill = exWS4Kolo.FindEneoPaidBillByReference(codeTerm, passTerm, codeUser, passUser, reference);
                    if(paidBill != null)
                    {
                        eBP.BillAmount = (int)paidBill.PaidAmount;
                        eBP.BillNumber = numeroFacture;
                        eBP.Ccion = (int)paidBill.Ccions;
                        eBP.ContractNo = paidBill.BillAccountNumber;
                        eBP.IdCustomer = c.IdCustomer;
                        eBP.Customer = c;
                        eBP.PaymentDate = paidBill.PaidDate;
                        eBP.Reference = paidBill.TransactionId;
                    }
                    Tuple<List<KoloNotification>, List<CustomerBalanceHistory>> tuple = OperationHelper.MakeOperation<EneoBillPayment>(eBP, Context, out error);
                    Context.KoloNotifications.AddRange(tuple.Item1);
                    Context.CustomerBalanceHistories.AddRange(tuple.Item2);
                    Context.EneoBillPayments.Add(eBP);
                    Context.SaveChanges();
                }
                Context.Dispose();
                return reference;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
                return null;
            }
        }



        

    }
}