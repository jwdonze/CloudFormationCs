using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html
    /// </summary>
    public class TargetGroup : Resource
    {
        public enum Protocols
        {
            TCP = 1,
            HTTP,
            HTTPS,
            TLS,
        }
        public int HealthCheckIntervalSeconds { get; set; }
        public StringRef HealthCheckPath { get; set; }
        public StringRef HealthCheckPort { get; set; }
        public Protocols HealthCheckProtocol { get; set; }
        public int HealthCheckTimeoutSeconds { get; set; }
        public int HealthyThresholdCount { get; set; }
        public Matcher Matcher { get; set; }
        public string Name { get; set; }

        [Required(true)]
        public int Port { get; set; }

        [Required(true)]
        public Protocols Protocol { get; set; }
        public Tag[] Tags { get; set; }
        public TargetGroupAttribute[] TargetGroupAttributes { get; set; }
        public TargetDescription[] Targets { get; set; }
        public enum Types
        {
            instance = 1,
            ip,
        }
        /// <summary>
        /// default is instance
        /// </summary>
        public Types TargetType { get; set; }
        public int UnhealthyThresholdCount { get; set; }

        [Required(true)]
        public StringRef VpcId { get; set; }

        public TargetGroup() : base() { }
        public TargetGroup(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }
    }
}
