using System;
namespace CloudFormationCs.Resources.EC2
{
	/// <summary>
	/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html
	/// </summary>
	public class VPNConnection : Resource
	{
		[Required(true)]
		public String Type { get; set; }
		
		[Required(true)]
		public String CustomerGatewayId { get; set; }
		
		[Required(RequiredAttribute.RequirementTypes.Conditional)]
		public Boolean StaticRoutesOnly { get; set; }
		
		[Required(false)]
        public Tag[] Tags { get; set; }
		
		[Required(true)]
		public String VpnGatewayId { get; set; }

		public VPNConnection () : base()
		{
		}
        public VPNConnection(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
		{
		}
	}
}
