using System;

namespace CloudFormationCs.Resources.OpsWorks
{
    public class Source
    {
        [Required(false)]
        public String Password { get; set; }

        [Required(false)]
        public String Revision { get; set; }

        [Required(false)]
        public String SshKey { get; set; }

        [Required(false)]
        public String Type { get; set; }

        [Required(false)]
        public String Url { get; set; }

        [Required(false)]
        public String Username { get; set; }
    }
}
