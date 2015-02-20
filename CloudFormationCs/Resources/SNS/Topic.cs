using System;

namespace CloudFormationCs.Resources.SNS
{
    public class Topic : Resource
    {
        public Topic()
            : base()
        {
        }

        public Topic(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
