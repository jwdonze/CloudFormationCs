using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gatewayrouteprop.html
    /// </summary>
    public class VPNGatewayRoutePropagation : Resource
    {
        [Required(false)]
        public StringRef[] RouteTableIds { get; set; }

        [Required(true)]
        public StringRef VpnGatewayId { get; set; }

        public VPNGatewayRoutePropagation()
            : base()
        {
        }

        public VPNGatewayRoutePropagation(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
