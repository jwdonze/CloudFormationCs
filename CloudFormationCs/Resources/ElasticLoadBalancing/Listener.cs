using System;

namespace CloudFormationCs.Resources.ElasticLoadBalancing
{
    public class Listener
    {
        [Required(true)]
        public String InstancePort { get; set; }

        [Required(false)]
        public String InstanceProtocol { get; set; }

        [Required(true)]
        public String LoadBalancerPort { get; set; }

        [Required(false)]
        public String[] PolicyNames { get; set; }

        [Required(true)]
        public String Protocol { get; set; }

        [Required(false)]
        public String SSLCertificateId { get; set; }
    }
}
