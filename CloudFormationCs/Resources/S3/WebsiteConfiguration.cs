using System;

namespace CloudFormationCs.Resources.S3
{
    public class WebsiteConfiguration
    {
        [Required(false)]
        public String IndexDocument { get; set; }

        [Required(false)]
        public String ErrorDocument { get; set; }
    }
}
