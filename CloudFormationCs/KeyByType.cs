using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs
{
    public abstract class KeyByType
    {
        public string Key
        {
            get
            {
                return CfnHelpers.GetNameShort(this);
            }
        }
        protected void WriteFunctionName(JsonWriter writer)
        {
            writer.WritePropertyName(CfnHelpers.GetNameShort(this));
        }
        protected void WriteNamePlusArray(JsonWriter writer, JsonSerializer serializer, StringRef name, params StringRef[] array)
        {
            var src = new Converters.StringRefConverter();
            writer.WriteStartObject();
            this.WriteFunctionName(writer);
            writer.WriteStartArray();
            if (name != null)
            {
                src.WriteJson(writer, name, serializer);
                writer.WriteStartArray();
            }
            foreach (var s in array)
            {
                src.WriteJson(writer, s, serializer);
            }
            if (name != null)
            {
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
            writer.WriteEndObject();

        }
    }
}
