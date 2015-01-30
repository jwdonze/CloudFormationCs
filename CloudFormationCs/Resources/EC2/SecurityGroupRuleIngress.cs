using System;

namespace CloudFormationCs.Resources.EC2
{
    public class SecurityGroupRuleIngress
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String CidrIp { get; set; }

        [Required(true)]
        public StringRef FromPort { get; set; }

        [Required(true)]
        public String IpProtocol { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef SourceSecurityGroupId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef SourceSecurityGroupName { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef SourceSecurityGroupOwnerId { get; set; }

        [Required(true)]
        public StringRef ToPort { get; set; }

        public SecurityGroupRuleIngress()
        {
        }
    }
}

