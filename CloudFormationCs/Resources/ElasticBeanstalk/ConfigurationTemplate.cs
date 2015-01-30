using System;

namespace CloudFormationCs.Resources.ElasticBeanstalk
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html
    /// </summary>
    public class ConfigurationTemplate : Resource
    {
        [Required(true)]
        public String ApplicationName { get; set; }

        [Required(false)]
        public String Description { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String EnvironmentId { get; set; }

        [Required(false)]
        public OptionSetting[] OptionSettings { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String SolutionStackName { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public SourceConfiguration SourceConfiguration { get; set; }

        public ConfigurationTemplate()
            : base()
        {
        }

        public ConfigurationTemplate(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
