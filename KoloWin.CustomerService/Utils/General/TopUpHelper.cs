using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Utils.Transfert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
    public class TopUpHelper
    {

        public static bool DoTopUp(TopUpDetails topUpDetails,out string error)
        {
            error = "";
            TopUp topUp = topUpDetails.GeneraTopUp();

            ExRMoneySvc.ExRMoneySoapClient exMoneyClient = new ExRMoneySvc.ExRMoneySoapClient();
            if(!CustomerHistoryHelper.CheckCustomerBalance(topUp.IdCustomer, topUp.Amount))
            {
                error = "INSUFFISANT BANLANCE";
                return false;
            }
            var result = exMoneyClient.SendAirTime(topUpDetails.SelectedPartner, topUpDetails.Amount, topUpDetails.Number);
            error = result.Error;
            if(result.Succes)
            {
                KoloAndroidEntities Context = new KoloAndroidEntities();
                Tuple<List<KoloNotification>, List<CustomerBalanceHistory>> tuple = OperationHelper.MakeOperation<TopUp>(topUp, Context, out error);
                Context.KoloNotifications.AddRange(tuple.Item1);
                Context.CustomerBalanceHistories.AddRange(tuple.Item2);
                Context.TopUps.Add(topUp);
                Context.SaveChanges();
                Context.Dispose();
            }
            return result.Succes;


        }

    }
}