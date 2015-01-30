using System;

namespace CloudFormationCs.Resources.ElasticBeanstalk
{
    public class EnvironmentTier
    {
        [Required(false)]
        public String Name { get; set; }

        [Required(false)]
        public String Type { get; set; }

        [Required(false)]
        public String Version { get; set; }
    }
}
