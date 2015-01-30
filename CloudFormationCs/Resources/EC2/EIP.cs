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

        public enum Domains
        {
            Undefined,
            vpc,
            standard,
        }

        public EIP() : base() { }

        public EIP(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
        public EIP(string resourceIdentifier, Domains domain)
            : base(resourceIdentifier)
        {
            this.Domain = domain;
        }
    }
}
