using System;

namespace CloudFormationCs.Resources.IAM
{
    public class PolicyDocument
    {
        public string Version { get; set; }

        public Statement[] Statement { get; set; }

        public PolicyDocument()
        {
        }
    }
}
