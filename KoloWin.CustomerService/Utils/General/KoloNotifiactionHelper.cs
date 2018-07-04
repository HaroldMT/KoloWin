using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
    public static class KoloNotifiactionHelper
    {
        public static List<KoloNotification> GenerateNotification<T>(T t,KoloConstants.Operation.Category category,out string error)
        {
            error = "";
            List<KoloNotification> notifications = new List<KoloNotification>();
            if (t.GetType() == typeof(TransfertP2p))
            {
                var tmp = t as TransfertP2p;
                KoloNotification senderNotification = new KoloNotification();
                KoloNotification recieverNotification = new KoloNotification();
                
                senderNotification.IdCustomer = tmp.IdSendingCustomer;
                recieverNotification.IdCustomer = tmp.IdSendingCustomer;

                notifications.Add(senderNotification);
                notifications.Add(recieverNotification);

                FillNotifications(tmp,ref notifications);
            }
            else if (t.GetType() == typeof(EneoBillPayment))
            {
                var tmp = t as EneoBillPayment;
                KoloNotification notification = new KoloNotification();

                notification.IdCustomer = tmp.IdCustomer;
                
                notifications.Add(notification);

                FillNotifications(tmp, ref notifications);
            }
            else if (t.GetType() == typeof(TopUp))
            {
                var tmp = t as TopUp;
                KoloNotification notification = new KoloNotification();

                notification.IdCustomer = tmp.IdCustomer;

                notifications.Add(notification);

                FillNotifications(tmp, ref notifications);
            }
            return notifications;
        }

        private static List<string> GenerateNotificationsTitles<T>(T t)
        {
            List<string> titles = new List<string>();

            if (t.GetType() == typeof(TransfertP2p))
            {
                var tmp = t as TransfertP2p;
                string senderTitle = tmp.TransfertStatusCode + " : SENDING KOLO TRANSFERT P2P";
                string receiverTitle = tmp.TransfertStatusCode + " : RECIEVE KOLO TRANSFERT P2P";
                titles.Add(senderTitle);
                titles.Add(receiverTitle);
            }
            else if (t.GetType() == typeof(EneoBillPayment))
            {
                var tmp = t as EneoBillPayment;
                string title = "ENEO BILL PAYMENT";
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

        private static List<string> GenerateNotificationsMessages<T>(T t)
        {
            List<string> messages = new List<string>();
            RefOperationStatu statu = null;
            if (t.GetType() == typeof(TransfertP2p))
            {
                var tmp = t as TransfertP2p;
                using (var db = new KoloAndroidEntities())
                {
                    tmp.Sender = db.Customers.FirstOrDefault(c => c.IdCustomer == tmp.IdSendingCustomer);
                    tmp.Receiver = db.Customers.FirstOrDefault(c => c.IdCustomer == tmp.IdReceiverCustomer);
                    tmp.Sender.Person = db.People.FirstOrDefault(p => p.IdCustomer == tmp.IdSendingCustomer);
                    tmp.Receiver.Person = db.People.FirstOrDefault(p => p.IdCustomer == tmp.IdReceiverCustomer);
                    statu = db.RefOperationStatus.FirstOrDefault(s => s.OperationStatusCode == tmp.TransfertStatusCode);
                }
                string senderMessage = "Dear M/Miss "+ tmp.Sender.Person.Firstname + " " + tmp.Sender.Person.Lastname 
                                     + " you have send Account to Account transfert to M/Miss "
                                     + tmp.Receiver.Person.Firstname + " " + tmp.Receiver.Person.Lastname 
                                     + " for an amount of "+ tmp.Amount + " . Reference "+ tmp.Reference;
                string receiverMessage = "Dear M/Miss " + tmp.Receiver.Person.Firstname + " " + tmp.Receiver.Person.Lastname
                                     + " you have recieve Account to Account transfert from M/Miss "
                                     + tmp.Sender.Person.Firstname + " " + tmp.Sender.Person.Lastname
                                     + " for an amount of " + tmp.Amount + " . Reference " + tmp.Reference;
                if (statu.OperationStatusCode == KoloConstants.Operation.Status.COMPLETED.ToString())
                {
                    senderMessage += " Your new balance is : " + (tmp.Sender.Balance - tmp.Amount);
                    receiverMessage += " Your new balance is : " + (tmp.Receiver.Balance + tmp.Amount);
                }
                if (statu.OperationStatusCode == KoloConstants.Operation.Status.RECEIVE_PENDING.ToString())
                {
                    senderMessage += " . Waiting Receiver Acceptation " ;
                    receiverMessage += " . Waiting Your Acceptation ";
                }
                if (statu.OperationStatusCode == KoloConstants.Operation.Status.CONFIRM_PENDING.ToString())
                {
                    senderMessage += " . Waiting Your Confirmation ";
                    receiverMessage += " . Waiting Sender Confirmation ";
                }
                messages.Add(senderMessage);
                messages.Add(receiverMessage);
            }
            if (t.GetType() == typeof(EneoBillPayment))
            {
                var tmp = t as EneoBillPayment;
                using (var db = new KoloAndroidEntities())
                {
                    tmp.Customer = db.Customers.FirstOrDefault(c => c.IdCustomer == tmp.IdCustomer);
                    tmp.Customer.Person = db.People.FirstOrDefault(p => p.IdCustomer == tmp.IdCustomer);
                }
                string message = "Dear Mr/Miss " + tmp.Customer.Person.Firstname + " " + tmp.Customer.Person.Lastname
                               + " you have paid your ENEO bill Number " + tmp.BillNumber + " , Reference "+ tmp.Reference
                               + " with amount of " + tmp.BillAmount;
                messages.Add(message);
            }
            if (t.GetType() == typeof(TopUp))
            {
                var tmp = t as TopUp;
                using (var db = new KoloAndroidEntities())
                {
                    tmp.Customer = db.Customers.FirstOrDefault(c => c.IdCustomer == tmp.IdCustomer);
                    tmp.Customer.Person = db.People.FirstOrDefault(p => p.IdCustomer == tmp.IdCustomer);
                }
                string message = "Dear Mr/Miss " + tmp.Customer.Person.Firstname + " " + tmp.Customer.Person.Lastname
                               + " you have done a TopUp operation for the number " + tmp.PhoneNumber + " with amount of " + tmp.Amount;
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

        private static List<KoloNotification> FillNotifications<T>(T t,ref List<KoloNotification> ns)
        {
            foreach(KoloNotification notification in ns)
            {
                List<string> titles = GenerateNotificationsTitles(t);
                List<string> messages = GenerateNotificationsMessages(t);
                List<string> categories = GenerateNotificationsCategories(t);
                
                notification.Title = titles[0];
                notification.Message = messages[0];
                notification.Category = categories[0];
                notification.CreationDate = DateTime.Now;
                notification.Readed = false;
                notification.ExpiryDate = DateTime.Now.AddDays(3);
            }
            return ns;
        }

    }
}