using System;

namespace CloudFormationCs
{
	public static class References
	{
        public const string AllocationId = "AllocationId";
        public const string AWS__StackName = "AWS::StackName";
        public static Ref AWS__Region
        {
            get
            {
                return new Ref("AWS::Region");
            }
        }
    }
}

