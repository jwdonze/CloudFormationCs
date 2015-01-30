using System;

namespace CloudFormationCs.Resources.S3
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html
    /// </summary>
    public class BucketPolicy : Resource
    {
        [Required(true)]
        public String Bucket { get; set; }

        [Required(true)]
        public Entity.JSON PolicyDocument { get; set; }

        public BucketPolicy()
            : base()
        {
        }

        public BucketPolicy(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
