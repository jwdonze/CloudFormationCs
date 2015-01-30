using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route-table.html
    /// </summary>
    public class RouteTable : Resource
    {
        [Required(true)]
        public StringRef VpcId { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public RouteTable()
            : base()
        {
        }

        public RouteTable(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
