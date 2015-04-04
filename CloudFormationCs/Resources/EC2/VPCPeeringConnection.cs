using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html
    /// </summary>
    public class VPCPeeringConnection : Resource
    {
        [Required(true)]
        public StringRef PeerVpcId { get; set; }
        [Required(false)]
        public Tag[] Tags { get; set; }
        [Required(true)]
        public StringRef VpcId { get; set; }

  		public VPCPeeringConnection () : base()
		{
		}
        public VPCPeeringConnection(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
		{
		}
    }
}
