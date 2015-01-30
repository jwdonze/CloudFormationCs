using System;

namespace CloudFormationCs.Resources.CloudWatch
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cw-alarm.html
    /// </summary>
    public class MetricDimension
    {
        public String Name { get; set; }

        public StringRef Value { get; set; }
    }
}
