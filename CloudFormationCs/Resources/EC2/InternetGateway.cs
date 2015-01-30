using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-internet-gateway.html
    /// </summary>
    public class InternetGateway : Resource
    {
        public Tag[] Tags { get; set; }

        public InternetGateway()
            : base()
        {
        }

        public InternetGateway(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
