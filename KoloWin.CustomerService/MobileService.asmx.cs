using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using KoloWin.CustomerService.Util;
using KoloWin.CustomerService.Util.Entities;
using KoloWin.Utilities;

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
    }
}
