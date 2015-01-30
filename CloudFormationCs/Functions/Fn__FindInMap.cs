using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-findinmap.html
    /// </summary>
    public class Fn__FindInMap : KeyByType, IKeyValue
    {
        public Fn__FindInMap() { }

        public Fn__FindInMap(String mapName, StringRef topLevelKey, StringRef secondLevelKey)
        {
            this._mapName = mapName;
            this._topLevelKey     =topLevelKey;
            this._secondLevelKey  =secondLevelKey;
        }

        public Object Value
        {
            get
            {
                var ht = new List<Object>();

                ht.Add(this._mapName);
                ht.Add(this._topLevelKey.Ref);
                ht.Add(this._secondLevelKey.Ref);
                return ht;
            }
        }

        private String _mapName;
        private StringRef _topLevelKey;
        private StringRef _secondLevelKey;
    }
}
