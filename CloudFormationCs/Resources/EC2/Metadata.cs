using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html
    /// </summary>
    public class Metadata
    {
        public String Comment { get; set; }

        public CloudFormation.Init Init { get; set; }

        public static Metadata WithInit(CloudFormationCs.Resources.CloudFormation.config config)
        {
            return new EC2.Metadata()
                {
                    Init = new CloudFormationCs.Resources.CloudFormation.Init()
                    {
                        config = config,
                    },
                };
        }
    }
}
