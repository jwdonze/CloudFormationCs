using System;

namespace CloudFormationCs.Resources.OpsWorks
{
	public class StackConfigurationManager
	{
		[Required(false)]
		public String Name { get; set; }
		
		[Required(false)]
		public String Version { get; set; }
	}
}
