using System;

namespace CloudFormationCs.Resources.OpsWorks
{
    public class Recipes
    {
        [Required(false)]
        public String[] Configure { get; set; }

        [Required(false)]
        public String[] Deploy { get; set; }

        [Required(false)]
        public String[] Setup { get; set; }

        [Required(false)]
        public String[] Shutdown { get; set; }

        [Required(false)]
        public String[] Undeploy { get; set; }
    }
}
