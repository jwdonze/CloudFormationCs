using System;

namespace CloudFormationCs.Resources.Redshift
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html
    /// </summary>
    public class ClusterSecurityGroupIngress : Resource
    {
        [Required(true)]
        public String ClusterSecurityGroupName { get; set; }

        [Required(false)]
        public String CIDRIP { get; set; }

        [Required(false)]
        public String EC2SecurityGroupName { get; set; }

        [Required(false)]
        public String EC2SecurityGroupOwnerId { get; set; }

        public ClusterSecurityGroupIngress()
            : base()
        {
        }

        public ClusterSecurityGroupIngress(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
