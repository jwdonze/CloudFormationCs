using System;

namespace CloudFormationCs.Entity
{
	public class PrivateIpAddressSpecification
	{
		[Required(true)]
		public String PrivateIpAddress { get; set; }
		
		[Required(true)]
		public Boolean Primary { get; set; }

		public PrivateIpAddressSpecification ()
		{
		}
	}
}

