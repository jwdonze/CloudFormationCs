using System;

namespace CloudFormationCs.Resources.CloudFront
{
    public class DistributionConfig
    {
        public string Comment { get; set; }
        public CacheBehavior DefaultCacheBehavior { get; set; }
        [EmitAsString]
        public bool Enabled { get; set; }
        public Origin[] Origins { get; set; }
        public string PriceClass { get; set; }
    }
}
