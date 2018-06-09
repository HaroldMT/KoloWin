using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class SimpleContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdCustomer { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string ImageUrl { get; set; }
    }
}