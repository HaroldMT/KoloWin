using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace KoloWin.Utilities.Office
{
    public static class HtmlHelper
    {
        public static string GetText(string htmlText/*, out string error*/)
        {
            //error = "";
            try
            {
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(htmlText);
                var result = htmlDoc.DocumentNode.InnerText;
                return result;
            }
            catch (Exception /*ex*/)
            {
                //error = ex.Message;
            }
            return htmlText;
        }
    }
}
