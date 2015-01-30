using System;

namespace CloudFormationCs.Resources.Route53
{
    public class AliasTarget
    {
        [Required(true)]
        public String HostedZoneId { get; set; }

        [Required(true)]
        public String DNSName { get; set; }
        public bool? EvaluateTargetHealth { get; set; }
    }

}
