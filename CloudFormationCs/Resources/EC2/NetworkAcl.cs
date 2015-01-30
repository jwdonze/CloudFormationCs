using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl.html
    /// </summary>
    public class NetworkAcl : Resource
    {
        [Required(false)]
        public Tag[] Tags { get; set; }

        [Required(true)]
        public String VpcId { get; set; }

        public NetworkAcl()
            : base()
        {
        }

        public NetworkAcl(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
