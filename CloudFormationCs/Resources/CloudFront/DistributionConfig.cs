using CloudFormationCs.Converters;
using Newtonsoft.Json;
using System;

namespace CloudFormationCs.Resources.CloudFront
{
    public class DistributionConfig
    {
        public string Comment { get; set; }
        public CacheBehavior DefaultCacheBehavior { get; set; }
        [JsonConverter(typeof(LowerCaseStringConverter))]
        public bool Enabled { get; set; }
        public Origin[] Origins { get; set; }
        public string PriceClass { get; set; }
        public string HttpVersion { get; set; }
    }
}
