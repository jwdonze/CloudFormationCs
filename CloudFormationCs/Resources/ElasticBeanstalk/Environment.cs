using System;

namespace CloudFormationCs.Resources.ElasticBeanstalk
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html
    /// </summary>
    public class Environment
    {
        [Required(true)]
        public String ApplicationName { get; set; }

        [Required(false)]
        public String CNAMEPrefix { get; set; }

        [Required(false)]
        public String Description { get; set; }

        [Required(false)]
        public String EnvironmentName { get; set; }

        [Required(false)]
        public OptionSetting[] OptionSettings { get; set; }

        [Required(false)]
        public String SolutionStackName { get; set; }

        [Required(false)]
        public String TemplateName { get; set; }

        [Required(false)]
        public EnvironmentTier Tier { get; set; }

        [Required(false)]
        public String VersionLabel { get; set; }

        public Environment()
            : base()
        {
        }
    }
}
