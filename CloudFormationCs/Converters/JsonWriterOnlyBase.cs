using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Converters
{
    internal abstract class JsonWriterOnlyBase : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
        protected JsonSerializerSettings GetJsonSettings()
        {
            var s = new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore, };
            s.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

            return s;
        }
    }
}
