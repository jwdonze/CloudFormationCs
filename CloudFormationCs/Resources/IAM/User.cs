using System;

namespace CloudFormationCs.Resources.IAM
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html
    /// </summary>
    public class User : Resource
    {
        [Required(false)]
        public String Path { get; set; }

        [Required(false)]
        public String[] Groups { get; set; }

        [Required(false)]
        public LoginProfile LoginProfile { get; set; }

        [Required(false)]
        public Policy[] Policies { get; set; }

        public User()
            : base()
        {
        }

        public User(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
