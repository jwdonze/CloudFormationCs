using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getavailabilityzones.html
    /// </summary>
    public class Fn__GetAZs : KeyByType, IWriteObject
    {
        public Fn__GetAZs()
        {
        }

        public Fn__GetAZs(string attrName)
        {
            this._attrName = attrName;
        }

        public void WriteTo(JsonWriter writer, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            this.WriteFunctionName(writer);
            writer.WriteValue(this._attrName);
            writer.WriteEndObject();
        }

        string _attrName;
    }
}

