using System.Web.Services;

namespace KoloWin.CustomerService
{
    [WebService(Namespace = "http://kolo.cyberix.fr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
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
        public string GetEneoBillsByBillAccount(string jsonBillAccount)
        {
            string error = "";
            return "";
        }

        #endregion Kolo Eneo Methods

        #region Kolo MAD Methods

        [WebMethod]
        public string DoRecieveMad(string jsonMad)
        {
            string error = "";
            return "";
        }

        [WebMethod]
        public string DoSendMad(string jsonMad)
        {
            string error = "";
            return "";
        }

        [WebMethod]
        public string GetMadByBordereau(string jsonBordereau)
        {
            string error = "";
            return "";
        }

        [WebMethod]
        public string GetMadByCustomer(string jsonCustomer)
        {
            string error = "";
            return "";
        }

        [WebMethod]
        public string GetMadByReference(string jsonReference)
        {
            string error = "";
            return "";
        }

        #endregion Kolo MAD Methods

        #region TopUp Methods

        [WebMethod]
        public string DoTopUp(string jsonTopUp)
        {
            string error = "";
            return "";
        }

        #endregion TopUp Methods
    }
}