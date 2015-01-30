using System;

namespace CloudFormationCs.Resources.RDS
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnet-group.html
    /// </summary>
    public class DBSubnetGroup : Resource
    {
        [Required(true)]
        public String DBSubnetGroupDescription { get; set; }

        [Required(true)]
        public String[] SubnetIds { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public DBSubnetGroup()
            : base()
        {
        }

        public DBSubnetGroup(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
