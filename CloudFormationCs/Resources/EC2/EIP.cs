using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html
    /// </summary>
    public class EIP : Resource
    {
        [Required(false)]
        public String InstanceId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public Domains Domain { get; set; }
        public Tag[] Tags { get; set; }

        public enum Domains
        {
            Undefined,
            vpc,
            standard,
        }

        public EIP() : base() { }

        public EIP(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
        public EIP(StringOrEnum resourceIdentifier, Domains domain)
            : base(resourceIdentifier)
        {
            this.Domain = domain;
        }
    }
}
