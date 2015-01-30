using System;

namespace CloudFormationCs.Resources.ElasticLoadBalancing
{
    public class ConnectionDrainingPolicy
    {
        [Required(true)]
        public Boolean Enabled { get; set; }

        [Required(false)]
        public Int32 Timeout { get; set; }
    }
}
