using KoloWin.CustomerService.Util.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KoloWin.CustomerService.Util
{
    public static class LoginHelper
    {
        public static int DoLogin(ref LoginAttempt loginAttempt, KoloAndroidEntities db, out string error)
        {
            error = "";
            var refResult = new RefResult() { ResultCode = "FAIL" };
            var loginTime = DateTime.Now;
            var idCustomer = loginAttempt.IdCustomer;
            var customer = db.Customers
                .Include("MobileDevices").Include("Person").Include("Registration")
                .FirstOrDefault(c => c.IdCustomer == idCustomer);
            if (customer != null)
            {
                var customerLogin = db.CustomerLogins.FirstOrDefault(c => c.IdCustomer == customer.IdCustomer);
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
                                error = ExceptionHelper.GetExceptionMessage(ex);
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


        public static bool DeleteLoginAttempt(int id, KoloAndroidEntities db)
        {
            var loginAttempt = db.LoginAttempts.FirstOrDefault(l => l.IdCustomer == id);
            if (loginAttempt == null)
            {
                return false;
            }
            db.LoginAttempts.Remove(loginAttempt);
            db.SaveChanges();
            return true;
        }

        public static bool LoginAttemptExists(int id, KoloAndroidEntities db)
        {
            return db.LoginAttempts.Count(e => e.IdLoginAttempt == id) > 0;
        }

        public static bool CustomerLoginExists(int id, KoloAndroidEntities db)
        {
            return db.CustomerLogins.Count(e => e.IdCustomer == id) > 0;
        }
    }
}
