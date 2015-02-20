using System;

namespace CloudFormationCs.Resources.Redshift
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clusterparametergroup.html
    /// </summary>
    public class ClusterParameterGroup : Resource
    {
        [Required(true)]
        public String Description { get; set; }

        [Required(true)]
        public String ParameterGroupFamily { get; set; }

        [Required(false)]
        public Parameter[] Parameters { get; set; }

        public ClusterParameterGroup()
            : base()
        {
        }

        public ClusterParameterGroup(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
