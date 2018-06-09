using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
    public static class KoloConstants
    {
        public static string TRANSFERT_ACCOUNT_TO_ACCOUNT = "TRANSFERTA2A";
        public static string TRANSFERT_ACCOUNT_TO_CASH = "TRANSFERTA2C";
        public static string TRANSFERT_CASH_TO_ACCOUNT = "TRANSFERTC2A";
        public static string TRANSFERT_CASH_TO_CASH = "TRANSFERTC2C";

        public static string TRANSFERT_TYPE_SEND_ACCOUNT_TO_ACCOUNT = "SENDA2A";
        public static string TRANSFERT_TYPE_RECIEVE_ACCOUNT_TO_ACCOUNT = "RECVA2A";
        public static string TRANSFERT_TYPE_SEND_ACCOUNT_TO_CASH = "SENDA2C";
        public static string TRANSFERT_TYPE_RECIEVE_ACCOUNT_TO_CASH = "RECVA2C";
        public static string TRANSFERT_TYPE_SEND_CASH_TO_ACCOUNT = "SENDC2A";
        public static string TRANSFERT_TYPE_RECIEVE_CASH_TO_ACCOUNT = "RECVC2A";
        public static string TRANSFERT_TYPE_SEND_CASH_TO_CASH = "SENDC2C";
        public static string TRANSFERT_TYPE_RECIEVE_CASH_TO_CASH = "RECVC2C";
        public static string TRANSFERT_TYPE_DEPOSIT = "DEPOSIT";
        public static string TRANSFERT_TYPE_RECIEVE_WITHDRAWAL = "WITHDRAWAL";

        public static string TRANSFERT_STATUS_CODE_CANCELED = "CANCELED";
        public static string TRANSFERT_STATUS_CODE_COMPLETED = "COMPLETED";
        public static string TRANSFERT_STATUS_CODE_CONFIRM_PENDING = "CONFIRM_PENDING";
        public static string TRANSFERT_STATUS_CODE_RECEIVE_PENDING = "RECEIVE_PENDING"; 





    }
}