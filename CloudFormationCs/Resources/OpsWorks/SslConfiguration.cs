using System;

namespace CloudFormationCs.Resources.OpsWorks
{
	public class SslConfiguration
	{
		[Required(true)]
		public String Certificate { get; set; }
		
		[Required(false)]
		public String Chain { get; set; }
		
		[Required(true)]
		public String PrivateKey { get; set; }
	}
}
