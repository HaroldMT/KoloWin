using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class KoloWsObject
    {
        public bool IsSucces { get; set; }
        public string ErrorMessage { get; set; }
        public string SerializedClass { get; set; }
    }
}