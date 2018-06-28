using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class KoloMadCustomer
    {
        public int MadCustomerId { get; set; }
        public string MadCustomerCode { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }



        public KoloMadCustomer()
        {

        }

        public KoloMadCustomer(ExWebSvc4Mad.KoloMadCustomer madCustomer)
        {
            this.IdClient = madCustomer.IdClient;
            this.CodeClient = madCustomer.CodeClient;
            this.Nom = madCustomer.Nom;
            this.Prenom = madCustomer.Prenom;
            this.Number = madCustomer.Number;
            this.Success = madCustomer.Success;
            this.Error = madCustomer.Error;

        }

        public ExWebSvc4Mad.KoloMadCustomer WsKoloMadCustomer()
        {
            ExWebSvc4Mad.KoloMadCustomer madCustomer = new ExWebSvc4Mad.KoloMadCustomer();
            
            madCustomer.IdClient = this.IdClient;
            madCustomer.CodeClient = this.CodeClient;
            madCustomer.Nom = this.Nom;
            madCustomer.Prenom = this.Prenom;
            madCustomer.Number = this.Number;
            madCustomer.Success = this.Success;
            madCustomer.Error = this.Error;

            return madCustomer;
        }

    }
}