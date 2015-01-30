using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html
    /// </summary>
    public class EC2_PortRange
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public Int32 From { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public Int32 To { get; set; }
    }
}
