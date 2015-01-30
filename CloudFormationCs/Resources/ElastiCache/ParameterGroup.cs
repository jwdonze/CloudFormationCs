using System;

namespace CloudFormationCs.Resources.ElastiCache
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html
    /// </summary>
    public class ParameterGroup : Resource
    {
        [Required(true)]
        public String CacheParameterGroupFamily { get; set; }

        [Required(true)]
        public String Description { get; set; }

        [Required(true)]
        public object Properties { get; set; }

        public ParameterGroup()
            : base()
        {
        }

        public ParameterGroup(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
