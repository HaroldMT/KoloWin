using KoloWin.CustomerService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.Entities
{
    public class CustomerHelper
    {

        public static Customer FindCustomerByIdCustomerAndNumber(int idCustomer, string number, KoloAndroidEntities context, out string error)
        {
            error = "";
            Customer c = null;
            try
            {
                if (idCustomer > 0)
                    c = context.Customers.Find(idCustomer);
                else
                    c = context.Customers.Where(e => e.Registration.PhoneNumber == number).FirstOrDefault();
            }
            catch (Exception e)
            {
                error = KoloWin.Utilities.ExceptionHelper.GetMessageFromException(e);
            }
            return c;
        }

        
        public static HashSet<SimpleContact> FindCustomerContacts(int idCustomer, HashSet<string> contacts, KoloAndroidEntities context, out string error)
        {
            error = "";
            HashSet<SimpleContact> registredContats = new HashSet<SimpleContact>();
            try
            {
                foreach(string number in contacts)
                {
                    Customer tmpCustomer = null;
                    SimpleContact tmpSimpleContact = null;
                    tmpCustomer = context.Customers.Where(c => c.Registration.PhoneNumber == number).FirstOrDefault();
                    if (tmpCustomer != null)
                    {
                        tmpSimpleContact.Email = tmpCustomer.Registration.Email;
                        tmpSimpleContact.FirstName = tmpCustomer.Person.Firstname;
                        tmpSimpleContact.IdCustomer = tmpCustomer.IdCustomer;
                        tmpSimpleContact.ImageUrl = "";
                        tmpSimpleContact.LastName = tmpCustomer.Person.Lastname;
                        tmpSimpleContact.Telephone = tmpCustomer.Registration.PhoneNumber;
                        registredContats.Add(tmpSimpleContact);
                    }
                }
            }
            catch (Exception e)
            {
                error = KoloWin.Utilities.ExceptionHelper.GetMessageFromException(e);
            }
            return registredContats;
        }
    }
}