using System;

namespace CloudFormationCs.Resources.CloudFront
{
    public class Distribution : Resource
    {
        public DistributionConfig DistributionConfig { get; set; }

        public Distribution()
            : base()
        {
        }

        public Distribution(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
