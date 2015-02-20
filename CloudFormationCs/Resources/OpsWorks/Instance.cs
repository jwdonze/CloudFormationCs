using System;

namespace CloudFormationCs.Resources.OpsWorks
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-instance.html
    /// </summary>
    public class Instance : Resource
    {
        [Required(false)]
        public String AmiId { get; set; }

        [Required(false)]
        public String Architecture { get; set; }

        [Required(false)]
        public String AvailabilityZone { get; set; }

        [Required(false)]
        public Boolean InstallUpdatesOnBoot { get; set; }

        [Required(true)]
        public String InstanceType { get; set; }

        [Required(true)]
        public String[] LayerIds { get; set; }

        [Required(false)]
        public String Os { get; set; }

        [Required(false)]
        public String RootDeviceType { get; set; }

        [Required(false)]
        public String SshKeyName { get; set; }

        [Required(true)]
        public String StackId { get; set; }

        [Required(false)]
        public String SubnetId { get; set; }

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
