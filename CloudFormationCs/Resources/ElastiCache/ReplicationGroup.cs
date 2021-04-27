using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.ElastiCache
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html
    /// </summary>
    public class ReplicationGroup : Resource
    {
        [Required(false)]
        public Boolean? AutomaticFailoverEnabled { get; set; }

        /// <summary>
        /// Currently, this property isn't used by ElastiCache.
        /// </summary>
        [Required(false)]
        public Boolean AutoMinorVersionUpgrade { get; set; }

        [Required(false)]
        public String CacheNodeType { get; set; }

        [Required(false)]
        public String CacheParameterGroupName { get; set; }

        [Required(false)]
        public String[] CacheSecurityGroupNames { get; set; }

        [Required(false)]
        public StringRef CacheSubnetGroupName { get; set; }

        [Required(true)]
        public String Engine { get; set; }

        [Required(false)]
        public String EngineVersion { get; set; }

        [Required(false)]
        public Boolean? MultiAZEnabled { get; set; }

        [Required(false)]
        public NodeGroupConfiguration[] NodeGroupConfiguration { get; set; }

        [Required(false)]
        public String NotificationTopicArn { get; set; }

        [Required(false)]
        public int NumCacheClusters { get; set; }

        [Required(false)]
        public int NumNodeGroups { get; set; }

        [Required(false)]
        public int Port { get; set; }

        [Required(false)]
        public String[] PreferredCacheClusterAZs { get; set; }

        [Required(false)]
        public String PreferredMaintenanceWindow { get; set; }

        [Required( RequiredAttribute.RequirementTypes.Conditional)]
        public String PrimaryClusterId { get; set; }

        [Required(false)]
        public int ReplicasPerNodeGroup { get; set; }

        [Required(true)]
        public String ReplicationGroupDescription { get; set; }

        [Required(false)]
        public String ReplicationGroupId { get; set; }

        /// <summary>
        /// If you specify the SecurityGroupIds property, don't also specify the CacheSecurityGroupNames property.
        /// 
        /// The CacheSecurityGroupNames property is only for EC2-Classic security groups.
        /// If you specify an EC2-Classic security group, the deployment will fail.
        /// </summary>
        [Required(false)]
        public String[] SecurityGroupIds { get; set; }

        [Required(false)]
        public String[] SnapshotArns { get; set; }

        [Required(false)]
        public String SnapshotName { get; set; }

        [Required(false)]
        public int SnapshotRetentionLimit { get; set; }

        [Required(false)]
        public String SnapshottingClusterId { get; set; }

        [Required(false)]
        public String SnapshotWindow { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public ReplicationGroup() : base() { }
        public ReplicationGroup(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }
    }
}
