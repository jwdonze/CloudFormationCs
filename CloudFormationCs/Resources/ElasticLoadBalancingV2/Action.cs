using CloudFormationCs.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    public class Action
    {
        [JsonConverter(typeof(UnderscoreToDashConverter))]
        public enum Types
        {
            forward = 1,
            authenticate_oidc,
            authenticate_cognito,
        }
        [Required(true)]
        public StringRef TargetGroupArn { get; set; }
        /// <summary>
        /// forward | authenticate-oidc | authenticate-cognito
        /// </summary>
        [Required(true)]
        public Types Type { get; set; }

        public Action() { }
        public Action(StringRef targetGroupArn, Types type)
        {
            this.TargetGroupArn = targetGroupArn;
            this.Type = type;
        }
    }
}
