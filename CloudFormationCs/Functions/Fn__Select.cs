using System;
using System.Collections;
using System.Collections.Generic;

namespace CloudFormationCs
{
#warning "WARNING: TODO: test this"
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-select.html
    /// </summary>
    public class Fn__Select : KeyByType, IKeyValue
    {
        public Fn__Select() { }

        public Fn__Select(StringRef index, StringRef[] resName)
        {
            this._index = index;
            this._resName = resName;
        }

        public Object Value
        {
            get
            {
                var ht = new List<Object>();

                foreach (var s in _resName)
                {
                    ht.Add(s.Ref);
                }
                return new object[] { this._index, ht, };
            }
        }

        StringRef _index;
        StringRef[] _resName;
    }
}

