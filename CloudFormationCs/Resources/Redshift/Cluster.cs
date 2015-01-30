using System;

namespace CloudFormationCs.Resources.Redshift
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html
    /// </summary>
    public class Cluster : Resource
    {
        [Required(false)]
        public Boolean AllowVersionUpgrade { get; set; }

        [Required(false)]
        public Int32 AutomatedSnapshotRetentionPeriod { get; set; }

        [Required(false)]
        public String AvailabilityZone { get; set; }

        [Required(false)]
        public String ClusterParameterGroupName { get; set; }

        [Required(false)]
        public String[] ClusterSecurityGroups { get; set; }

        [Required(false)]
        public String ClusterSubnetGroupName { get; set; }

        [Required(true)]
        public String ClusterType { get; set; }

        [Required(false)]
        public String ClusterVersion { get; set; }

        [Required(true)]
        public String DBName { get; set; }

        [Required(false)]
        public String ElasticIp { get; set; }

        [Required(false)]
        public Boolean Encrypted { get; set; }

        [Required(false)]
        public String HsmClientCertificateIdentifier { get; set; }

        [Required(false)]
        public String HsmConfigurationIdentifier { get; set; }

        [Required(true)]
        public String MasterUsername { get; set; }

        [Required(true)]
        public String MasterUserPassword { get; set; }

        [Required(true)]
        public String NodeType { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public Int32 NumberOfNodes { get; set; }

        [Required(false)]
        public String OwnerAccount { get; set; }

        [Required(false)]
        public Int32 Port { get; set; }

        [Required(false)]
        public String PreferredMaintenanceWindow { get; set; }

        [Required(false)]
        public Boolean PubliclyAccessible { get; set; }

        [Required(false)]
        public String SnapshotClusterIdentifier { get; set; }

        [Required(false)]
        public String SnapshotIdentifier { get; set; }

        [Required(false)]
        public String[] VpcSecurityGroupIds { get; set; }

        public Cluster()
            : base()
        {
        }

        public Cluster(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
