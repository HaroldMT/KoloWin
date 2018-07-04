using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;

namespace KoloWin.CustomerService.Utils.General
{
    public static class KoloConstants
    {
        public static class Operation
        {
            public enum Category
            {
                [Description("TRANSFERT_SEND_ACCOUNT_TO_ACCOUNT")]
                SENDA2A,
                [Description("TRANSFERT_RECIEVE_ACCOUNT_TO_ACCOUNT")]
                RECVA2A,
                [Description("TRANSFERT_SEND_ACCOUNT_TO_CASH")]
                SENDA2C,
                [Description("TRANSFERT_RECIEVE_ACCOUNT_TO_CASH")]
                RECVA2C,
                [Description("TRANSFERT_SEND_CASH_TO_ACCOUNT")]
                SENDC2A,
                [Description("TRANSFERT_RECIEVE_CASH_TO_ACCOUNT")]
                RECVC2A,
                [Description("TRANSFERT_SEND_CASH_TO_CASH")]
                SENDC2C,
                [Description("TRANSFERT_RECIEVE_CASH_TO_CASH")]
                RECVC2C,
                [Description("TRANSFERT_DEPOSIT")]
                DEPOSIT,
                [Description("TRANSFERT_RECIEVE_WITHDRAWAL")]
                WITHDRAWAL,
                [Description("ENEO_BILL_PAY")]
                PAYENEOBILL,
                [Description("TOPUP_ORANGE")]
                TOPUPORANGE,
                [Description("TOPUP_MTN")]
                TOPUPMTN,
                [Description("TOPUP_NEXTTEL")]
                TOPUPNEXTTEL,
                [Description("TOPUP_YOOMEE")]
                TOPUPYOOMEE,
                [Description("TOPUP_CAMTEL")]
                TOPUPCAMTEL
            }
            
            public enum Status
            {
                [Description("TRANSFERT_CANCELED")]
                CANCELED,
                [Description("TRANSFERT_COMPLETED")]
                COMPLETED, 
                [Description("TRANSFERT_CONFIRM_PENDING")]
                CONFIRM_PENDING, 
                [Description("TRANSFERT_RECEIVE_PENDING")]
                RECEIVE_PENDING
            }

        }
        
        public static class EneoExTermAuth
        {
            public static string KOLO_ENEO_CODETERM = "KOLO";
            public static string KOLO_ENEO_CODEUSER = "KOLO";
            public static string KOLO_ENEO_PASSTERM = "KOLO";
            public static string KOLO_ENEO_PASSUSER = "KOLO";

        }
        
        public static string GetEnumDescription(Enum en)
        {
            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return en.ToString();
        }

    }
}