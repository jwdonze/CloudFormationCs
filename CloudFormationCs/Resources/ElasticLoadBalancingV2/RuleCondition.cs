using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    public class RuleCondition
    {
        public enum Fields
        {
            host_header = 1, 
            path_pattern,
        }
        public Fields Field { get; set; }
        public string[] Values { get; set; }

        public RuleCondition() { }
        public RuleCondition(Fields field, params string[] values)
        {
            this.Field = field;
            this.Values = values;
        }
    }
}
