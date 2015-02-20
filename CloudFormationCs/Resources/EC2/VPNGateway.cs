using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gateway.html
    /// </summary>
    public class VPNGateway : Resource
    {
        [Required(true)]
        public String Type { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public VPNGateway()
            : base()
        {
        }

        public VPNGateway(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
