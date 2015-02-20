using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-gateway-attachment.html
    /// </summary>
    public class VPCGatewayAttachment : Resource
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef InternetGatewayId { get; set; }

        [Required(true)]
        public StringRef VpcId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String VpnGatewayId { get; set; }

        public VPCGatewayAttachment()
            : base()
        {
        }

        public VPCGatewayAttachment(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
