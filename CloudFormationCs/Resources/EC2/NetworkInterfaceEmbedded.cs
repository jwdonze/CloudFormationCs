using CloudFormationCs.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-network-iface-embedded.html
    /// </summary>
    public class NetworkInterfaceEmbedded
    {
        [Required(false)]
        public Boolean? AssociatePublicIpAddress { get; set; }

        [Required(false)]
        public Boolean? DeleteOnTermination { get; set; }

        [Required(false)]
        public String Description { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        [Required(true)]
        public int? DeviceIndex { get; set; }

        [Required(false)]
        public StringRef[] GroupSet { get; set; }

        [Required(true)]
        public StringRef NetworkInterfaceId { get; set; }

        [Required(false)]
        public String PrivateIpAddress { get; set; }

        [Required(false)]
        public Entity.PrivateIpAddressSpecification[] PrivateIpAddresses { get; set; }

        [Required(false)]
        public Int32 SecondaryPrivateIpAddressCount { get; set; }

        //[JsonConverter(typeof(Template.EmitAsStringConverter))]
        //[Required(false)]
        //public Boolean? SourceDestCheck { get; set; }

        [Required(true)]
        public StringRef SubnetId { get; set; }

        public NetworkInterfaceEmbedded() : base() { }

        public NetworkInterfaceEmbedded(StringRef networkInterfaceId, int deviceIndex)
            : base()
        {
            NetworkInterfaceId = networkInterfaceId;
            DeviceIndex = deviceIndex;
        }
    }
}
