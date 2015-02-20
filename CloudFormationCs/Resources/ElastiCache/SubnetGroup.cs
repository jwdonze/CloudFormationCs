using System;

namespace CloudFormationCs.Resources.ElastiCache
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-subnetgroup.html
    /// </summary>
    public class SubnetGroup : Resource
    {
        [Required(true)]
        public String Description { get; set; }

        [Required(true)]
        public String[] SubnetIds { get; set; }

        public SubnetGroup()
            : base()
        {
        }

        public SubnetGroup(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
