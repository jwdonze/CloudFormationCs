using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip-association.html
    /// </summary>
    public class EIPAssociation : Resource
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef AllocationId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String EIP { get; set; }

        [Required(false)]
        public String InstanceId { get; set; }

        [Required(false)]
        public StringRef NetworkInterfaceId { get; set; }

        [Required(false)]
        public String PrivateIpAddress { get; set; }

        public EIPAssociation()
            : base()
        {
        }

        public EIPAssociation(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
