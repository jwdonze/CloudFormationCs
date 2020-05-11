namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-visibilityconfig.html
    ///</summary>
    public class VisibilityConfig
    {
        public Boolean? CloudWatchMetricsEnabled
        {
            get;
            set;
        }

        public StringRef MetricName
        {
            get;
            set;
        }

        public Boolean? SampledRequestsEnabled
        {
            get;
            set;
        }
    }
}