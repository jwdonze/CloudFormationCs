using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-ingress.html
    /// </summary>
    public class SecurityGroupIngress : Resource
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String GroupName { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef GroupId { get; set; }

        [Required(true)]
        public String IpProtocol { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String CidrIp { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String SourceSecurityGroupName { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef SourceSecurityGroupId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String SourceSecurityGroupOwnerId { get; set; }

        [Required(true)]
        public Int32 FromPort { get; set; }

        [Required(true)]
        public Int32 ToPort { get; set; }
        public StringRef Description { get; set; }

        public SecurityGroupIngress()
            : base()
        {
        }

        public SecurityGroupIngress(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
