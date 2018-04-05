using System;
using CloudFormationCs.Converters;
using Newtonsoft.Json;

namespace CloudFormationCs.Resources.AutoScaling
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html
    /// </summary>
    public class LaunchConfiguration : Resource
    {
        public Boolean AssociatePublicIpAddress { get; set; }

        public Entity.BlockDeviceMapping[] BlockDeviceMappings { get; set; }

        public Boolean EbsOptimized { get; set; }

        public StringRef IamInstanceProfile { get; set; }

        public StringRef ImageId { get; set; }

        public String InstanceId { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        public Boolean InstanceMonitoring { get; set; }

        public String InstanceType { get; set; }

        public String KernelId { get; set; }

        public StringRef KeyName { get; set; }

        public String RamDiskId { get; set; }

        [JsonIgnore]
        public StringRef SecurityGroup { set { this.SecurityGroups = new StringRef[] { value, }; } }

        public StringRef[] SecurityGroups { get; set; }

        public String SpotPrice { get; set; }

        public String UserData { get; set; }

        public LaunchConfiguration()
            : base()
        {
        }

        public LaunchConfiguration(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
