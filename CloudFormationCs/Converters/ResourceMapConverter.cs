using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Converters
{
    internal class ResourceMapConverter : Converters.JsonWriterOnlyBase
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<Resource>);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            var r = value as List<Resource>;
            var s = new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore, };
            s.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            s.Converters.Add(new Converters.StringRefConverter());

            foreach (var res in r)
            {
                writer.WritePropertyName(res.ResourceIdentifier);
                writer.WriteStartObject();
                writer.WritePropertyName("Type");
                writer.WriteValue(CfnHelpers.GetNameFull(res));
                if (res.DependsOn != null)
                {
                    writer.WritePropertyName("DependsOn");
                    if (res.DependsOn.Length == 1)
                    {
                        writer.WriteValue(res.DependsOn[0]);
                    }
                    else
                    {
                        writer.WriteValue(res);
                    }
                }
                writer.WritePropertyName("Properties");
                writer.WriteRawValue(JsonConvert.SerializeObject(res, Formatting.Indented, s));

                Resources.EC2.Instance ints = res as Resources.EC2.Instance;
                if (ints != null && ints.Metadata != null)
                {
                    writer.WritePropertyName("Metadata");
                    writer.WriteRawValue(JsonConvert.SerializeObject(ints.Metadata, Formatting.Indented, s));
                }

                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }
    }
}
