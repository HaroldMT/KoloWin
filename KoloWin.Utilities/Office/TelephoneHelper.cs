using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloWin.Utilities.Office
{
    public static class TelephoneHelper
    {
        public static bool IsValidTelephoneNumber(string number)
        {
            if (number == "") return true;
            //if (number.Length == 8) number = "6" + number;
            if (number.Length != 9) return false;
            return number.StartsWith("6") || number.StartsWith("2") || number.StartsWith("3");
        }
    }
}
