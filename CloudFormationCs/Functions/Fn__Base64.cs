using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-base64.html
    /// </summary>
    public class Fn__Base64 : KeyByType, IWriteObject
    {
        public Fn__Base64() { }

        public Fn__Base64(StringRef topLevelKey)
        {
            this._topLevelKey     =topLevelKey;
        }

        public void WriteTo(JsonWriter writer, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Base64");
            var s = new Converters.StringRefConverter();
            s.WriteJson(writer, this._topLevelKey, serializer);
            writer.WriteEndObject();
        }

        private StringRef _topLevelKey;
    }
}
