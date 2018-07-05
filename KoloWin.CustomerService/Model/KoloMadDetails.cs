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

        public KoloMadDetails(ExWebSvc4Mad.KoloMadDetails madDetails)
        {
            this.Reference = madDetails.Reference;
            this.MadId = (int)madDetails.Bordereau;
            this.Success = madDetails.Success;
            this.Error = madDetails.Error;
            this.SenderId = madDetails.IdClientEmetteur;
            this.ReceiverId = madDetails.IdClientBeneficiaire;
            this.Amount = (int)madDetails.Montant;
            this.Fee = madDetails.Ccion;
            this.Tax = madDetails.Tva;
            this.Everywhere = madDetails.ToutReseau;
            this.CityCode = madDetails.CodeVille;
            this.Password = madDetails.Password;
        }


        public KoloMadDetails(TransferGravity transferGravity)
        {
            this.Reference = transferGravity.GravityReference;
            this.MadId = transferGravity.TransferMadId;
            this.SenderId = transferGravity.GravitySenderId;
            this.ReceiverId = transferGravity.GravityReceiverId;
            this.Amount = transferGravity.Amount;
            //this.Fee = transferGravity.F;
            //this.Tax = transferGravity.Tva;
            //this.Everywhere = transferGravity.ToutReseau;
            //this.CityCode = transferGravity.;
            //this.Password = transferGravity.Password;
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

    }
}