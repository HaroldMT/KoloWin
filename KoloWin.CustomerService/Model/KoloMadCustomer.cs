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
    }
}