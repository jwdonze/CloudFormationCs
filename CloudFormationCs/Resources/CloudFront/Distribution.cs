using System;

namespace CloudFormationCs.Resources.CloudFront
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-distribution.html
    /// </summary>
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
