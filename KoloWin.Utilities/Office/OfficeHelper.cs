using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace KoloWin.Utilities.Office
{
    public static class OfficeHelper
    {
        #region Static Properties

        public static CultureInfo CurrentCulture => CultureInfo.CurrentCulture;
        public static CultureInfo DateCultureInfo => CultureInfo.GetCultureInfo("en-US");
        public static string NumberSeparator => CurrentCulture.NumberFormat.NumberGroupSeparator;

        #endregion Static Properties

        #region Static Constructor

        #endregion Static Constructor

        #region Static Members

        public static string AmountToText(float chiffre)
        {
            var dix = false;
            var lettre = "";

            var reste = (int) (chiffre);

            for (var i = 1000000000; i >= 1; i /= 1000)
            {
                var y = reste/i;
                if (y != 0)
                {
                    var centaine = y/100;
                    var dizaine = (y - centaine*100)/10;
                    var unite = y - (centaine*100) - (dizaine*10);
                    switch (centaine)
                    {
                        case 0:
                            break;
                        case 1:
                            lettre += "cent ";
                            break;
                        case 2:
                            if ((dizaine == 0) && (unite == 0)) lettre += "deux cents ";
                            else lettre += "deux cent ";
                            break;
                        case 3:
                            if ((dizaine == 0) && (unite == 0)) lettre += "trois cents ";
                            else lettre += "trois cent ";
                            break;
                        case 4:
                            if ((dizaine == 0) && (unite == 0)) lettre += "quatre cents ";
                            else lettre += "quatre cent ";
                            break;
                        case 5:
                            if ((dizaine == 0) && (unite == 0)) lettre += "cinq cents ";
                            else lettre += "cinq cent ";
                            break;
                        case 6:
                            if ((dizaine == 0) && (unite == 0)) lettre += "six cents ";
                            else lettre += "six cent ";
                            break;
                        case 7:
                            if ((dizaine == 0) && (unite == 0)) lettre += "sept cents ";
                            else lettre += "sept cent ";
                            break;
                        case 8:
                            if ((dizaine == 0) && (unite == 0)) lettre += "huit cents ";
                            else lettre += "huit cent ";
                            break;
                        case 9:
                            if ((dizaine == 0) && (unite == 0)) lettre += "neuf cents ";
                            else lettre += "neuf cent ";
                            break;
                    } // endSwitch(centaine)

                    switch (dizaine)
                    {
                        case 0:
                            break;
                        case 1:
                            dix = true;
                            break;
                        case 2:
                            lettre += "vingt ";
                            break;
                        case 3:
                            lettre += "trente ";
                            break;
                        case 4:
                            lettre += "quarante ";
                            break;
                        case 5:
                            lettre += "cinquante ";
                            break;
                        case 6:
                            lettre += "soixante ";
                            break;
                        case 7:
                            dix = true;
                            lettre += "soixante ";
                            break;
                        case 8:
                            lettre += "quatre-vingt ";
                            break;
                        case 9:
                            dix = true;
                            lettre += "quatre-vingt ";
                            break;
                    } // endSwitch(dizaine)

                    switch (unite)
                    {
                        case 0:
                            if (dix) lettre += "dix ";
                            break;
                        case 1:
                            if (dix) lettre += "onze ";
                            else lettre += "un ";
                            break;
                        case 2:
                            if (dix) lettre += "douze ";
                            else lettre += "deux ";
                            break;
                        case 3:
                            if (dix) lettre += "treize ";
                            else lettre += "trois ";
                            break;
                        case 4:
                            if (dix) lettre += "quatorze ";
                            else lettre += "quatre ";
                            break;
                        case 5:
                            if (dix) lettre += "quinze ";
                            else lettre += "cinq ";
                            break;
                        case 6:
                            if (dix) lettre += "seize ";
                            else lettre += "six ";
                            break;
                        case 7:
                            if (dix) lettre += "dix-sept ";
                            else lettre += "sept ";
                            break;
                        case 8:
                            if (dix) lettre += "dix-huit ";
                            else lettre += "huit ";
                            break;
                        case 9:
                            if (dix) lettre += "dix-neuf ";
                            else lettre += "neuf ";
                            break;
                    } // endSwitch(unite)

                    switch (i)
                    {
                        case 1000000000:
                            if (y > 1) lettre += "milliards ";
                            else lettre += "milliard ";
                            break;
                        case 1000000:
                            if (y > 1) lettre += "millions ";
                            else lettre += "million ";
                            break;
                        case 1000:
                            lettre += "mille ";
                            break;
                    }
                } // end if(y!=0)
                reste -= y*i;
                dix = false;
            } // end for
            if (lettre.Length == 0) lettre += "zero";

            return lettre.Trim();
        }

        public static string GenerateCodeClientParticulier(string prefix, string typeClient = "P")
        {
            Thread.Sleep(10);
            const string chars = "012345678901234024680123456789";
            var random = new Random();
            var reference = new string(
                Enumerable.Repeat(chars, 10 - prefix.Length)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray());
            var result = string.Concat(prefix, typeClient, reference);
            return result;
        }

        public static string GenerateRandomString()
        {
            Thread.Sleep(10);
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray());
            return result;
        }

        public static string GenerateRandomString(string chars, int length)
        {
            Thread.Sleep(10);
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray());
            return result;
        }

        public static string GenerateReference(string prefix)
        {
            Thread.Sleep(10);
            const string chars = "0123456789ABCDEFGHJKMNPQRSTUVWXYZ0123456789";
            var random = new Random();
            var reference = new string(
                Enumerable.Repeat(chars, 10 - prefix.Length)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray());
            var result = string.Concat(prefix, reference);
            return result;
        }

        public static string GenerateUniqueId()
        {
            Thread.Sleep(10);
            var date = DateTime.Now;
            var uniqueId =
                $"{date.Year:00}{date.Month:00}{date.Day:00}{date.Hour:00}{date.Minute:00}{date.Second:00}{date.Millisecond:00}";
            //ex: 15041716425019

            return uniqueId;
        }

        public static string GenerateUniqueId(string prefix)
        {
            Thread.Sleep(10);
            var date = DateTime.Now;
            var year = date.Year.ToString();
            var subYear = year.Substring(year.Length - 2);
            var stringSystemDate =
                // ReSharper disable once InterpolatedStringExpressionIsNotIFormattable
                $"{subYear:00}{date.Month:00}{date.Day:00}{date.Hour:00}{date.Minute:00}{date.Second:00}";
            var uniqueId = string.Concat(prefix, stringSystemDate); //ex: CXY150417164250
            return uniqueId;

            //{ date.Millisecond:00}";
            //ex: 150417164250 //19

            //var dateDebut = new DateTime(date.Year, date.Month, date.Day);
            //var dateDiff = date - dateDebut;
            //var nbJours = dateDiff.Days;
            //var unique = $"{date.Year:00}{nbJours:00}{date.Hour:00}{date.Minute:00}{date.Second:00}";
        }

        //public static string GenerateUniqueCode(string prefix)
        //{
        //    Thread.Sleep(10);
        //    const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#";
        //    var ticks = DateTime.UtcNow.Ticks.ToString();
        //    var code = prefix;
        //    for (var i = 0; i < characters.Length; i += 2)
        //    {
        //        if ((i + 2) > ticks.Length) continue;
        //        var number = int.Parse(ticks.Substring(i, 2));
        //        if (number > characters.Length - 1)
        //        {
        //            var one = double.Parse(number.ToString().Substring(0, 1));
        //            var two = double.Parse(number.ToString().Substring(1, 1));
        //            code += characters[Convert.ToInt32(one)];
        //            code += characters[Convert.ToInt32(two)];
        //        }
        //        else
        //            code += characters[number];
        //    }
        //    return code;
        //}

        public static string GetFormattedStringForDisplayInBill(string key, string value, int leftSize = 30,
            int rightSize = 20)
        {
            var strResult = string.Concat(key.PadRight(leftSize, ' '), ": ", value.PadLeft(rightSize, ' '));
            return strResult;
        }

        public static string GetFormattedStringFromDecimal(decimal value)
        {
            return string.Format(CurrentCulture, "{0:N0}", value);
        }

        public static string GetFormattedStringFromReference(string value)
        {
            try
            {
                var result2 = value.Insert(value.Length - 4, "-")
                    .Insert(value.Length - 8, "-")
                    .Insert(value.Length - 12, "-");
                //var result = new Regex(@"(\d{3})(\d{4})(\d{4})(\d{4})").Replace(value, "$1 $2 $3 $4");
                //var result1 = new Regex(@"(\d{3})(\d{3})(\d{3})(\d{3})(\d{3})").Replace(value, "$1 $2 $3 $4 $5");
                return result2;
            }
            catch (Exception)
            {
                return value;
            }
        }

        public static string GetCityCodeFromCashierCode(string prefix)
        {
            var i = prefix.IndexOfAny(new[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'});
            var cityCode = prefix.Substring(0, i);
            return cityCode;
        }
        #endregion Static Members
    }
}