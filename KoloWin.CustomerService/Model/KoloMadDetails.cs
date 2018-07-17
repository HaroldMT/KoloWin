using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class KoloMadDetails
    {
        public string Reference { get; set; }
        public int MadId { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public const string TerminalCode = "KOLO";
        public const int CashBoxId = 4298;
        public const int CashierId = 1700;
        public int CustomerId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int Amount { get; set; }
        public int Fee { get; set; }
        public int Tax { get; set; }
        public bool Everywhere { get; set; }
        public string CityCode { get; set; }
        public string Password { get; set; }

        public KoloMadDetails()
        {

        }

        public static void KoloMadDetailsFromWs(ref KoloMadDetails koloMad, ExWebSvc4Mad.KoloMadDetails madDetails)
        {
            koloMad.Reference = madDetails.Reference;
            koloMad.MadId = (int)madDetails.Bordereau;
            koloMad.Success = madDetails.Success;
            koloMad.Error = madDetails.Error;
            koloMad.SenderId = madDetails.IdClientEmetteur;
            koloMad.ReceiverId = madDetails.IdClientBeneficiaire;
            koloMad.Amount = (int)madDetails.Montant;
            koloMad.Fee = madDetails.Ccion;
            koloMad.Tax = madDetails.Tva;
            koloMad.Everywhere = madDetails.ToutReseau;
            koloMad.CityCode = madDetails.CodeVille;
            koloMad.Password = madDetails.Password;
        }

        public ExWebSvc4Mad.KoloMadDetails WsKoloMadDetails()
        {
            ExWebSvc4Mad.KoloMadDetails madDetails = new ExWebSvc4Mad.KoloMadDetails();

            madDetails.Reference = this.Reference;
            madDetails.Bordereau = (int)this.MadId;
            madDetails.Success = this.Success;
            madDetails.Error = this.Error;
            madDetails.CodeTerminal = TerminalCode;
            madDetails.IdCaisse = CashBoxId;
            madDetails.IdOperateur = CashierId;
            madDetails.IdClientEmetteur = this.SenderId;
            madDetails.IdClientBeneficiaire = this.ReceiverId;
            madDetails.Montant = (int)this.Amount;
            madDetails.Ccion = this.Fee;
            madDetails.Tva = this.Tax;
            madDetails.ToutReseau = this.Everywhere;
            madDetails.CodeVille = this.CityCode;
            madDetails.Password = this.Password;

            return madDetails;
        }



        public TransferGravity GenerateTransferGravity()
        {
            TransferGravity transferGravity = new TransferGravity();
            ExWebSvc4Mad.KoloMadCustomer reciever = new ExWebSvc4Mad.ExWebSvcSoapClient().GetKoloMadCustomer(new ExWebSvc4Mad.KoloMadCustomer() { IdClient = this.ReceiverId });

            transferGravity.Amount = this.Amount;
            transferGravity.GravityReceiverId = this.ReceiverId;
            transferGravity.GravityReference = this.Reference;
            transferGravity.GravitySenderId = this.SenderId;
            transferGravity.KoloReference = this.Reference;
            transferGravity.KoloSenderId = this.CustomerId;
            transferGravity.Received = true;
            transferGravity.ReceiverFirstName = reciever.Nom;
            transferGravity.ReceiverLastName = reciever.Prenom;
            transferGravity.ReceiverPhoneNumber = reciever.Number;
            transferGravity.TransferMadId = this.MadId;


            return transferGravity;
        }


    }
}