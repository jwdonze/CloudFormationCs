using System;

namespace CloudFormationCs.Resources.AutoScaling
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html
    /// </summary>
    public class ScalingPolicy : Resource
    {
        public String AdjustmentType { get; set; }

        public StringRef AutoScalingGroupName { get; set; }

        public String Cooldown { get; set; }

        public String ScalingAdjustment { get; set; }

        public ScalingPolicy()
            : base()
        {
        }

        public ScalingPolicy(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
