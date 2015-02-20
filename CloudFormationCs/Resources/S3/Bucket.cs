using System;

namespace CloudFormationCs.Resources.S3
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html
    /// </summary>
    public class Bucket : Resource
    {
        [Required(false)]
        public String AccessControl { get; set; }

        [Required(false)]
        public String BucketName { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        [Required(false)]
        public WebsiteConfiguration WebsiteConfiguration { get; set; }

        public Bucket()
            : base()
        {
        }

        public Bucket(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
