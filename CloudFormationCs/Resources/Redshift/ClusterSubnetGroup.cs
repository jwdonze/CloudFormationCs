using System;

namespace CloudFormationCs.Resources.Redshift
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersubnetgroup.html
    /// </summary>
    public class ClusterSubnetGroup : Resource
    {
        [Required(true)]
        public String Description { get; set; }

        [Required(true)]
        public String[] SubnetIds { get; set; }

        public ClusterSubnetGroup()
            : base()
        {
        }

        public ClusterSubnetGroup(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
