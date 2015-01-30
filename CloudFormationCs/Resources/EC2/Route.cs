using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route.html
    /// </summary>
    public class Route : Resource
    {
        [Required(true)]
        public StringRef DestinationCidrBlock { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef GatewayId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef InstanceId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef NetworkInterfaceId { get; set; }

        [Required(true)]
        public StringRef RouteTableId { get; set; }

        public Route()
            : base()
        {
        }

        public Route(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
