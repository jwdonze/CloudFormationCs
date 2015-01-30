using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.CloudFront
{
    public class CacheBehavior
    {
        public ForwardedValues ForwardedValues { get; set; }
        public string MinTTL { get; set; }
        public string TargetOriginId { get; set; }
        public string ViewerProtocolPolicy { get; set; }
    }
}
