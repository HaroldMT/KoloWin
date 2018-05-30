using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace KoloWin.CustomerService.Util
{
    public static class ExceptionHelper
    {
        public static string GetExceptionMessage(Exception e)
        {
            string msg;
            if (e.InnerException == null) msg = e.Message;
            else msg = GetExceptionMessage(e.InnerException);
            return msg;
        }
    }
}
