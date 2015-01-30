using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class yum : Dictionary<String, String[]>
    {
        public yum()
        {
        }

        public yum(Dictionary<String, String[]> p)
            : base(p)
        {
        }
    }

}
