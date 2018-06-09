using System;

namespace CloudFormationCs.Resources.EC2
{
    public class SecurityGroupRuleEgress
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String CidrIp { get; set; }

        [Required(true)]
        public String FromPort { get; set; }

        [Required(true)]
        public String IpProtocol { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef DestinationSecurityGroupId { get; set; }

        [Required(true)]
        public String ToPort { get; set; }

        public SecurityGroupRuleEgress()
        {
        }
    }
}

