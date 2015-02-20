using System;

namespace CloudFormationCs.Resources.IAM
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html
    /// </summary>
    public class UserToGroupAddition : Resource
    {
        [Required(true)]
        public String GroupName { get; set; }

        [Required(true)]
        public StringRef[] Users { get; set; }

        public UserToGroupAddition()
            : base()
        {
        }

        public UserToGroupAddition(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
