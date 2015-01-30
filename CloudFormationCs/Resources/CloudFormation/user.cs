using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class user
    {
        public String[] groups { get; set; }

        public String uid { get; set; }

        public String homeDir { get; set; }
    }
}
