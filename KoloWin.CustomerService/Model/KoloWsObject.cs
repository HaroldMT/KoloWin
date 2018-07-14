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
        public T DataObject { get; set; }

        public KoloWsObject()
        {
            
        }

        public KoloWsObject(string error,T dataObject)
        {
            if(dataObject == null)
            {
                IsSucces = false;
                ErrorMessage = error;
            }else
            {
                IsSucces = true;
                ErrorMessage = "";
                DataObject = dataObject;
            }
        }


    }
}