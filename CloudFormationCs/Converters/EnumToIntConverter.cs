using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace CloudFormationCs.Converters
{
    /// <summary>
    /// Converts enums to ints
    /// </summary>
    internal class EnumToIntConverter : JsonWriterOnlyBase
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Enum)
                ;
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue((int)value);
        }
    }
}
