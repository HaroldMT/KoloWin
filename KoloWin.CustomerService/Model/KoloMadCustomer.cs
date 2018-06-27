using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class KoloMadCustomer
    {
        public int IdClient { get; set; }
        public string CodeClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Number { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }
}