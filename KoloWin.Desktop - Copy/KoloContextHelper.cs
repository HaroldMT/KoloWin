using KoloWin.Desktop.KoloGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloWin.Desktop
{
    public static class KoloContextHelper
    {
        private const string Url = "http://192.168.1.10/KoloWin.Web/KoloWcfService.svc/";

        private static Uri koloUri;
        private static KoloEntities context;
        public static Uri KoloUri
        {
            get
            {
                return koloUri ?? (koloUri = new Uri(Url));
            }
            set
            {
                koloUri = value ?? new Uri(Url);
            }
        }
        public static KoloEntities Context
        {
            get
            {
                return context ?? (context = new KoloGateway.KoloEntities(KoloUri));
            }

            set
            {
                context = value ?? new KoloEntities(KoloUri);
            }
        }
    }
}
