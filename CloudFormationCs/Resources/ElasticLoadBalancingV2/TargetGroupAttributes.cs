using CloudFormationCs.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    public class TargetGroupAttribute
    {
        [JsonConverter(typeof(TwoUnderscoreToDotConverter))]
        public enum Keys
        {
            deregistration_delay__timeout_seconds = 1,
            slow_start__duration_seconds,
            stickiness__enabled,
            stickiness__type,
            stickiness__lb_cookie__duration_seconds,
            proxy_protocol_v2__enabled,
        }
        public Keys Key { get; set; }
        public StringRef Value { get; set; }

        public TargetGroupAttribute() { }
        public TargetGroupAttribute(Keys key, StringRef value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}