using System;

namespace CloudFormationCs.Resources.ElasticBeanstalk
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html
    /// </summary>
    public class OptionSetting
    {
        [Required(true)]
        public String Namespace { get; set; }

        [Required(true)]
        public String OptionName { get; set; }

        [Required(true)]
        public String Value { get; set; }
    }
}
