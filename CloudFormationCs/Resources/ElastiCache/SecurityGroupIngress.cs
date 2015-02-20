using System;

namespace CloudFormationCs.Resources.ElastiCache
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html
    /// </summary>
    public class SecurityGroupIngress : Resource
    {
        [Required(true)]
        public String CacheSecurityGroupName { get; set; }

        [Required(true)]
        public String EC2SecurityGroupName { get; set; }

        [Required(false)]
        public String EC2SecurityGroupOwnerId { get; set; }

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
