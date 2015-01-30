using System;

namespace CloudFormationCs.Resources.AutoScaling
{
    public class ScheduledAction : Resource
    {
        public String AutoScalingGroupName { get; set; }

        public Int32 DesiredCapacity { get; set; }

        public DateTime EndTime { get; set; }

        public Int32 MaxSize { get; set; }

        public Int32 MinSize { get; set; }

        public String Recurrence { get; set; }

        public DateTime StartTime { get; set; }

        public ScheduledAction()
            : base()
        {
        }

        public ScheduledAction(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
