using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class package
    {
        public rpm rpm { get; set; }

        public Dictionary<String, String[]> yum { get; set; }

        public Dictionary<String, String[]> apt { get; set; }

        public Dictionary<String, String[]> rubygems { get; set; }
    }
}
