using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection-route.html
    /// </summary>
    public class VPNConnectionRoute : Resource
    {
        [Required(true)]
        public String DestinationCidrBlock { get; set; }

        [Required(true)]
        public StringRef VpnConnectionId { get; set; }

        public VPNConnectionRoute()
            : base()
        {
        }

        public VPNConnectionRoute(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
