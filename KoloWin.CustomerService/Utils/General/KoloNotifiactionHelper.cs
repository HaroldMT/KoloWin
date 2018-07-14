using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
    public static class KoloNotifiactionHelper
    {
        public static List<KoloNotification> GenerateNotification<T>(T t,KoloConstants.Operation.Category category, KoloAndroidEntities db, out string error)
        {
            error = "";
            List<KoloNotification> notifications = new List<KoloNotification>();
            if (t.GetType() == typeof(TransfertP2p))
            {
                var tmp = t as TransfertP2p;
                KoloNotification senderNotification = new KoloNotification();
                KoloNotification recieverNotification = new KoloNotification();
                
                senderNotification.IdCustomer = tmp.IdSendingCustomer;
                recieverNotification.IdCustomer = (int)tmp.IdReceiverCustomer;

                notifications.Add(senderNotification);
                notifications.Add(recieverNotification);

                FillNotifications(tmp,ref notifications,db);
            }
            else if (t.GetType() == typeof(EneoBillPayment))
            {
                var tmp = t as EneoBillPayment;
                KoloNotification notification = new KoloNotification();

                notification.IdCustomer = tmp.IdCustomer;
                
                notifications.Add(notification);

                FillNotifications(tmp, ref notifications,db);
            }
            else if (t.GetType() == typeof(TopUp))
            {
                var tmp = t as TopUp;
                KoloNotification notification = new KoloNotification();

                notification.IdCustomer = tmp.IdCustomer;

                notifications.Add(notification);

                FillNotifications(tmp, ref notifications,db);
            }
            return notifications;
        }

        private static List<string> GenerateNotificationsTitles<T>(T t)
        {
            List<string> titles = new List<string>();

            if (t.GetType() == typeof(TransfertP2p))
            {
                var tmp = t as TransfertP2p;
                string senderTitle = "SENDING P2P";
                string receiverTitle = "RECIEVE P2P";
                titles.Add(senderTitle);
                titles.Add(receiverTitle);
            }
            else if (t.GetType() == typeof(EneoBillPayment))
            {
                var tmp = t as EneoBillPayment;
                string title = "ENEO PAYMENT";
                titles.Add(title);
            }
            else if (t.GetType() == typeof(TopUp))
            {
                var tmp = t as TopUp;
                string title = "TOPUP OPERATION";
                titles.Add(title);
            }
            return titles;
        }

        private static List<string> GenerateNotificationsMessages<T>(T t, KoloAndroidEntities db)
        {
            List<string> messages = new List<string>();
            RefOperationStatu statu = null;
            if (t.GetType() == typeof(TransfertP2p))
            {
                var tmp = t as TransfertP2p;
                
                tmp.Sender = db.Customers.Include("Person").FirstOrDefault(c => c.IdCustomer == tmp.IdSendingCustomer);
                tmp.Receiver = db.Customers.Include("Person").FirstOrDefault(c => c.IdCustomer == tmp.IdReceiverCustomer);
                statu = db.RefOperationStatus.FirstOrDefault(s => s.OperationStatusCode == tmp.TransfertStatusCode);
                string senderMessage = "" + tmp.Sender.Person.Firstname + " " + tmp.Sender.Person.Lastname 
                                     + "-»"
                                     + tmp.Receiver.Person.Firstname + " " + tmp.Receiver.Person.Lastname 
                                     + " "+ tmp.Amount + ".Ref "+ tmp.Reference;
                string receiverMessage = " " + tmp.Receiver.Person.Firstname + " " + tmp.Receiver.Person.Lastname
                                     + "-»"
                                     + tmp.Sender.Person.Firstname + " " + tmp.Sender.Person.Lastname
                                     + " " + tmp.Amount + ".Ref " + tmp.Reference;
                if (statu.OperationStatusCode == KoloConstants.Operation.Status.COMPLETED.ToString())
                {
                    senderMessage += " Balance:" + (tmp.Sender.Balance - tmp.Amount);
                    receiverMessage += " Balance:" + (tmp.Receiver.Balance + tmp.Amount);
                }
                if (statu.OperationStatusCode == KoloConstants.Operation.Status.RECEIVE_PENDING.ToString())
                {
                    senderMessage += ".Wait Rcv Accept";
                    receiverMessage += ".Wait Your Accept";
                }
                if (statu.OperationStatusCode == KoloConstants.Operation.Status.CONFIRM_PENDING.ToString())
                {
                    senderMessage += ".Wait Your Confirm";
                    receiverMessage += ".Wait Snd Confir";
                }
                messages.Add(senderMessage);
                messages.Add(receiverMessage);
            }
            if (t.GetType() == typeof(EneoBillPayment))
            {
                var tmp = t as EneoBillPayment;
                tmp.Customer = db.Customers.Include("Person").FirstOrDefault(c => c.IdCustomer == tmp.IdCustomer);
                string message = "Dear " + tmp.Customer.Person.Firstname + " " + tmp.Customer.Person.Lastname
                               + " you paid ENEO bill " + tmp.BillNumber + " Reference "+ tmp.Reference
                               + " amount " + tmp.BillAmount;
                messages.Add(message);
            }
            if (t.GetType() == typeof(TopUp))
            {
                var tmp = t as TopUp;
                tmp.Customer = db.Customers.Include("Person").FirstOrDefault(c => c.IdCustomer == tmp.IdCustomer);
                tmp.Customer.Person = db.People.FirstOrDefault(p => p.IdCustomer == tmp.IdCustomer);
                string message = "Dear " + tmp.Customer.Person.Firstname + " " + tmp.Customer.Person.Lastname
                               + " you done TopUp for " + tmp.PhoneNumber + " amount " + tmp.Amount;
                messages.Add(message);
            }
            return messages;
        }
        
        private static List<string> GenerateNotificationsCategories<T>(T t)
        {
            List<string> categories = new List<string>();

            if (t.GetType() == typeof(TransfertP2p))
            {
                var tmp = t as TransfertP2p;
                string sendercategory = KoloConstants.Operation.Category.SENDA2A.ToString();
                string receivercategory = KoloConstants.Operation.Category.RECVA2A.ToString();
                categories.Add(sendercategory);
                categories.Add(receivercategory);
            }
            if (t.GetType() == typeof(EneoBillPayment))
            {
                var tmp = t as EneoBillPayment;
                string category = KoloConstants.Operation.Category.PAYENEOBILL.ToString();
                categories.Add(category);
            }
            if (t.GetType() == typeof(TopUp))
            {
                var tmp = t as TopUp;
                string category = tmp.OperatorCode;
                categories.Add(category);
            }
            return categories;
        }

        private static List<KoloNotification> FillNotifications<T>(T t,ref List<KoloNotification> ns, KoloAndroidEntities db)
        {

            List<string> titles = GenerateNotificationsTitles(t);
            List<string> messages = GenerateNotificationsMessages(t, db);
            List<string> categories = GenerateNotificationsCategories(t);

            foreach (KoloNotification notification in ns)
            {
                notification.Title = titles[ns.IndexOf(notification)];
                notification.Message = messages[ns.IndexOf(notification)];
                notification.Category = categories[ns.IndexOf(notification)];
                notification.CreationDate = DateTime.Now;
                notification.Readed = false;
                notification.ExpiryDate = DateTime.Now.AddDays(3);
            }
            return ns;
        }

        public static KoloNotification UnsuffisantBalanceNotification(Customer c , KoloConstants.Operation.Category category)
        {
            KoloNotification n = new KoloNotification();

            n.Title = "Insufficant Balance";
            n.Message = "Dear "+c.Person.Firstname+" your balance ("+c.Balance+") is insuffisant for this operation : "+category.ToString();
            n.Category = category.ToString();
            n.CreationDate = DateTime.Now;
            n.Readed = false;
            n.ExpiryDate = DateTime.Now.AddDays(3);

            return n;
        }

    }
}