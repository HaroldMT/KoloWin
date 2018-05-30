using KoloWin.Poco;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Util
{
    public static class RegistrationHelper
    {
        private const int ExpirationDelay = 1800;

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXY1234567890";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static bool RegistrationExists(string telephone , KoloEntities db)
        {
            return db.Registrations.Count(r => r.PhoneNumber == telephone) > 0;
        }

        public static bool RegistrationExists(int id, KoloEntities db)
        {
            return db.Registrations.Count(e => e.IdRegistration == id) > 0;
        }
        
        public static Customer CreateCustomer(Registration registration)
        {
            var timeCreated = DateTime.Now;
            var mobileDevice = new MobileDevice()
            {
                DeviceId = registration.DeviceId,
                LineNumber = registration.PhoneNumber,
                NetworkOperator = registration.OperatorDeviceSim,
                SimCountryIso = "",
                SimOperator = registration.OperatorDeviceSim,
                SimSerialNumber = registration.SimSerialNumber,
                SubscriberId = registration.SimSubscriberId
            };
            var person = new Person()
            {
                DateOfBirth = registration.Dob,
                DateCreated = timeCreated,
                Firstname = registration.FirstName,
                Lastname = registration.LastName,
            };
            PasswordHasher.GetNewPassword(registration.Pwd, false);
            var pwd = PasswordHasher.HashPassword(registration.Pwd);
            var customerLogin = new CustomerLogin()
            {
                EmailAddress = registration.Email,
                LoginStatusCode = "Enabled",
                EmailAddressVerified = false,
                Number = registration.PhoneNumber,
                Pwd = pwd.Item1,
                PwdSalt = pwd.Item2,
            };
            var customer = new Customer()
            {
                Balance = 0,
                CurrencyCode = "XAF",
                CustomerTypeCode = "Standard",
                DateCreated = timeCreated,
                MobileDevice = mobileDevice,
                Person = person,
                IdRegistration = registration.IdRegistration,
                CustomerLogin = customerLogin,
            };
            return customer;
        }



        public static Registration DoRegistration(Registration registration, KoloEntities db)
        {

            if (!RegistrationHelper.RegistrationExists(registration.PhoneNumber, db))
            {
                registration.RegistrationStatusCode = "NEEDCONFIRM";
                registration.RegistrationDate = DateTime.Now;
                //string token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
                string token = RegistrationHelper.RandomString(4);
                registration.RegistrationToken = token.Substring(0, Math.Min(ExpirationDelay, token.Length));
                registration.RegistrationTokenExpiryDate = DateTime.Now.AddMinutes(10);

                db.Registrations.Add(registration);
                db.SaveChanges();
                return registration;
            }
            else
            {
                var reg = new Registration() { IdRegistration = -10, RegistrationStatusCode = "Account already exists" };
                return reg;
            }
        }

        public static Customer DoRegistrationConfirmation(Registration registration, KoloEntities db)
        {
            var confirmationTime = DateTime.Now;
            // On a pris le token au lieu de l'ID mais on peut aussi ajouter tous les autres parametres qui nous interessent
            var reg = db.Registrations.Find(registration.IdRegistration);
            if (reg != null)
            {
                if (reg.RegistrationTokenExpiryDate.HasValue)
                {
                    if (reg.RegistrationToken.Equals(registration.RegistrationToken))
                    {
                        if (reg.RegistrationTokenExpiryDate.Value >= confirmationTime)
                        {
                            reg.RegistrationStatusCode = "COMPLETED";
                            reg.RegistrationConfirmDate = DateTime.Now;
                            var customer = RegistrationHelper.CreateCustomer(reg);
                            customer.Registration = reg;
                            /*  reg.Customers.Add(customer); Venant de l'ancien modes   */
                            db.Customers.Add(customer);
                            try
                            {
                                db.SaveChanges();
                            }
                            catch (DbEntityValidationException e)
                            {
                                string error = ExceptionHelper.GetExceptionMessage(e);
                                error += "";
                            }
                            return customer;
                        }
                        return new Customer() { IdCustomer = -40 };
                    }
                    return new Customer() { IdCustomer = -30 };
                }
                return new Customer() { IdCustomer = -20 };
            }
            return new Customer() { IdCustomer = -10 };
        }


    }
}