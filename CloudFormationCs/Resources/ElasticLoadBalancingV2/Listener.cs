using System;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html
    /// </summary>
    public class Listener : Resource
    {
        public enum Protocols
        {
            HTTP = 1,
            HTTPS,
            TCP,
        }
        public Certificate[] Certificates { get; set; }
        public Certificate Certificate { set { this.Certificates = new Certificate[] { value }; } }

        [Required(true)]
        public Action[] DefaultActions { get; set; }

        [Required(true)]
        public StringRef LoadBalancerArn { get; set; }

        [Required(true)]
        public int Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required(true)]
        public Protocols Protocol { get; set; }

        public string SslPolicy { get; set; }

        public Listener() : base() { }
        public Listener(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }
    }
}
