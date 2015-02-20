using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html
    /// </summary>
    public class VPC : Resource
    {
        [Required(true)]
        public String CidrBlock { get; set; }

        [Required(false)]
        public Boolean EnableDnsSupport { get; set; }

        [Required(false)]
        public Boolean EnableDnsHostnames { get; set; }

        [Required(false)]
        public String InstanceTenancy { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public VPC()
            : base()
        {
        }

        public VPC(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
