using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace CloudFormationCs.Converters
{
    /// <summary>
    /// Converts the object to a lower case string
    /// </summary>
    internal class LowerCaseStringConverter : JsonWriterOnlyBase
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool)
                || objectType == typeof(ParameterTypes)
                ;
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString().ToLower());
        }
    }
}
