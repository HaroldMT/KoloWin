using System;
using System.Collections.Generic;
using System.Linq;

namespace KoloWin.CustomerService.Util
{
    public class KoloEntities4Serialization : Poco.KoloEntities
    {
        public KoloEntities4Serialization()
        {
            Configuration.ProxyCreationEnabled = false;
        }
    }
}
