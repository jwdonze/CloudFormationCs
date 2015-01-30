using System;

namespace CloudFormationCs.Resources.Redshift
{
	public class Parameter
	{
		[Required(true)]
		public String ParameterName { get; set; }
		
		[Required(true)]
		public String ParameterValue { get; set; }
	}
}
