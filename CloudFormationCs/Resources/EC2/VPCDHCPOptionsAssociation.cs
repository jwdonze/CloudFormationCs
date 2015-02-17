using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html
    /// </summary>
    public class VPCDHCPOptionsAssociation : Resource
    {
        [Required(true)]
        public StringRef DhcpOptionsId { get; set; }

        [Required(true)]
        public StringRef VpcId { get; set; }

        public VPCDHCPOptionsAssociation()
            : base()
        {
        }

        public VPCDHCPOptionsAssociation(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
