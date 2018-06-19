﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace KoloWin.CustomerService
{
    /// <summary>
    /// Summary description for KolOPartVice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KolOPartVice : System.Web.Services.WebService
    {

        #region Kolo Eneo Methods

        [WebMethod]
        public string DoPayEneoBill(string jsonBillNumber, string jsonCustomer)
        {
            string error = "";
            return "";
        }

        
        [WebMethod]
        public string GetEneoBillByBillNumber(string jsonBillNumber)
        {
            string error = "";
            return "";
        }


        [WebMethod]
        public string GetEneoBillByBillAccount(string jsonBillAccount)
        {
            string error = "";
            return "";
        }

        #endregion


        #region Kolo MAD Methods

        [WebMethod]
        public string DoSendMad(string jsonBillNumber, string jsonCustomer)
        {
            string error = "";
            return "";
        }


        [WebMethod]
        public string DoRecieveMad(string jsonBillNumber)
        {
            string error = "";
            return "";
        }


        [WebMethod]
        public string GetMadByBillReference(string jsonReference)
        {
            string error = "";
            return "";
        }

        #endregion


    }
}
