using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html
    /// </summary>
    public class NetworkAclEntry : Resource
    {
        [Required(true)]
        public String CidrBlock { get; set; }

        [Required(true)]
        public Boolean Egress { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public EC2_ICMP Icmp { get; set; }

        [Required(true)]
        public String NetworkAclId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public EC2_PortRange PortRange { get; set; }

        [Required(true)]
        public Int32 Protocol { get; set; }

        [Required(true)]
        public String RuleAction { get; set; }

        [Required(true)]
        public Int32 RuleNumber { get; set; }

        public NetworkAclEntry()
            : base()
        {
        }

        public NetworkAclEntry(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
