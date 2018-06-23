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
            ExWebSrv4Kolo.WebService4KoloSoapClient exWS4Kolo = new ExWebSrv4Kolo.WebService4KoloSoapClient();
            ExWebSrv4Kolo.UnpaidBill tmp = null;
            try
            {
                tmp = exWS4Kolo.FindEneoByBillNumber(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER, billNumber);
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            List<EneoBillDetails> eBDs = new List<EneoBillDetails>();
            eBDs.Add(new EneoBillDetails(tmp));
            return eBDs;
        }
        
        public static List<EneoBillDetails> GetEneoBillsByBillAccount(string billAccount, out string error)
        {
            error = "";
            ExWebSrv4Kolo.WebService4KoloSoapClient exWS4Kolo = new ExWebSrv4Kolo.WebService4KoloSoapClient();
            ExWebSrv4Kolo.UnpaidBill[] tmp = null;
            try
            {
                tmp = exWS4Kolo.FindEneoByBillAccount(KoloConstants.KOLO_ENEO_CODETERM, KoloConstants.KOLO_ENEO_PASSTERM, KoloConstants.KOLO_ENEO_CODEUSER, KoloConstants.KOLO_ENEO_PASSUSER, billAccount);
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            List<EneoBillDetails> eBDs = tmp.Select(e => new EneoBillDetails(e)).ToList();
            return eBDs;
        }


    }
}