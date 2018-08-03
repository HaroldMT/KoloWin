using KoloWin.CustomerService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.Entities
{
    public static class CustomerHelper
    {

        public static Customer FindCustomerByIdCustomerAndNumber(int idCustomer, string number, KoloAndroidEntities context, out string error)
        {
            error = "";
            Customer c = null;
            try
            {
                if (idCustomer > 0)
                    c = context.Customers.FirstOrDefault(co => co.IdCustomer == idCustomer);
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
                        //tmpSimpleContact.ImageUrl = "";
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

        public static void UpdateCustomerAccount(ref Customer outCustomer, Customer inCustomer,ref MobileDevice mobile, KoloAndroidEntities context, out string error)
        {
            error = "";

            outCustomer.Balance = inCustomer.Balance;
            outCustomer.BalanceUnavailable = inCustomer.BalanceUnavailable;
            outCustomer.CurrencyCode = inCustomer.CurrencyCode ?? outCustomer.CurrencyCode;
            outCustomer.CustomerTypeCode = inCustomer.CustomerTypeCode ?? outCustomer.CustomerTypeCode;
            outCustomer.EneoContractNo = inCustomer.EneoContractNo ?? outCustomer.EneoContractNo;
            outCustomer.EneoPercentage = inCustomer.EneoPercentage ?? outCustomer.EneoPercentage;
            outCustomer.GravityCode = inCustomer.GravityCode ?? outCustomer.GravityCode;
            outCustomer.GravityId = inCustomer.GravityId ?? outCustomer.GravityId;
            outCustomer.GravityPercentage = inCustomer.GravityPercentage ?? outCustomer.GravityPercentage;
            outCustomer.TopUpPercentage = inCustomer.TopUpPercentage ?? outCustomer.TopUpPercentage;
            outCustomer.Person.CountryCode = inCustomer.Person.CountryCode ?? outCustomer.Person.CountryCode;
            outCustomer.Person.DateOfBirth = inCustomer.Person.DateOfBirth ?? outCustomer.Person.DateOfBirth;
            outCustomer.Person.Firstname = inCustomer.Person.Firstname ?? outCustomer.Person.Firstname;
            outCustomer.Person.GenderCode = inCustomer.Person.GenderCode ?? outCustomer.Person.GenderCode;
            outCustomer.Person.Lastname = inCustomer.Person.Lastname ?? outCustomer.Person.Lastname;
            outCustomer.Person.MaritalStatusCode = inCustomer.Person.MaritalStatusCode ?? outCustomer.Person.MaritalStatusCode;
            outCustomer.Person.Middlename = inCustomer.Person.Middlename ?? outCustomer.Person.Middlename;

            if(mobile != null)
            {
                mobile.DeviceId = inCustomer.MobileDevices[0].DeviceId ?? mobile.DeviceId;
                mobile.LineNumber = inCustomer.MobileDevices[0].LineNumber ?? mobile.LineNumber;
                mobile.NetworkCountryIso = inCustomer.MobileDevices[0].NetworkCountryIso ?? mobile.NetworkCountryIso;
                mobile.NetworkOperator = inCustomer.MobileDevices[0].NetworkOperator ?? mobile.NetworkOperator;
                mobile.NetworkOperatorName = inCustomer.MobileDevices[0].NetworkOperatorName ?? mobile.NetworkOperatorName;
                mobile.NetworkType = inCustomer.MobileDevices[0].NetworkType ?? mobile.NetworkType;
                mobile.PhoneType = inCustomer.MobileDevices[0].PhoneType ?? mobile.PhoneType;
                mobile.SimCountryIso = inCustomer.MobileDevices[0].SimCountryIso ?? mobile.SimCountryIso;
                mobile.SimOperator = inCustomer.MobileDevices[0].SimOperator ?? mobile.SimOperator;
                mobile.SimOperatorName = inCustomer.MobileDevices[0].SimOperatorName ?? mobile.SimOperatorName;
                mobile.SimSerialNumber = inCustomer.MobileDevices[0].SimSerialNumber ?? mobile.SimSerialNumber;
                mobile.SimState = inCustomer.MobileDevices[0].SimState ?? mobile.SimState;
                mobile.SubscriberId = inCustomer.MobileDevices[0].SubscriberId ?? mobile.SubscriberId;
            }



        }

    }
}