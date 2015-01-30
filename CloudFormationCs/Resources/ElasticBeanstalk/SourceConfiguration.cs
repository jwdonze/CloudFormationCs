using System;

namespace CloudFormationCs.Resources.ElasticBeanstalk
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html
    /// </summary>
    public class SourceConfiguration
    {
        [Required(true)]
        public String ApplicationName { get; set; }

        [Required(true)]
        public String TemplateName { get; set; }
    }
}
