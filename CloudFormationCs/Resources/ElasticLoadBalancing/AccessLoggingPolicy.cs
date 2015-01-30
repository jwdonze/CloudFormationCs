using System;

namespace CloudFormationCs.Resources.ElasticLoadBalancing
{
    public class AccessLoggingPolicy
    {
        [Required(false)]
        public Int32 EmitInterval { get; set; }

        [Required(true)]
        public Boolean Enabled { get; set; }

        [Required(false)]
        public String S3BucketName { get; set; }

        [Required(false)]
        public String S3BucketPrefix { get; set; }
    }
}
