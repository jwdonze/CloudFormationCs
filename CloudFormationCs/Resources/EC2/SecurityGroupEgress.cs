using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html
    /// </summary>
    public class SecurityGroupEgress : Resource
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String CidrIp { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String DestinationSecurityGroupId { get; set; }

        [Required(true)]
        public Int32 FromPort { get; set; }

        [Required(true)]
        public String GroupId { get; set; }

        [Required(true)]
        public String IpProtocol { get; set; }

        [Required(true)]
        public Int32 ToPort { get; set; }

        public SecurityGroupEgress()
            : base()
        {
        }

        public SecurityGroupEgress(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
