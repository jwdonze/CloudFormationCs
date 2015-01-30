using System;

namespace CloudFormationCs.Resources.IAM
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html
    /// </summary>
    public class Group : Resource
    {
        [Required(false)]
        public String Path { get; set; }

        [Required(false)]
        public Policy[] Policies { get; set; }

        public Group()
            : base()
        {
        }

        public Group(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
