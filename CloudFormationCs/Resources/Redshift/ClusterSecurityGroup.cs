using System;

namespace CloudFormationCs.Resources.Redshift
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clusterparametergroup.html
    /// </summary>
    public class ClusterSecurityGroup : Resource
    {
        [Required(true)]
        public String Description { get; set; }

        public ClusterSecurityGroup()
            : base()
        {
        }

        public ClusterSecurityGroup(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
