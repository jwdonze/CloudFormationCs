using System;
using System.Collections;
using System.Collections.Generic;

namespace CloudFormationCs
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getavailabilityzones.html
    /// </summary>
    public class Fn__GetAZs : KeyByType, IKeyValue
    {
        public Fn__GetAZs()
        {
        }

        public Fn__GetAZs(string attrName)
        {
            this._attrName = attrName;
        }

        public Object Value
        {
            get
            {
                return this._attrName;
            }
        }

        string _attrName;
    }
}

