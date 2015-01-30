using System;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class WaitCondition : Resource
    {
        [EmitAsString]
        public int Count { get; set; }

        public StringRef Handle { get; set; }

        [EmitAsString]
        public Int16 Timeout { get; set; }

        public WaitCondition()
            : base()
        {
        }

        public WaitCondition(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
