using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Util
{
    public class KoloEntities4Serialization : Poco.KoloEntities
    {
        public KoloEntities4Serialization()
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
    }
}