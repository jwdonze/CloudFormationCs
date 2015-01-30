using System;

namespace CloudFormationCs.Resources.ElasticLoadBalancing
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html
    /// </summary>
    public class LoadBalancer : Resource
    {
        [Required(false)]
        public AccessLoggingPolicy AccessLoggingPolicy { get; set; }

        [Required(false)]
        public AppCookieStickinessPolicy[] AppCookieStickinessPolicy { get; set; }

        [Required(false)]
        public String[] AvailabilityZones { get; set; }

        [Required(false)]
        public ConnectionDrainingPolicy ConnectionDrainingPolicy { get; set; }

        [Required(false)]
        public Boolean CrossZone { get; set; }

        [Required(false)]
        public HealthCheck HealthCheck { get; set; }

        [Required(false)]
        public String[] Instances { get; set; }

        [Required(false)]
        public LBCookieStickinessPolicy[] LBCookieStickinessPolicy { get; set; }

        [Required(false)]
        public String LoadBalancerName { get; set; }

        [Required(true)]
        public Listener[] Listeners { get; set; }

        [Required(false)]
        public ElasticLoadBalancingPolicy[] Policies { get; set; }

        [Required(false)]
        public String Scheme { get; set; }

        [Required(false)]
        public StringRef SecurityGroup { set { this.SecurityGroups = new StringRef[] { value, }; } }

        [Required(false)]
        public StringRef[] SecurityGroups { get; set; }

        [Required(false)]
        public StringRef[] Subnets { get; set; }

        public Tag[] Tags { get; set; }

        public LoadBalancer()
            : base()
        {
        }

        public LoadBalancer(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
