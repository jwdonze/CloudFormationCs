using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html
    /// </summary>
    public class EC2_PortRange
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public Int32 From { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public Int32 To { get; set; }

        public EC2_PortRange(int port)
        {
            if (port == -1)
            {
                this.From = 1;
                this.To = 65535;
            }
            else
            {
                this.From = port;
                this.To = port;
            }
        }
        public EC2_PortRange(int fromPort, int toPort)
        {
            this.From = fromPort;
            this.To = toPort;
        }
    }
}
