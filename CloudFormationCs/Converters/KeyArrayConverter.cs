using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Converters
{
    internal class KeyArrayConverter : Converters.JsonWriterOnlyBase
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IKeyValue[]);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var s = GetJsonSettings();

            writer.WriteStartObject();
            var r = value as IKeyValue[];
            foreach (var res in r)
            {
                writer.WritePropertyName(res.Key);
                writer.WriteRawValue(JsonConvert.SerializeObject(res.Value, Formatting.Indented, s));
            }
            writer.WriteEndObject();
        }
    }
}
