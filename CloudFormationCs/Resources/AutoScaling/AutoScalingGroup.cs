using System;
using System.Web.Script.Serialization;

namespace CloudFormationCs.Resources.AutoScaling
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html
    /// </summary>
    public class AutoScalingGroup : Resource
    {
        [ScriptIgnore]
        public StringRef AvailabilityZone { set { this.AvailabilityZones = new StringRef[] { value, }; } }

        //[CompressSingleArray]
        public StringRef[] AvailabilityZones { get; set; }

        public String Cooldown { get; set; }

        public String DesiredCapacity { get; set; }

        [EmitAsString]
        public Int16 HealthCheckGracePeriod { get; set; }

        public String HealthCheckType { get; set; }

        public String InstanceId { get; set; }

        public StringRef LaunchConfigurationName { get; set; }

        [ScriptIgnore]
        public StringRef LoadBalancerName { set { this.LoadBalancerNames = new StringRef[] { value, }; } }

        public StringRef[] LoadBalancerNames { get; set; }

        public String MaxSize { get; set; }

        public String MinSize { get; set; }

        public NotificationConfiguration NotificationConfiguration { get; set; }

        public AsgTag[] Tags { get; set; }

        public String[] TerminationPolicies { get; set; }

        /// <summary>
        /// Subnets
        /// </summary>
        public String[] VPCZoneIdentifier { get; set; }

        public AutoScalingGroup()
            : base()
        {
        }

        public AutoScalingGroup(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
