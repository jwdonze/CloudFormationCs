using System;
using System.Web.Script.Serialization;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html
    /// </summary>
    public class Instance : Resource
    {
        [Required(false)]
        public StringRef AvailabilityZone { get; set; }

        public Entity.BlockDeviceMapping BlockDeviceMapping { set { this.BlockDeviceMappings = new Entity.BlockDeviceMapping[] { value, }; } }

        [Required(false)]
        public Entity.BlockDeviceMapping[] BlockDeviceMappings { get; set; }

        [Required(false)]
        public Boolean DisableApiTermination { get; set; }

        [Required(false)]
        public Boolean EbsOptimized { get; set; }

        [Required(false)]
        public String IamInstanceProfile { get; set; }

        [Required(true)]
        public StringRef ImageId { get; set; }

        [Required(false)]
        public StringRef InstanceType { get; set; }

        [Required(false)]
        public String KernelId { get; set; }

        [Required(false)]
        public StringRef KeyName { get; set; }

        [Required(false)]
        public Boolean Monitoring { get; set; }

        [ScriptIgnore]
        public NetworkInterfaceEmbedded NetworkInterface { set { this.NetworkInterfaces = new NetworkInterfaceEmbedded[] { value, }; } }

        [Required(false)]
        public NetworkInterfaceEmbedded[] NetworkInterfaces { get; set; }

        [Required(false)]
        public String PlacementGroupName { get; set; }

        [Required(false)]
        public String PrivateIpAddress { get; set; }

        [Required(false)]
        public String RamdiskId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String[] SecurityGroupIds { get; set; }

        [Required(false)]
        public StringRef[] SecurityGroups { get; set; }

        [ScriptIgnore]
        public StringRef SecurityGroup { set { this.SecurityGroups = new StringRef[] { value, }; } }

        [Required(false)]
        public Boolean SourceDestCheck { get; set; }

        [Required(false)]
        public String SubnetId { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        [Required(false)]
        public String Tenancy { get; set; }

        [Required(false)]
        public StringRef UserData { get; set; }

        [NonProperty]
        public Metadata Metadata { get; set; }

        [Required(false)]
        public Entity.MountPoint[] Volumes { get; set; }

        public Instance()
            : base()
        {
        }

        public Instance(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
