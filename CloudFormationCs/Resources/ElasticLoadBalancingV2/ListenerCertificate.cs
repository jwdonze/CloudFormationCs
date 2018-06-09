using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenercertificate.html
    /// </summary>
    public class ListenerCertificate : Resource
    {
        [Required(true)]
        public Certificate Certificates { get; set; }
        [Required(true)]
        public StringRef ListenerArn { get; set; }

        public ListenerCertificate() : base() { }

        public ListenerCertificate(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }
    }
}
