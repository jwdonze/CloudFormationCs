using CloudFormationCs.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html
    /// </summary>
    public class LoadBalancer : Resource
    {
        [JsonConverter(typeof(UnderscoreToDashConverter))]
        public enum Schemes
        {
            @internal = 1,
            internet_facing,
        }
        public LoadBalancerAttributes[] LoadBalancerAttributes { get; set; }
       
        public string Name { get; set; }

        /// <summary>
        /// internal or internet-facing
        /// </summary>
        public Schemes Scheme { get; set; }

        public StringRef[] SecurityGroups { get; set; }

        [JsonIgnore]
        public StringRef SecurityGroup { set { this.SecurityGroups = new StringRef[] { value, }; } }

        public SubnetMapping[] SubnetMappings { get; set; }

        public StringRef[] Subnets { get; set; }

        public Tag[] Tags { get; set; }

        /// <summary>
        /// application or network
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// ipv4 | dualstack. Default value is ipv4. 
        /// </summary>
        public string IpAddressType { get; set; }

        public LoadBalancer() : base() { }

        public LoadBalancer(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }
    }
}
