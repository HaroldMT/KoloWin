using KoloWin.CustomerService.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
    public static class ExternalAccountHelper
    {
        
        public static ExternalAccount AddExternalAccount(ref ExternalAccount externalAccount , out string error)
        {
            error = "";
            KoloAndroidEntities context = new KoloAndroidEntities();
            try
            {
                context.ExternalAccounts.Add(externalAccount);
                context.SaveChanges();
                context.Dispose();
                return externalAccount;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            return null;
        }
        
        public static List<ExternalAccount> GetExternalAccounts(int idCustomer, out string error)
        {
            error = "";
            var context = new KoloAndroidEntities();
            List<ExternalAccount> externalAccounts = new List<ExternalAccount>();
            try
            {
                externalAccounts = context.ExternalAccounts.Where(e => e.IdCustomer == idCustomer).ToList();
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            return externalAccounts;
        }


        public static ExternalAccount UpdateExternalAccount(ExternalAccount externalAccount, out string error)
        {
            error = "";
            KoloAndroidEntities context = new KoloAndroidEntities();
            try
            {
                ExternalAccount tmp = context.ExternalAccounts.FirstOrDefault(e => e.IdExternalAccount == externalAccount.IdExternalAccount);
                tmp = externalAccount;
                context.SaveChanges();
                context.Dispose();
                return tmp;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            return null;
        }
        
        public static bool RemoveExternalAccount(ExternalAccount externalAccount, out string error)
        {
            error = "";
            KoloAndroidEntities context = new KoloAndroidEntities();
            try
            {
                var tmp =  context.ExternalAccounts.Remove(externalAccount);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            return false;
        }

        
        public static List<ExternalAccountHistory> GetExternalAccountsHistoriesGlobal(int idCustomer, out string error)
        {
            error = "";
            List<ExternalAccountHistory> externalAccountHistories = new List<ExternalAccountHistory>();
            KoloAndroidEntities context = new KoloAndroidEntities();
            try
            {
                List<ExternalAccount> externalAccounts = GetExternalAccounts(idCustomer, out error);
                if (externalAccounts != null)
                {
                    foreach(ExternalAccount externalAccount in externalAccounts)
                        externalAccountHistories.AddRange(context.ExternalAccountHistories.Where(e => e.IdExternalAccount == externalAccount.IdExternalAccount).ToList());
                    context.SaveChanges();
                    context.Dispose();
                    return externalAccountHistories;
                }
                else
                    return null;
                
            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            return null;
        }




        public static List<ExternalAccountHistory> GetExternalAccountsHistoriesSpecific(ExternalAccount externalAccount, out string error)
        {
            error = "";
            KoloAndroidEntities context = new KoloAndroidEntities();
            try
            {
                List<ExternalAccountHistory> externalAccountHistories = new List<ExternalAccountHistory>();
                externalAccountHistories = context.ExternalAccountHistories.Where(e => e.IdExternalAccount == externalAccount.IdExternalAccount).ToList();
                context.SaveChanges();
                context.Dispose();
                return externalAccountHistories;

            }
            catch (Exception ex)
            {
                error = ExceptionHelper.GetExceptionMessage(ex);
            }
            return null;
        }


    }
}