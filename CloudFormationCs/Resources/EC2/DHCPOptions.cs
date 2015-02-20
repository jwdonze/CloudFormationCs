using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcp-options.html
    /// </summary>
    public class DHCPOptions : Resource
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String DomainName { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String[] DomainNameServers { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String[] NetbiosNameServers { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public NetbiosNodeTypes NetbiosNodeType { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String[] NtpServers { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public DHCPOptions()
            : base()
        {
        }

        public DHCPOptions(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }

        public enum NetbiosNodeTypes
        {
            Broadcast = 1,
            PointToPoint = 2,
            MixedMode = 4,
            Hyprid = 8,
        }
    }
}
