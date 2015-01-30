using System;
using System.Collections;
using System.Collections.Generic;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getatt.html
    /// </summary>
    public class Fn__GetAtt : KeyByType, IKeyValue
    {
        public Fn__GetAtt() { }

        public Fn__GetAtt(StringRef resName, string attrName)
        {
            this._resName = resName;
            this._attrName = attrName;
        }

        public Object Value
        {
            get
            {
                var ht = new List<Object>();

                ht.Add(this._resName.Ref);
                ht.Add(this._attrName);
                return ht;
            }
        }

        private StringRef _resName;

        private string _attrName;
    }
}

