namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-targetdescription.html
    /// </summary>
    public class TargetDescription
    {
        /// <summary>
        /// 'all' for ip addresses outside the VPC
        /// </summary>
        public string AvailabilityZone { get; set; }
        public StringRef Id { get; set; }
        public int Port { get; set; }
    }
    public class TargetDescriptionIp : TargetDescription
    {
        public TargetDescriptionIp() : base() { }
        public TargetDescriptionIp(StringRef ip, int port)
        {
            this.AvailabilityZone = "all";
            this.Id = ip;
            this.Port = port;
        }
    }
}