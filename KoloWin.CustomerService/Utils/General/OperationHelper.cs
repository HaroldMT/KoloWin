using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Utils.General;
using KoloWin.CustomerService.Utils.Transfert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
    public static class OperationHelper
    {
        public static Tuple<List<KoloNotification> , List<CustomerBalanceHistory>> MakeOperation<T>(T t, KoloAndroidEntities db, out string error)
        {
            error = "";
            List<CustomerBalanceHistory> customerBalanceHistories = new List<CustomerBalanceHistory>();
            List<KoloNotification> koloNotifications = new List<KoloNotification>();
            
            if (t.GetType() == typeof(TransfertP2p))
            {
                var tmp = t as TransfertP2p;
                tmp.Sender = db.Customers.Include("Person").FirstOrDefault(c => c.IdCustomer == tmp.IdSendingCustomer);
                if (!CheckCustomerBalance(tmp.Sender, tmp.Amount))
                {
                    KoloNotification n = KoloNotifiactionHelper.UnsuffisantBalanceNotification(tmp.Sender, KoloConstants.Operation.Category.SENDA2A);
                    koloNotifications.Add(n);
                }
                else
                {
                    if(tmp.TransfertStatusCode == KoloConstants.Operation.Status.COMPLETED.ToString())
                        customerBalanceHistories = CustomerHistoryHelper.GenerateCustomerHistories<TransfertP2p>(tmp, db, out error);
                    koloNotifications = KoloNotifiactionHelper.GenerateNotification<TransfertP2p>(tmp, KoloConstants.Operation.Category.SENDA2A, db, out error);
                }
            }
            else if (t.GetType() == typeof(EneoBillPayment))
            {
                var tmp = t as EneoBillPayment;
                tmp.Customer = db.Customers.Include("Person").FirstOrDefault(c => c.IdCustomer == tmp.IdCustomer);
                if (!CheckCustomerBalance(tmp.Customer, tmp.BillAmount))
                {
                    KoloNotification n = KoloNotifiactionHelper.UnsuffisantBalanceNotification(tmp.Customer, KoloConstants.Operation.Category.PAYENEOBILL);
                    koloNotifications.Add(n);
                }
                else
                {
                    customerBalanceHistories = CustomerHistoryHelper.GenerateCustomerHistories<EneoBillPayment>(tmp, db, out error);
                    koloNotifications = KoloNotifiactionHelper.GenerateNotification<EneoBillPayment>(tmp, KoloConstants.Operation.Category.SENDMAD, db, out error);
                }
            }
            else if (t.GetType() == typeof(TopUp))
            {
                var tmp = t as TopUp;
                tmp.Customer = db.Customers.Include("Person").FirstOrDefault(c => c.IdCustomer == tmp.IdCustomer);
                
                if (!CheckCustomerBalance(tmp.Customer, Int32.Parse(tmp.Amount)))
                {

                    switch (tmp.OperatorCode)
                    {

                        case nameof(KoloConstants.Operation.Category.ORANGE):
                            KoloNotification n = KoloNotifiactionHelper.UnsuffisantBalanceNotification(tmp.Customer, KoloConstants.Operation.Category.ORANGE);
                            koloNotifications.Add(n);
                            break;
                        case nameof(KoloConstants.Operation.Category.MTN):
                            n = KoloNotifiactionHelper.UnsuffisantBalanceNotification(tmp.Customer, KoloConstants.Operation.Category.MTN);
                            koloNotifications.Add(n);
                            break;
                        case nameof(KoloConstants.Operation.Category.NEXTTEL):
                            n = KoloNotifiactionHelper.UnsuffisantBalanceNotification(tmp.Customer, KoloConstants.Operation.Category.NEXTTEL);
                            koloNotifications.Add(n);
                            break;
                        case nameof(KoloConstants.Operation.Category.YOOMEE):
                            n = KoloNotifiactionHelper.UnsuffisantBalanceNotification(tmp.Customer, KoloConstants.Operation.Category.YOOMEE);
                            koloNotifications.Add(n);
                            break;
                        case nameof(KoloConstants.Operation.Category.CAMTEL):
                            n = KoloNotifiactionHelper.UnsuffisantBalanceNotification(tmp.Customer, KoloConstants.Operation.Category.CAMTEL);
                            koloNotifications.Add(n);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    customerBalanceHistories = CustomerHistoryHelper.GenerateCustomerHistories<TopUp>(tmp, db, out error);
                    switch (tmp.OperatorCode)
                    {

                        case nameof(KoloConstants.Operation.Category.ORANGE):
                            koloNotifications = KoloNotifiactionHelper.GenerateNotification<TopUp>(tmp, KoloConstants.Operation.Category.ORANGE, db, out error);
                            break;
                        case nameof(KoloConstants.Operation.Category.MTN):
                            koloNotifications = KoloNotifiactionHelper.GenerateNotification<TopUp>(tmp, KoloConstants.Operation.Category.MTN, db, out error);
                            break;
                        case nameof(KoloConstants.Operation.Category.NEXTTEL):
                            koloNotifications = KoloNotifiactionHelper.GenerateNotification<TopUp>(tmp, KoloConstants.Operation.Category.NEXTTEL, db, out error);
                            break;
                        case nameof(KoloConstants.Operation.Category.YOOMEE):
                            koloNotifications = KoloNotifiactionHelper.GenerateNotification<TopUp>(tmp, KoloConstants.Operation.Category.YOOMEE, db, out error);
                            break;
                        case nameof(KoloConstants.Operation.Category.CAMTEL):
                            koloNotifications = KoloNotifiactionHelper.GenerateNotification<TopUp>(tmp, KoloConstants.Operation.Category.CAMTEL, db, out error);
                            break;
                        default:
                            break;
                    }
                }
            }
            else if (t.GetType() == typeof(TransferGravity))
            {
                var tmp = t as TransferGravity;
                tmp.Customer = db.Customers.Include("Person").FirstOrDefault(c => c.IdCustomer == tmp.KoloSenderId);
                if (!CheckCustomerBalance(tmp.Customer, tmp.Amount))
                {
                    KoloNotification n = KoloNotifiactionHelper.UnsuffisantBalanceNotification(tmp.Customer, KoloConstants.Operation.Category.SENDMAD);
                    koloNotifications.Add(n);
                }
                else
                {
                    customerBalanceHistories = CustomerHistoryHelper.GenerateCustomerHistories<TransferGravity>(tmp, db, out error);
                    koloNotifications = KoloNotifiactionHelper.GenerateNotification<TransferGravity>(tmp, KoloConstants.Operation.Category.SENDMAD, db, out error);
                }

            }

            var tuple = new Tuple<List<KoloNotification>, List<CustomerBalanceHistory>>(koloNotifications, customerBalanceHistories);

            return tuple;
        }
        private static bool CheckCustomerBalance(Customer c, int amount)
        {
            return ((c.Balance - amount) >= 0);
        }



    }
}