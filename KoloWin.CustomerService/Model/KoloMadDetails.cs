using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class KoloMadDetails
    {
        public string Reference { get; set; }
        public int MadId { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public const string TerminalCode = "KOLO";
        public const int CashBoxId = 4298;
        public const int CashierId = 1700;
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int Amount { get; set; }
        public int Fee { get; set; }
        public int Tax { get; set; }
        public bool Everywhere { get; set; }
        public string CityCode { get; set; }
        public string Password { get; set; }
    }
}