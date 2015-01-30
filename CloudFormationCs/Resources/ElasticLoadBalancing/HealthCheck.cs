using System;

namespace CloudFormationCs.Resources.ElasticLoadBalancing
{
    public class HealthCheck
    {
        [Required(true)]
        public String HealthyThreshold { get; set; }

        [Required(true)]
        public String Interval { get; set; }

        [Required(true)]
        public String Target { get; set; }

        [Required(true)]
        public String Timeout { get; set; }

        [Required(true)]
        public String UnhealthyThreshold { get; set; }
    }
}
