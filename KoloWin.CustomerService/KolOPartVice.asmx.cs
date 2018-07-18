﻿using KoloWin.CustomerService.Model;
using KoloWin.CustomerService.Util;
using KoloWin.CustomerService.Utils.General;
using KoloWin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace KoloWin.CustomerService
{
    /// <summary>
    /// Summary description for KolOPartVice
    /// </summary>
    [WebService(Namespace = "http://kolo.cyberix.fr/")]
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
            var reference = EneoHelper.DoPayENEO(jsonBillNumber, jsonCustomer,out error);
            KoloWsObject<string> koloWs = new KoloWsObject<string>(error, reference);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }
        
        [WebMethod]
        public string GetEneoBillByBillNumber(string jsonBillNumber)
        {
            string error = "";
            List<EneoBillDetails> eBDs = EneoHelper.GetEneoBillByBillNumber(jsonBillNumber,out error);
            KoloWsObject<List<EneoBillDetails>> koloWs = new KoloWsObject<List<EneoBillDetails>>(error, eBDs);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }
        
        [WebMethod]
        public string GetEneoBillsByBillAccount(string jsonBillAccount)
        {
            string error = "";
            List<EneoBillDetails> eBDs = EneoHelper.GetEneoBillsByBillAccount(jsonBillAccount, out error);
            KoloWsObject<List<EneoBillDetails>> koloWs = new KoloWsObject<List<EneoBillDetails>>(error, eBDs);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }

        #endregion
        


        #region Kolo MAD Methods
        
        [WebMethod]
        public string DoSendMad(string jsonKoloMadDetails)
        {
            string error = "";
            KoloMadDetails koloMadDetails = SerializationHelper.DeserializeFromJsonString<KoloMadDetails>(jsonKoloMadDetails);
            Madhelper.DoSendMad(ref koloMadDetails, out error);
            KoloWsObject<KoloMadDetails> koloWs = new KoloWsObject<KoloMadDetails>(error, koloMadDetails);
            var result = SerializationHelper.SerializeToJson(koloWs);
            return result;
        }

        #endregion
        

        #region TopUp Methods


        [WebMethod]
        public string DoTopUp(string jsonTopUp)
        {
            string error = "";
            TopUpDetails topDetails = SerializationHelper.DeserializeFromJsonString<TopUpDetails>(jsonTopUp);
            var success = TopUpHelper.DoTopUp(topDetails, out error);
            return "";
        }


        #endregion

    }
}