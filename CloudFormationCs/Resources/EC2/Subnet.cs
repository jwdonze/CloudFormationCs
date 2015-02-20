using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html
    /// </summary>
    public class Subnet : Resource
    {
        [Required(false)]
        public StringRef AvailabilityZone { get; set; }

        [Required(true)]
        public StringRef CidrBlock { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        [Required(true)]
        public Ref VpcId { get; set; }

        public Subnet()
            : base()
        {
        }

        public Subnet(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
