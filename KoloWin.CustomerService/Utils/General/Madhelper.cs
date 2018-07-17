using KoloWin.CustomerService.Util;
using KoloWin.CustomerService.Utils.Transfert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
	public class Madhelper
	{
        public static string FindCustomerMad(ref KoloWin.CustomerService.Model.KoloMadCustomer madCustomer, out string error)
        {
            error = "";
            try
            {
                ExWebSvc4Mad.ExWebSvcSoapClient exWeb = new ExWebSvc4Mad.ExWebSvcSoapClient();
                ExWebSvc4Mad.KoloMadCustomer wsMadCustomer = exWeb.GetKoloMadCustomer(madCustomer.WsKoloMadCustomer());
                madCustomer = new KoloWin.CustomerService.Model.KoloMadCustomer(wsMadCustomer);
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

        public static KoloWin.CustomerService.Model.KoloMadDetails DoSendMad(ref KoloWin.CustomerService.Model.KoloMadDetails koloMadDetails, out string error)
        {
            error = "";
            try
            {
                var Context = new KoloAndroidEntities();
                ExWebSvc4Mad.KoloMadDetails wsKoloMadDetails = new ExWebSvc4Mad.ExWebSvcSoapClient().SendKoloMad(koloMadDetails.WsKoloMadDetails());
                if (wsKoloMadDetails != null)
                {
                    Model.KoloMadDetails.KoloMadDetailsFromWs(ref koloMadDetails, wsKoloMadDetails);
                    TransferGravity transfertGravity = koloMadDetails.GenerateTransferGravity();
                    Tuple<List<KoloNotification>, List<CustomerBalanceHistory>> tuple = OperationHelper.MakeOperation<TransferGravity>(transfertGravity, Context, out error);
                    Context.KoloNotifications.AddRange(tuple.Item1);
                    Context.CustomerBalanceHistories.AddRange(tuple.Item2);
                    Context.TransferGravities.Add(transfertGravity);
                    Context.SaveChanges();
                }
                
            }
            catch (Exception ex) 
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            return koloMadDetails;
        }
        
        public static int GetMADFees(int amount, out string error)
        {
            error = "";
            try
            {
                int frais = new ExWebSvc4Mad.ExWebSvcSoapClient().GetFrais(amount);
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