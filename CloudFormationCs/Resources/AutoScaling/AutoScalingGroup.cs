using System;
using System.Web.Script.Serialization;

namespace CloudFormationCs.Resources.AutoScaling
{
    public class AutoScalingGroup : Resource
    {
        [ScriptIgnore]
        public StringRef AvailabilityZone { set { this.AvailabilityZones = new StringRef[] { value, }; } }

        [CompressSingleArray]
        public StringRef[] AvailabilityZones { get; set; }

        public String Cooldown { get; set; }

        public String DesiredCapacity { get; set; }

        [EmitAsString]
        public Int16 HealthCheckGracePeriod { get; set; }

        public String HealthCheckType { get; set; }

        public String InstanceId { get; set; }

        public StringRef LaunchConfigurationName { get; set; }

        public StringRef[] LoadBalancerNames { get; set; }

        public String MaxSize { get; set; }

        public String MinSize { get; set; }

        public NotificationConfiguration NotificationConfiguration { get; set; }

        public Tag[] Tags { get; set; }

        public String[] TerminationPolicies { get; set; }

        public String[] VPCZoneIdentifier { get; set; }

        public AutoScalingGroup()
            : base()
        {
        }

        public AutoScalingGroup(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
