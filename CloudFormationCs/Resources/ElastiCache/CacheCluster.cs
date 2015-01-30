using System;

namespace CloudFormationCs.Resources.ElastiCache
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html
    /// </summary>
    public class CacheCluster : Resource
    {
        [Required(false)]
        public Boolean AutoMinorVersionUpgrade { get; set; }

        [Required(true)]
        public String CacheNodeType { get; set; }

        [Required(false)]
        public String CacheParameterGroupName { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String[] CacheSecurityGroupNames { get; set; }

        [Required(false)]
        public String CacheSubnetGroupName { get; set; }

        [Required(false)]
        public String ClusterName { get; set; }

        [Required(true)]
        public String Engine { get; set; }

        [Required(false)]
        public String EngineVersion { get; set; }

        [Required(false)]
        public String NotificationTopicArn { get; set; }

        [Required(true)]
        public String NumCacheNodes { get; set; }

        [Required(false)]
        public Int32 Port { get; set; }

        [Required(false)]
        public String PreferredAvailabilityZone { get; set; }

        [Required(false)]
        public String PreferredMaintenanceWindow { get; set; }

        [Required(false)]
        public String[] SnapshotArns { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String[] VpcSecurityGroupIds { get; set; }

        public CacheCluster()
            : base()
        {
        }

        public CacheCluster(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
