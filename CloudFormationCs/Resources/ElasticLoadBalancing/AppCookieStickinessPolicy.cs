using System;

namespace CloudFormationCs.Resources.ElasticLoadBalancing
{
    public class AppCookieStickinessPolicy
    {
        [Required(true)]
        public String CookieName { get; set; }

        [Required(true)]
        public String PolicyName { get; set; }
    }
}
