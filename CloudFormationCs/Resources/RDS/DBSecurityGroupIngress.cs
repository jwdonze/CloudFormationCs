using System;

namespace CloudFormationCs.Resources.RDS
{
    public class DBSecurityGroupIngress : Resource
    {
        [Required(false)]
        public String CIDRIP { get; set; }

        [Required(false)]
        public String EC2SecurityGroupId { get; set; }

        [Required(false)]
        public String EC2SecurityGroupName { get; set; }

        [Required(false)]
        public String EC2SecurityGroupOwnerId { get; set; }

        public DBSecurityGroupIngress()
            : base()
        {
        }

        public DBSecurityGroupIngress(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
