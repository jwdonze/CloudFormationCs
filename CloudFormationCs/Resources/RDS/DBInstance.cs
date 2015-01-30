using System;

namespace CloudFormationCs.Resources.RDS
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html
    /// </summary>
    public class DBInstance : Resource
    {
        [Required(true)]
        public String AllocatedStorage { get; set; }

        [Required(false)]
        public Boolean AutoMinorVersionUpgrade { get; set; }

        [Required(false)]
        public String AvailabilityZone { get; set; }

        [Required(false)]
        public String BackupRetentionPeriod { get; set; }

        [Required(true)]
        public String DBInstanceClass { get; set; }

        [Required(false)]
        public String DBInstanceIdentifier { get; set; }

        [Required(false)]
        public String DBName { get; set; }

        [Required(false)]
        public String DBParameterGroupName { get; set; }

        [Required(false)]
        public String[] DBSecurityGroups { get; set; }

        [Required(false)]
        public String DBSnapshotIdentifier { get; set; }

        [Required(false)]
        public String DBSubnetGroupName { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String Engine { get; set; }

        [Required(false)]
        public String EngineVersion { get; set; }

        [Required(false)]
        public Int32 Iops { get; set; }

        [Required(false)]
        public String LicenseModel { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String MasterUsername { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String MasterUserPassword { get; set; }

        [Required(false)]
        public Boolean MultiAZ { get; set; }

        [Required(false)]
        public String Port { get; set; }

        [Required(false)]
        public String PreferredBackupWindow { get; set; }

        [Required(false)]
        public String PreferredMaintenanceWindow { get; set; }

        [Required(false)]
        public String SourceDBInstanceIdentifier { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        [Required(false)]
        public String[] VPCSecurityGroups { get; set; }

        public DBInstance()
            : base()
        {
        }

        public DBInstance(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
