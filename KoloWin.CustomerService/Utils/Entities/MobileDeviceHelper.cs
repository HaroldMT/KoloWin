using System;
using System.Collections.Generic;
using System.Linq;

namespace KoloWin.CustomerService.Util.Entities
{
    public static class MobileDeviceHelper
    {
        public static bool SameMobileIds(this MobileDevice myMobile, LoginAttempt loginAttempt)
        {
            if (myMobile == null | loginAttempt == null)
            {
                return false;
            }
            var result = myMobile.DeviceId == loginAttempt.DeviceId &&
                myMobile.LineNumber == loginAttempt.Number &&
                myMobile.SimOperator == loginAttempt.SimOperator &&
                myMobile.SimSerialNumber == loginAttempt.SimSerialNumber &&
                myMobile.SubscriberId == loginAttempt.SubscriberId;
            return true; // A modifier
        }

        public static bool isSameMobileDevices(MobileDevice c, MobileDevice mobileDevice)
        {
            if (c == null | mobileDevice == null)
            {
                return false;
            }
            var result = c.IdCustomer == mobileDevice.IdCustomer && c.IdMobileDevice == mobileDevice.IdMobileDevice && c.DeviceId == mobileDevice.DeviceId && c.isActive == mobileDevice.isActive && c.LineNumber == mobileDevice.LineNumber && c.NetworkCountryIso == mobileDevice.NetworkCountryIso && c.NetworkOperator == mobileDevice.NetworkOperator && c.NetworkOperatorName == mobileDevice.NetworkOperatorName && c.NetworkType == mobileDevice.NetworkType && c.PhoneType == mobileDevice.PhoneType && c.SimCountryIso == mobileDevice.SimCountryIso && c.SimOperator == mobileDevice.SimOperator && c.SimOperatorName == mobileDevice.SimOperatorName && c.SimSerialNumber == mobileDevice.SimSerialNumber && c.SimState == mobileDevice.SimState && c.SubscriberId == mobileDevice.SubscriberId;
            return result; // A modifier
        }



        public static MobileDevice InsertMobileDevice(ref MobileDevice myMobile, KoloAndroidEntities4Serialization db, out string error )
        {
            error = "";
            try
            {
                db.MobileDevices.Add(myMobile);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                error = ExceptionHelper.GetExceptionMessage(e);
            }
            return myMobile;
        }


    }
}
