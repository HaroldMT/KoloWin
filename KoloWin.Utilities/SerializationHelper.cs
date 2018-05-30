using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonFormatting = Newtonsoft.Json.Formatting;

namespace KoloWin.Utilities
{
    public static class SerializationHelper
    {
        private static JsonSerializerSettings CreateJsonSettings()
        {
            var idtConverter = new IsoDateTimeConverter
            {
                DateTimeStyles = DateTimeStyles.AssumeLocal,
                Culture = CultureInfo.InvariantCulture,
                DateTimeFormat = "yyyy-MM-dd hh:mm:ss"
            };
            //{
                //"IdOuvertureAgence": 0,
                //"DateComptable": "2016-05-18T00:00:00 01:00",
                //"IdAgence": 1106,
                //"IdCaisse": 1357,
                //"IdOperateur": 1752,
                //"Solde": 0.0,
                //"Jour": "2016-05-18T00:00:00 01:00"
            //}
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Auto,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                Formatting = JsonFormatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Local,
                DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                
                Converters = new List<JsonConverter> {idtConverter}
            };

            return jsonSerializerSettings;
        }

        public static string SerializeToJson<T>(T objToSerialize)
        {
            var jsonSerializerSettings = CreateJsonSettings();
            var json = JsonConvert.SerializeObject(objToSerialize, jsonSerializerSettings);
            return json;
        }

        public static string SerializeToXmlString<T>(T objToSerialize)
        {
            string xmlstream;

            using (var memstream = new MemoryStream())
            {
                var xmlSerializer = new XmlSerializer(typeof (T));
                var xmlWriter = new XmlTextWriter(memstream, Encoding.UTF8);

                xmlSerializer.Serialize(xmlWriter, objToSerialize);
                xmlstream = Utf8ByteArrayToString(((MemoryStream) xmlWriter.BaseStream).ToArray());
            }

            return xmlstream;
        }

        public static T DeserializeFromJsonString<T>(string jsonString)
        {
            var jsonSerializerSettings = CreateJsonSettings();
            var tempObject = JsonConvert.DeserializeObject<T>(jsonString, jsonSerializerSettings);
            return tempObject;
        }

        public static T DeserializeFromXmlString<T>(string xmlString)
        {
            T tempObject;

            using (var memoryStream = new MemoryStream(StringToUtf8ByteArray(xmlString)))
            {
                var xs = new XmlSerializer(typeof (T));

                tempObject = (T) xs.Deserialize(memoryStream);
            }

            return tempObject;
        }

        public static string Utf8ByteArrayToString(byte[] arrBytes)
        {
            return new UTF8Encoding().GetString(arrBytes);
        }

        public static byte[] StringToUtf8ByteArray(string xmlString)
        {
            return new UTF8Encoding().GetBytes(xmlString);
        }
    }
}