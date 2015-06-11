using System;

namespace CloudFormationCs.Resources.Route53
{
    public class AliasTarget
    {
        [Required(true)]
        public StringRef HostedZoneId { get; set; }

        [Required(true)]
        public StringRef DNSName { get; set; }
        public bool? EvaluateTargetHealth { get; set; }
    }

}
