using System;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class WaitConditionHandle : Resource
    {
        public WaitConditionHandle()
            : base()
        {
        }

        public WaitConditionHandle(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
