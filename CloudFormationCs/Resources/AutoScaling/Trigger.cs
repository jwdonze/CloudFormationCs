using System;
using System.Web.Script.Serialization;


namespace CloudFormationCs.Resources.AutoScaling
{
    public class Trigger : Resource
    {
        public StringRef AutoScalingGroupName { get; set; }

        public String BreachDuration { get; set; }

        public CloudWatch.MetricDimension[] Dimensions { get; set; }

        [ScriptIgnore]
        public CloudWatch.MetricDimension Dimensions1 { set { this.Dimensions = new CloudWatch.MetricDimension[] { value, }; } }

        public String LowerBreachScaleIncrement { get; set; }

        public String LowerThreshold { get; set; }

        public String MetricName { get; set; }

        public String Namespace { get; set; }

        public String Period { get; set; }

        public String Statistic { get; set; }

        public String Unit { get; set; }

        public String UpperBreachScaleIncrement { get; set; }

        public String UpperThreshold { get; set; }

        public Trigger()
            : base()
        {
        }

        public Trigger(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
