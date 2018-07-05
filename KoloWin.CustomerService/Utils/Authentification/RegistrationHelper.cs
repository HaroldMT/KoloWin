using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

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

        public static bool RegistrationExists(string telephone , KoloAndroidEntities db)
        {
            return db.Registrations.Any(r => r.PhoneNumber == telephone);
        }

        public static Registration GetRegistration(string telephone, KoloAndroidEntities db)
        {
            return db.Registrations.FirstOrDefault(r => r.PhoneNumber == telephone);
        }

        public static bool RegistrationExists(int id, KoloAndroidEntities db)
        {
            return db.Registrations.Any(e => e.IdRegistration == id);
        }

        public static Customer CreateCustomer(Registration registration)
        {
            var timeCreated = DateTime.Now;
            var mobileDevice = new MobileDevice()
            {
                DeviceId = registration.DeviceId,
                LineNumber = registration.PhoneNumber,
                NetworkOperator = registration.OperatorDeviceSim,
                SimCountryIso = string.Empty,
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



        public static Registration DoRegistration(Registration registration, KoloAndroidEntities db,out string error)
        {
            error = "";
            try
            {
                if (!RegistrationHelper.RegistrationExists(registration.PhoneNumber, db))
                {
                    registration.RegistrationStatusCode = "NEEDCONFIRM";
                    registration.RegistrationDate = DateTime.Now;

                    var token = RegistrationHelper.RandomString(4);
                    registration.RegistrationToken = token.Substring(0, Math.Min(ExpirationDelay, token.Length));
                    registration.RegistrationTokenExpiryDate = DateTime.Now.AddMinutes(10);

                    db.Registrations.Add(registration);
                    db.SaveChanges();
                    return registration;
                }
                else
                {
                    var oldRegistration = RegistrationHelper.GetRegistration(registration.PhoneNumber, db);
                    oldRegistration.RegistrationStatusCode = "NEEDCONFIRM";
                    db.SaveChanges();
                    return oldRegistration;
                    //return new Registration() { IdRegistration = -10, RegistrationStatusCode = "Account arlready exists" };
                }
            }
            catch(Exception e)
            {
                error = ExceptionHelper.GetExceptionMessage(e);
            }
            var reg = new Registration() { IdRegistration = -100, RegistrationStatusCode = error };
            return reg;
        }

        public static Customer DoRegistrationConfirmation(Registration registration, KoloAndroidEntities db, out string error)
        {
            var confirmationTime = DateTime.Now;
            error = "";
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
                            Customer customer = db.Customers.Include("Person").FirstOrDefault(c => c.IdRegistration == reg.IdRegistration);
                            if (customer == null)
                            {
                                customer = RegistrationHelper.CreateCustomer(reg);
                                customer.Registration = reg;
                                db.Customers.Add(customer);
                            }
                            try
                            {
                                db.SaveChanges();
                            }
                            catch (DbEntityValidationException e)
                            {
                                error = ExceptionHelper.GetExceptionMessage(e);
                                error += string.Empty;
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
