using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs
{
    public abstract class KeyByType
    {
        public string Key
        {
            get
            {
                return CfnHelpers.GetNameShort(this);
            }
        }
    }
}
