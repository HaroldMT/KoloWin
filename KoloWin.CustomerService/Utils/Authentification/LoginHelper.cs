using KoloWin.CustomerService.Util.Entities;
using KoloWin.Poco;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KoloWin.CustomerService.Util
{
    public static class LoginHelper
    {
        public static int DoLogin(LoginAttempt loginAttempt, KoloEntities db)
        {
            var refResult = new RefResult() { ResultCode = "FAIL" };
            var loginTime = DateTime.Now;
            var customer = db.Customers.Find(loginAttempt.IdCustomer);
            if (customer != null)
            {
                var customerLogin = db.CustomerLogins.Find(customer.IdCustomer);
                loginAttempt.LoginTime = loginTime;
                if (customerLogin != null)
                {
                    var mobile = db.MobileDevices.FirstOrDefault(md => md.IdMobileDevice == customer.IdCustomer);
                    if (MobileDeviceHelper.SameMobileIds(mobile, loginAttempt) == true)
                    {
                        if (PasswordHasher.VerifyPassword(loginAttempt, customerLogin))
                        {
                            loginAttempt.ResultCode = "SUCCESS";
                            loginAttempt.IdCustomer = customer.IdCustomer;
                            db.LoginAttempts.Add(loginAttempt);
                            try
                            {
                                db.SaveChanges();
                                refResult.ResultCode = "SUCCESS";
                                return loginAttempt.IdLoginAttempt;
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }
            }
            loginAttempt.ResultCode = "FAIL";
            db.LoginAttempts.Add(loginAttempt);
            db.SaveChanges();
            return loginAttempt.IdLoginAttempt;
        }


        public static bool DeleteLoginAttempt(int id, KoloEntities db)
        {
            var loginAttempt = db.LoginAttempts.Find(id);
            if (loginAttempt == null)
            {
                return false;
            }
            db.LoginAttempts.Remove(loginAttempt);
            db.SaveChanges();
            return true;
        }

        public static bool LoginAttemptExists(int id, KoloEntities db)
        {
            return db.LoginAttempts.Count(e => e.IdLoginAttempt == id) > 0;
        }

        public static bool CustomerLoginExists(int id, KoloEntities db)
        {
            return db.CustomerLogins.Count(e => e.IdCustomer == id) > 0;
        }
    }
}
