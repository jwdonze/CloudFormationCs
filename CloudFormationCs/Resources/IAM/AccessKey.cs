using System;

namespace CloudFormationCs.Resources.IAM
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html
    /// </summary>
    public class AccessKey : Resource
    {
        [Required(false)]
        public Int32 Serial { get; set; }

        [Required(true)]
        public String Status { get; set; }

        [Required(true)]
        public StringRef UserName { get; set; }

        public AccessKey()
            : base()
        {
        }

        public AccessKey(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
