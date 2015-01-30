using System;

namespace CloudFormationCs.Resources.ElasticBeanstalk
{
    public class SourceBundle
    {
        [Required(true)]
        public String S3Bucket { get; set; }

        [Required(true)]
        public String S3Key { get; set; }
    }
}
