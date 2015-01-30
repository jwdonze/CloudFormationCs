using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-base64.html
    /// </summary>
    public class Fn__Base64 : KeyByType, IKeyValue
    {
        public Fn__Base64() { }

        public Fn__Base64(StringRef topLevelKey)
        {
            this._topLevelKey     =topLevelKey;
        }

        public Object Value
        {
            get
            {
                return _topLevelKey.Ref;
            }
        }

        private StringRef _topLevelKey;
    }
}
