using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface-attachment.html
    /// </summary>
    public class NetworkInterfaceAttachment : Resource
    {
        [Required(false)]
        public Boolean DeleteOnTermination { get; set; }

        [Required(true)]
        [EmitAsString]
        public Int32? DeviceIndex { get; set; }

        [Required(true)]
        public StringRef InstanceId { get; set; }

        [Required(true)]
        public StringRef NetworkInterfaceId { get; set; }

        public NetworkInterfaceAttachment()
            : base()
        {
        }

        public NetworkInterfaceAttachment(StringRef resourceIdentifier, int deviceIndex)
            : base()
        {
            NetworkInterfaceId = resourceIdentifier;
            DeviceIndex = deviceIndex;
        }
    }
}
