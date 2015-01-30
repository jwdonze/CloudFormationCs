using System;

namespace CloudFormationCs.Resources.ElasticBeanstalk
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html
    /// </summary>
    public class Application : Resource
    {
        [Required(false)]
        public String ApplicationName { get; set; }

        [Required(false)]
        public String Description { get; set; }

        public Application()
            : base()
        {
        }

        public Application(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
