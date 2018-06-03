using System;
using System.Security.Cryptography;

namespace KoloWin.CustomerService.Util
{
    public static class PasswordHasher
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        public static string GetNewPassword(string password, bool hash)
        {
            var pwd = hash ? HashPassword(password, string.Empty) : password;
            return pwd;
        }

        public static string GetNewPassword()
        {
            var pwd = System.Web.Security.Membership.GeneratePassword(8, 1);
            pwd = HashPassword(pwd, string.Empty);
            return pwd;
        }

        public static Tuple<string, string> HashPassword(string password)
        {
            var saltBytes = GetNewSalt(64);
            var salt = Convert.ToBase64String(saltBytes);
            var resultPwd = HashPassword(password, salt);
            var result = Tuple.Create(resultPwd, salt);
            return result;
        }

        public static bool VerifyPassword(LoginAttempt loginAttempt, CustomerLogin customerLogin)
        {
            var pwdOk = VerifyHashedPassword(customerLogin.Pwd, loginAttempt.Pwd, customerLogin.PwdSalt);
            return pwdOk;
        }

        public static bool VerifyHashedPassword(string hashedPassword, string providedPassword, string salt)
        {
            var hashedUserPwd = HashPassword(providedPassword, salt);
            var result = hashedPassword.Equals(hashedUserPwd, StringComparison.Ordinal);
            return result;
        }

        private static byte[] GetNewSalt(int size)
        {
            var randomBytes = new byte[size];
            rngCsp.GetBytes(randomBytes);
            return randomBytes;
        }

        private static string HashPassword(string password, string salt)
        {
            var bytes = new System.Text.UTF8Encoding().GetBytes(salt + password);

            byte[] hashBytes;
            using (var algorithm = new SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            var resultPwd = Convert.ToBase64String(hashBytes);
            return resultPwd;
        }
    }
}
