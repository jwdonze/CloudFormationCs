using System;

namespace CloudFormationCs.Resources.ElasticBeanstalk
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-sourcebundle.html
    /// </summary>
    public class ApplicationVersion : Resource
    {
        [Required(true)]
        public String ApplicationName { get; set; }

        [Required(false)]
        public String Description { get; set; }

        [Required(false)]
        public SourceBundle SourceBundle { get; set; }

        public ApplicationVersion()
            : base()
        {
        }

        public ApplicationVersion(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
