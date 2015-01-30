using System;

namespace CloudFormationCs.Resources.AutoScaling
{
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

        public ScalingPolicy(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
