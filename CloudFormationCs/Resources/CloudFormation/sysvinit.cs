using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class sysvinit
    {
        [EmitAsString]
        public Boolean enabled { get; set; }

        [EmitAsString]
        public Boolean ensureRunning { get; set; }

        public String[] files { get; set; }

        public String[] sources { get; set; }
    }
}
