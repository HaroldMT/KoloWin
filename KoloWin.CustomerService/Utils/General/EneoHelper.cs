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
            ExWebSvc4ExTools.WebService4KoloSoapClient exWS4Kolo = new ExWebSvc4ExTools.WebService4KoloSoapClient();
            ExWebSvc4ExTools.UnpaidBill tmp = null;
            try
            {
                tmp = exWS4Kolo.FindEneoByBillNumber(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER, billNumber);
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
                tmp = exWS4Kolo.FindEneoByBillAccount(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER, billAccount);
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
                var Context = new KoloAndroidEntities4Serialization();
                Customer c = Context.Customers.Find(Int32.Parse(idCustomer));
                c.Person = Context.People.Find(c.IdCustomer);
                c.MobileDevice = Context.MobileDevices.FirstOrDefault(m => m.IdMobileDevice == c.IdCustomer);
                ExWebSvc4ExTools.WebService4KoloSoapClient exWS4Kolo = new ExWebSvc4ExTools.WebService4KoloSoapClient();
                var reference = exWS4Kolo.PayENEO(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER, numeroFacture, c.Person.Firstname + " " + c.Person.Lastname, c.MobileDevice.LineNumber);
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