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
            this.MadCustomerId = madCustomer.IdClient;
            this.MadCustomerCode = madCustomer.CodeClient;
            this.LastName = madCustomer.Nom;
            this.FirstName = madCustomer.Prenom;
            this.PhoneNumber = madCustomer.Number;
            this.Success = madCustomer.Success;
            this.Error = madCustomer.Error;

        }

        public ExWebSvc4Mad.KoloMadCustomer WsKoloMadCustomer()
        {
            ExWebSvc4Mad.KoloMadCustomer madCustomer = new ExWebSvc4Mad.KoloMadCustomer();
            
            madCustomer.IdClient = this.MadCustomerId;
            madCustomer.CodeClient = this.MadCustomerCode;
            madCustomer.Nom = this.LastName;
            madCustomer.Prenom = this.FirstName;
            madCustomer.Number = this.PhoneNumber;
            madCustomer.Success = this.Success;
            madCustomer.Error = this.Error;

            return madCustomer;
        }

    }
}