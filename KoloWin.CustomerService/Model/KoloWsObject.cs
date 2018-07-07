using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoloWin.CustomerService.Model
{
    public class KoloWsObject<T>
    {
        public bool IsSucces { get; set; }
        public string ErrorMessage { get; set; }
        public T t { get; set; }
        
        public KoloWsObject(T t)
        {

        }

    }
}