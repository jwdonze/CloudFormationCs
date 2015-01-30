using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-network-acl-assoc.html
    /// </summary>
    public class SubnetNetworkAclAssociation : Resource
    {
        [Required(true)]
        public StringRef SubnetId { get; set; }

        [Required(true)]
        public StringRef NetworkAclId { get; set; }

        public SubnetNetworkAclAssociation()
            : base()
        {
        }

        public SubnetNetworkAclAssociation(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
