using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Helpers
{
    public class JsonDateConverter : DateTimeConverterBase
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            DateTime dtNow = DateTime.MinValue;

            List<string> formats = Thread.CurrentThread.CurrentCulture.DateTimeFormat.GetAllDateTimePatterns().ToList();
            formats.Add(Constants.DEFAULT_STRING_DATE_FORMAT);
            if (DateTime.TryParseExact(((DateTime)value).ToString(), formats.ToArray(), DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out dtNow))
            {
            }

            writer.WriteValue(dtNow.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }
            var s = reader.Value.ToString();
            if (s.Trim() == string.Empty)
                return null;


            DateTime dtNow = DateTime.MinValue;
            if (!string.IsNullOrEmpty(s))
            {
                List<string> formats = Thread.CurrentThread.CurrentCulture.DateTimeFormat.GetAllDateTimePatterns().ToList();
                formats.Add(Constants.DEFAULT_STRING_DATE_FORMAT);
                if (DateTime.TryParseExact(s, formats.ToArray(), DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out dtNow))
                {
                }
            }
            return dtNow;
        }
    }
}
