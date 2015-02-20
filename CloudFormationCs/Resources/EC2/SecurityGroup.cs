using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html
    /// </summary>
    public class SecurityGroup : Resource
    {
        [Required(true)]
        public String GroupDescription { get; set; }

        [Required(false)]
        public SecurityGroupRuleEgress[] SecurityGroupEgress { get; set; }

        [Required(false)]
        public SecurityGroupRuleIngress[] SecurityGroupIngress { get; set; }

        [Required(true)]
        public StringRef VpcId { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public SecurityGroup()
            : base()
        {
        }

        public SecurityGroup(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
