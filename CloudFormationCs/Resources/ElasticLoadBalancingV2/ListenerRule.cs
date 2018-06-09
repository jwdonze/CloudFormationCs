using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html
    /// </summary>
    public class ListenerRule : Resource
    {
        [Required(true)]
        public Action[] Actions { get; set; }
        [Required(true)]
        public RuleCondition[] Conditions  { get; set; }
        [Required(true)]
        public StringRef ListenerArn { get; set; }
        [Required(true)]
        public int Priority { get; set; }

        public ListenerRule() : base() { }

        public ListenerRule(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }
    }
}
