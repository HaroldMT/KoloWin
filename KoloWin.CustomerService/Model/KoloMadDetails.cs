using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class KoloMadDetails
    {
        public string Reference { get; set; }
        public int Bordereau { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public string CodeTerminal { get; set; }
        public int IdCaisse { get; set; }
        public int IdOperateur { get; set; }
        public int IdClientEmetteur { get; set; }
        public int IdClientBeneficiaire { get; set; }
        public int Montant { get; set; }
        public int Ccion { get; set; }
        public int Tva { get; set; }
        public bool ToutReseau { get; set; }
        public string CodeVille { get; set; }
        public string Password { get; set; }
    }
}