using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html
    /// </summary>
    public class NatGateway : Resource
    {
        [Required(true)]
        public StringRef AllocationId { get; set; }

        [Required(true)]
        public StringRef SubnetId { get; set; }

        public NatGateway() : base() { }

        public NatGateway(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
