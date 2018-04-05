using System;
using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getatt.html
    /// </summary>
    public class Fn__GetAtt : KeyByType, IWriteObject
    {
        public Fn__GetAtt() { }

        public Fn__GetAtt(StringRef resName, string attrName)
        {
            this._resName = resName;
            this._attrName = attrName;
        }
        public void WriteTo(JsonWriter writer, JsonSerializer serializer)
        {
            this.WriteNamePlusArray(writer, serializer, null, this._resName, this._attrName);
        }

        private StringRef _resName;

        private string _attrName;
    }
}

