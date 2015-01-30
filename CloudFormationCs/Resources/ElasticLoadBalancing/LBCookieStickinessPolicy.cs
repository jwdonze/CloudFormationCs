using System;

namespace CloudFormationCs.Resources.ElasticLoadBalancing
{
    public class LBCookieStickinessPolicy
    {
        [Required(false)]
        public String CookieExpirationPeriod { get; set; }

        [Required(true)]
        public String PolicyName { get; set; }
    }
}
