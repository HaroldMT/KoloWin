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
            IsSucces = false;
            ErrorMessage = "Unkown error";
            DataObject = default(T);
        }

        public KoloWsObject(string error,T dataObject)
        {
            IsSucces = string.IsNullOrEmpty(error);
            ErrorMessage = error;
            DataObject = dataObject;
            //if(dataObject == null)
            //{
            //    IsSucces = false;
            //    ErrorMessage = error;
            //}else
            //{
            //    IsSucces = true;
            //    ErrorMessage = "";
            //    DataObject = dataObject;
            //}
        }

        public KoloWsObject(string error)
        {
            IsSucces = false;
            ErrorMessage = error;
            DataObject = default(T);
        }

        public KoloWsObject(bool succes, string error, T dataObject)
        {
            IsSucces = succes;
            ErrorMessage = error;
            DataObject = dataObject;
        }

        public KoloWsObject(T dataObject)
        {
            DataObject = dataObject;
            ErrorMessage = "";
            IsSucces = true;
        }
    }
}