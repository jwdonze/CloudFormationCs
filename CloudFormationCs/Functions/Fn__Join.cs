using System;
using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-join.html
    /// </summary>
    public class Fn__Join : KeyByType, IWriteObject
    {
        public Fn__Join() { }

        public Fn__Join(string delim, StringRef[] resName)
        {
            this._delim = delim;
            this._resName = resName;
        }

        public void WriteTo(JsonWriter writer, JsonSerializer serializer)
        {
            this.WriteNamePlusArray(writer, serializer, this._delim, this._resName);
        }
        StringRef[] _resName;
        private string _delim;
    }
}

