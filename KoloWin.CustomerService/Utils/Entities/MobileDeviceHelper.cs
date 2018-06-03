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
            return result;
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
