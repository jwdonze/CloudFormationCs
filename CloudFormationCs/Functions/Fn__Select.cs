using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CloudFormationCs
{
#warning "WARNING: TODO: test this"
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-select.html
    /// </summary>
    public class Fn__Select : KeyByType, IWriteObject
    {
        public Fn__Select() { }

        public Fn__Select(StringRef index, StringRef[] resName)
        {
            this._index = index;
            this._resName = resName;
        }

        public void WriteTo(JsonWriter writer, JsonSerializer serializer)
        {
            this.WriteNamePlusArray(writer, serializer, this._index, this._resName);
        }

        StringRef _index;
        StringRef[] _resName;
    }
}

