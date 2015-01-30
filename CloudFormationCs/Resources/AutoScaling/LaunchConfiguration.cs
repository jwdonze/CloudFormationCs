using System;

namespace CloudFormationCs.Resources.AutoScaling
{
    public class LaunchConfiguration : Resource
    {
        public Boolean AssociatePublicIpAddress { get; set; }

        public Entity.BlockDeviceMapping[] BlockDeviceMappings { get; set; }

        public Boolean EbsOptimized { get; set; }

        public StringRef IamInstanceProfile { get; set; }

        public StringRef ImageId { get; set; }

        public String InstanceId { get; set; }

        [EmitAsString]
        public Boolean InstanceMonitoring { get; set; }

        public String InstanceType { get; set; }

        public String KernelId { get; set; }

        public String KeyName { get; set; }

        public String RamDiskId { get; set; }

        public StringRef[] SecurityGroups { get; set; }

        public String SpotPrice { get; set; }

        public String UserData { get; set; }

        public LaunchConfiguration()
            : base()
        {
        }

        public LaunchConfiguration(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
