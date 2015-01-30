using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html
    /// </summary>
    public class VPCDHCPOptionsAssociation : Resource
    {
        [Required(true)]
        public String DhcpOptionsId { get; set; }

        [Required(true)]
        public String VpcId { get; set; }

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
