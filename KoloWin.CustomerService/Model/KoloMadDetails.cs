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
            this.Bordereau = (int)madDetails.Bordereau;
            this.Success = madDetails.Success;
            this.Error = madDetails.Error;
            this.CodeTerminal = madDetails.CodeTerminal;
            this.IdCaisse = (int)madDetails.IdCaisse;
            this.IdOperateur = madDetails.IdOperateur;
            this.IdClientEmetteur = madDetails.IdClientEmetteur;
            this.IdClientBeneficiaire = madDetails.IdClientBeneficiaire;
            this.Montant = (int)madDetails.Montant;
            this.Ccion = madDetails.Ccion;
            this.Tva = madDetails.Tva;
            this.ToutReseau = madDetails.ToutReseau;
            this.CodeVille = madDetails.CodeVille;
            this.Password = madDetails.Password;
        }

        public ExWebSvc4Mad.KoloMadDetails WsKoloMadDetails()
        {
            ExWebSvc4Mad.KoloMadDetails madDetails = new ExWebSvc4Mad.KoloMadDetails();

            madDetails.Reference = this.Reference;
            madDetails.Bordereau = (int)this.Bordereau;
            madDetails.Success = this.Success;
            madDetails.Error = this.Error;
            madDetails.CodeTerminal = this.CodeTerminal;
            madDetails.IdCaisse = (int)this.IdCaisse;
            madDetails.IdOperateur = this.IdOperateur;
            madDetails.IdClientEmetteur = this.IdClientEmetteur;
            madDetails.IdClientBeneficiaire = this.IdClientBeneficiaire;
            madDetails.Montant = (int)this.Montant;
            madDetails.Ccion = this.Ccion;
            madDetails.Tva = this.Tva;
            madDetails.ToutReseau = this.ToutReseau;
            madDetails.CodeVille = this.CodeVille;
            madDetails.Password = this.Password;

            return madDetails;
        }

    }
}