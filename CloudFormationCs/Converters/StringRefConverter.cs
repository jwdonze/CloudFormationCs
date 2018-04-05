using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace CloudFormationCs.Converters
{
    internal class StringRefConverter : JsonWriterOnlyBase
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(StringRef)
                ;
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var sr = value as StringRef;
            if (sr != null && sr.Ref != null && sr.Ref is Ref)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("Ref");
                writer.WriteValue((sr.Ref as Ref).Value);
                writer.WriteEndObject();
            }
            else if (sr != null && sr.Ref != null && sr.Ref is IWriteObject)
            {
                (sr.Ref as IWriteObject).WriteTo(writer, serializer);
            }
            else
            {
                writer.WriteValue(value.ToString());
            }
        }
    }
}
