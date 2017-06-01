using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.CloudFront
{
    public class CacheBehavior
    {
        public string[] AllowedMethods { get; set; }
        public string[] CachedMethods { get; set; }
        public bool? Compress { get; set; }
        public string DefaultTTL { get; set; }
        public ForwardedValues ForwardedValues { get; set; }
        public string MaxTTL { get; set; }
        public string MinTTL { get; set; }
        public bool? SmoothStreaming { get; set; }
        public string TargetOriginId { get; set; }
        public string[] TrustedSigners { get; set; }
        public string ViewerProtocolPolicy { get; set; }
    }
}
