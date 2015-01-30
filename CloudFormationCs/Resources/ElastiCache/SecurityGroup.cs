using System;

namespace CloudFormationCs.Resources.ElastiCache
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group.html
    /// </summary>
    public class SecurityGroup : Resource
    {
        [Required(false)]
        public String Description { get; set; }

        public SecurityGroup()
            : base()
        {
        }

        public SecurityGroup(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
