using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.DMS
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html
    /// </summary>
    public class ReplicationInstance : Resource
    {
        public ReplicationInstance() : base() { }

        public ReplicationInstance(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }

        public string AllocatedStorage { get; set; }
        public bool AllowMajorVersionUpgrade { get; set; }
        public bool AutoMinorVersionUpgrade { get; set; }
        public string AvailabilityZone { get; set; }
        public string EngineVersion { get; set; }
        public string KmsKeyId { get; set; }
        public bool MultiAZ { get; set; }
        public string PreferredMaintenanceWindow { get; set; }
        public bool PubliclyAccessible { get; set; }
        public string ReplicationInstanceClass { get; set; }
        public string ReplicationInstanceIdentifier { get; set; }
        public StringRef ReplicationSubnetGroupIdentifier { get; set; }
        public string ResourceIdentifier { get; set; }
        public StringRef[] VpcSecurityGroupIds { get; set; }
        public Tag[] Tags { get; set; }
    }
}
