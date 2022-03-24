using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-customer-gateway.html
    /// </summary>
    public class CustomerGateway : Resource
    {
        [Required(true)]
        public Int32 BgpAsn { get; set; }

        [Required(true)]
        public StringRef IpAddress { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        [Required(true)]
        public String Type { get; set; }

        public CustomerGateway()
            : base()
        {
        }

        public CustomerGateway(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
