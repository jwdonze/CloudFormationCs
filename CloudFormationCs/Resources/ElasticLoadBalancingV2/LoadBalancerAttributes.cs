using CloudFormationCs.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    public class LoadBalancerAttributes
    {
        [JsonConverter(typeof(TwoUnderscoreToDotConverter))]
        public enum Attributes
        {
            deletion_protection__enabled = 1,
            access_logs__s3__enabled,
            access_logs__s3__bucket,
            access_logs__s3__prefix,
            idle_timeout__timeout_seconds,
            routing__http2__enabled,
            load_balancing__cross_zone__enabled,
        }
        public Attributes Key { get; set; }
        public StringRef Value { get; set; }
    }
}
