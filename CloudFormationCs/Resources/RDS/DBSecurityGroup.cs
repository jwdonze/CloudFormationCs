using System;

namespace CloudFormationCs.Resources.RDS
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html
    /// </summary>
    public class DBSecurityGroup : Resource
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef EC2VpcId { get; set; }

        [Required(true)]
        public DBSecurityGroupIngress[] DBSecurityGroupIngress { get; set; }

        [Required(true)]
        public String GroupDescription { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public DBSecurityGroup()
            : base()
        {
        }

        public DBSecurityGroup(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
