using System;

namespace CloudFormationCs.Resources.SQS
{
    public class QueuePolicy : Resource
    {
        public QueuePolicy()
            : base()
        {
        }

        public QueuePolicy(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
