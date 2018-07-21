using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class P2pTransferDetails
    {
        public int SenderIdCustomer { get; set; }
        public String SenderTelephone { get; set; }
        public String SenderLastName { get; set; }
        public String SenderFirstName { get; set; }
        public String SenderMiddleName { get; set; }
        public int ReceiverIdCustomer { get; set; }
        public String ReceiverTelephone { get; set; }
        public String ReceiverLastName { get; set; }
        public String ReceiverFirstName { get; set; }
        public String ReceiverMiddleName { get; set; }
        public int Amount { get; set; }
        public String Status { get; set; }
        public DateTime TransferDate { get; set; }
        public String PassPhrase { get; set; }
        public bool NeedsConfirmation { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string Reference { get; set; }

        public P2pTransferDetails()
        {

        }

        public P2pTransferDetails(TransfertP2p transfer)
        {
            Customer sender = transfer.Sender;
            Customer receiver = transfer.Receiver;
            this.SenderFirstName = sender.Person.Firstname ?? "";
            this.SenderLastName = sender.Person.Lastname ?? "";
            this.SenderIdCustomer = sender.IdCustomer;
            this.SenderMiddleName = sender.Person.Middlename ?? "";
            this.SenderTelephone = sender.MobileDevices[1]?.LineNumber ?? sender.Registration?.PhoneNumber ?? "";
        
            this.ReceiverFirstName = receiver.Person.Firstname ?? "";
            this.ReceiverLastName = receiver.Person.Lastname ?? "";
            this.ReceiverIdCustomer = receiver.IdCustomer;
            this.ReceiverMiddleName = receiver.Person.Middlename ?? "";
            this.ReceiverTelephone = receiver.MobileDevices[1]?.LineNumber ?? sender.Registration?.PhoneNumber ?? "";

            this.Amount = transfer.Amount;
            this.TransferDate = transfer.TransfertDate;
            this.PassPhrase = transfer.Secret ?? "";
            this.NeedsConfirmation = transfer.NeedsConfirmation == true;
            this.ScheduleDate = transfer.TransfertDate;

            this.Status = transfer.TransfertStatusCode ?? "";
            this.Reference = transfer.Reference ??"";
        }
    }
}