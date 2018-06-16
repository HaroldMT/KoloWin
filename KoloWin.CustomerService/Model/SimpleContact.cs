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
        public string MiddleName { get; set; }
        public int IdCustomer { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public SimpleContact()
        {

        }

        public SimpleContact(Customer customer)
        {
            this.FirstName = customer.Person.Firstname;
            this.LastName = customer.Person.Lastname;
            this.IdCustomer = customer.IdCustomer;
            this.Email = customer.Registration.Email;
            this.Telephone = customer.MobileDevice.LineNumber ?? customer.Registration.PhoneNumber;
        }
    }
}