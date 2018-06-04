using System;
using System.Collections.Generic;
using System.Linq;

namespace KoloWin.CustomerService.Util
{
    public class KoloAndroidEntities4Serialization : KoloAndroidEntities
    {
        public KoloAndroidEntities4Serialization()
        {
            Configuration.ProxyCreationEnabled = false;
        }
    }
}
