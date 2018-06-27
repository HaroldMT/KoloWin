using KoloWin.CustomerService.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
	public class Madhelper
	{
        public static string FindCustomerMad(int amount, string phone, string customerCode, string reference, out string error)
        {
            error = "";
            ExWebSvc4Mad.ExWebSvcSoapClient exWeb = new ExWebSvc4Mad.ExWebSvcSoapClient();
            try
            {
                string mad = exWeb.ConsulterMad(customerCode, phone, reference, amount);
                if (mad == null || mad == "")
                    error = "Aucune transaction recupére";
                else
                    return mad;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            return "";
        }

        public static string FindManagerCustomerByPhone(string phone, out string error)
        {
            error = "";
            try
            {
                ExWebSvc4Mad.ExWebSvcSoapClient exWeb = new ExWebSvc4Mad.ExWebSvcSoapClient();
                string client = exWeb.GetClient("", phone);
                if (client == null || client == "")
                {
                    error = "Aucune Client trouvé";
                    return "";
                }
                return client;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
                return "";
            }
        }

        public static string FindManagerCustomerByCustomerCode(string customerCode, out string error)
        {
            error = "";
            try
            {
                ExWebSvc4Mad.ExWebSvcSoapClient exWeb = new ExWebSvc4Mad.ExWebSvcSoapClient();
                string client = exWeb.GetClient(customerCode, "");
                if (client == null || client == "")
                {
                    error = "Aucune Client trouvé";
                    return "";
                }
                return client;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
                return "";
            }
        }

        public static int DoSendMad(int idE, int idB, int montant, out string error)
        {
            error = "";
            try
            {
                int idMAD = new ExWebSvc4Mad.ExWebSvcSoapClient().SaveMad("TESTMOBILE", 4298, 1700, idE, idB, montant, 0, 0, "TOUTRESEAU", "TEST" + DateTime.Now);
                return idMAD;
            }
            catch (Exception ex) 
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
                return 0;
            }
        }
        
        public static int GetMADFees(int montant, out string error)
        {
            error = "";
            try
            {
                int frais = new ExWebSvc4Mad.ExWebSvcSoapClient().GetFrais(montant);
                return frais;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
                return 0;
            }
        }


    }
}