using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.Entities
{
    public class CustomerHelper
    {

        public static Customer GetCustomerByIdCustomerAndNumber(int idCustomer, string number, KoloAndroidEntities context, out string error)
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

        
        public static HashSet<Customer> GetCustomerContacts(int idCustomer, HashSet<string> contacts, KoloAndroidEntities context, out string error)
        {
            error = "";
            HashSet<Customer> registredContats = new HashSet<Customer>();
            Customer customer = context.Customers.Find(idCustomer);
            try
            {
                foreach(string number in contacts)
                {
                    Customer tmpCustomer = null;
                    tmpCustomer = context.Customers.Where(c => c.Registration.PhoneNumber == number).FirstOrDefault();
                    if (tmpCustomer != null)
                    {
                        customer.
                        registredContats.Add(tmpCustomer);
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