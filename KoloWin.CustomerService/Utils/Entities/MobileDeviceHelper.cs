using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Util.Entities
{
    public static class MobileDeviceHelper
    {
        public static bool SameMobileIds(this Poco.MobileDevice myMobile, Poco.LoginAttempt loginAttempt)
        {
            if (myMobile == null | loginAttempt == null) return false;
            var result = myMobile.DeviceId == loginAttempt.DeviceId &&
                myMobile.LineNumber == loginAttempt.Number &&
                myMobile.SimOperator == loginAttempt.SimOperator &&
                myMobile.SimSerialNumber == loginAttempt.SimSerialNumber &&
                myMobile.SubscriberId == loginAttempt.SubscriberId;
            return result;
        }
    }
}