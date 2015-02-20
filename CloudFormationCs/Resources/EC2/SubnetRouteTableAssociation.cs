using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-route-table-assoc.html
    /// </summary>
    public class SubnetRouteTableAssociation : Resource
    {
        [Required(true)]
        public StringRef RouteTableId { get; set; }

        [Required(true)]
        public StringRef SubnetId { get; set; }

        public SubnetRouteTableAssociation()
            : base()
        {
        }

        public SubnetRouteTableAssociation(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
