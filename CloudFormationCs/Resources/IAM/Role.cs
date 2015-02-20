using System;

namespace CloudFormationCs.Resources.IAM
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html
    /// </summary>
    public class Role : Resource
    {
        [Required(true)]
        public PolicyDocument AssumeRolePolicyDocument { get; set; }

        [Required(true)]
        public String Path { get; set; }

        [Required(false)]
        public Policy[] Policies { get; set; }

        public Role()
            : base()
        {
        }

        public Role(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
