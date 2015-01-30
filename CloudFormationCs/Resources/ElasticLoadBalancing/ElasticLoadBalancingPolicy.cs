using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.ElasticLoadBalancing
{
    public class ElasticLoadBalancingPolicy
    {
        // [ { "Name", String, "Value", String }, ... ]
        [Required(false)]
        public Dictionary<String, StringRef> Attributes { get; set; }

        [Required(false)]
        public String[] InstancePorts { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String[] LoadBalancerPorts { get; set; }

        [Required(true)]
        public String PolicyName { get; set; }

        [Required(true)]
        public String PolicyType { get; set; }
    }
}
