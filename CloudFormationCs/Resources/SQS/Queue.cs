using System;

namespace CloudFormationCs.Resources.SQS
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html
    /// </summary>
    public class Queue : Resource
    {
        [Required(false)]
        public int DelaySeconds { get; set; }

        [Required(false)]
        public int MaximumMessageSize { get; set; }

        [Required(false)]
        public int MessageRetentionPeriod { get; set; }

        [Required(false)]
        public String QueueName { get; set; }

        [Required(false)]
        public int ReceiveMessageWaitTimeSeconds { get; set; }

        [Required(false)]
        public RedrivePolicy RedrivePolicy { get; set; }

        [Required(false)]
        public int VisibilityTimeout { get; set; }

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
