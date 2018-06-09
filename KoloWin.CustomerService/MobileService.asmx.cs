using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using KoloWin.CustomerService.Util;
using KoloWin.CustomerService.Util.Entities;
using KoloWin.Utilities;
using KoloWin.CustomerService.Utils.Entities;

namespace KoloWin.CustomerService
{
    /// <summary>
    /// Summary description for MobileService
    /// </summary>
    [WebService(Namespace = "http://kolo.cyberix.fr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]


    public class MobileService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public RefGender GetRefGender()
        {
            var refGender = new RefGender()
            { GenderCode = "M",
                GenderDescription = "Male", };


            return refGender;
        }

        [WebMethod]
        public void CreatePerson(string jsonPerson)
        {
            var person = SerializationHelper.DeserializeFromJsonString<Person>(jsonPerson);
            var Context = new KoloAndroidEntities();
            Context.People.Add(person);
            Context.Dispose();
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public MyRefTypes TestService(MyRefTypes myRefTypes)
        {
            return myRefTypes;
        }

        [WebMethod]
        public MobileDevice InsertMobileDevice(string jsonMobileDevice)
        {
            string error = "";
            MobileDevice mobileDevice = SerializationHelper.DeserializeFromJsonString<MobileDevice>(jsonMobileDevice) as MobileDevice;
            var context = new KoloAndroidEntities4Serialization();
            mobileDevice = MobileDeviceHelper.InsertMobileDevice(ref mobileDevice, context, out  error);
            context.Dispose();
            return mobileDevice;
        }



        [WebMethod]
        public string GetCustomerByIdCustomerAndNumber(int idCustomer, string number)
        {
            var Context = new KoloAndroidEntities();
            string error = "";
            var outCustomer = CustomerHelper.GetCustomerByIdCustomerAndNumber(idCustomer, number, Context,out error);
            Context.Dispose();
            return SerializationHelper.SerializeToJson(outCustomer);
        }

        [WebMethod]
        public string GetCustomerContacts(int idCustomer, string intContacts)
        {
            var Context = new KoloAndroidEntities();
            string error = "";
            HashSet<string> contacts = SerializationHelper.DeserializeFromJsonString<HashSet<string>>(intContacts);
            //HashSet<Registration> registredContacts = CustomerHelper.GetCustomerContacts(idCustomer, contacts, Context, out error);
            Context.Dispose();
            return SerializationHelper.SerializeToJson("");
        }




    }
}
