using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-findinmap.html
    /// </summary>
    public class Fn__FindInMap : KeyByType, IWriteObject
    {
        public Fn__FindInMap() { }

        public Fn__FindInMap(String mapName, StringRef topLevelKey, StringRef secondLevelKey)
        {
            this._mapName = mapName;
            this._topLevelKey     =topLevelKey;
            this._secondLevelKey  =secondLevelKey;
        }

        public void WriteTo(JsonWriter writer, JsonSerializer serializer)
        {
            this.WriteNamePlusArray(writer, serializer, null, this._mapName, this._topLevelKey, this._secondLevelKey);
        }

        private String _mapName;
        private StringRef _topLevelKey;
        private StringRef _secondLevelKey;
    }
}
