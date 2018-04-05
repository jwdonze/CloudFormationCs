using System;
using CloudFormationCs.Converters;
using Newtonsoft.Json;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-interface.html
    /// </summary>
    public class NetworkInterface : Resource
    {
        [Required(false)]
        public String Description { get; set; }

        [Required(false)]
        public StringRef[] GroupSet { get; set; }

        [JsonIgnore]
        public StringRef GroupSet1 { set { this.GroupSet = new StringRef[] { value }; } }

        [Required(false)]
        public String PrivateIpAddress { get; set; }

        [Required(false)]
        public Entity.PrivateIpAddressSpecification[] PrivateIpAddresses { get; set; }

        [Required(false)]
        public Int32 SecondaryPrivateIpAddressCount { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        [Required(false)]
        public Boolean? SourceDestCheck { get; set; }

        [Required(true)]
        public StringRef SubnetId { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public NetworkInterface()
            : base()
        {
        }

        public NetworkInterface(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
