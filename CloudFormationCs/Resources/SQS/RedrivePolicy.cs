using System;

namespace CloudFormationCs.Resources.SQS
{
	public class RedrivePolicy
	{
		[Required(false)]
		public String deadLetterTargetArn { get; set; }
		
		[Required(false)]
		public Int32 maxReceiveCount { get; set; }
	}
}
