using System;

namespace CloudFormationCs.Resources.SQS
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues-redrivepolicy.html
    /// </summary>
    public class Queue : Resource
    {
        public Queue()
            : base()
        {
        }

        public Queue(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
