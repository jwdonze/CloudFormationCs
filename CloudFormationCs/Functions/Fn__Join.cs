using System;
using System.Collections;
using System.Collections.Generic;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-join.html
    /// </summary>
    public class Fn__Join : KeyByType, IKeyValue
    {
        public Fn__Join() { }

        public Fn__Join(string delim, StringRef[] resName)
        {
            this._delim = delim;
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
                return new object[] { this._delim, ht, };
            }
        }

        StringRef[] _resName;
        private string _delim;
    }
}

