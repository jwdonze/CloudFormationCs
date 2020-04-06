using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html
    /// </summary>
    public class VPCEndpoint : Resource
    {
        //"PolicyDocument" : Json,
        //    "PrivateDnsEnabled" : Boolean,
        public StringRef[] SecurityGroupIds { get; set; }

        [JsonIgnore]
        public StringRef SecurityGroupId { set { this.SecurityGroupIds = new StringRef[] { value, }; } }

        public StringRef[] SubnetIds { get; set; }
        public StringRef[] RouteTableIds { get; set; }
        [JsonIgnore]
        public StringRef RouteTableId { set { this.RouteTableIds = new StringRef[] { value, }; } }
        /// <summary>
        /// The easiest way to get this is start to create one from the console.
        /// </summary>
        public StringRef ServiceName { get; set; }
        public VpcEndpointTypes VpcEndpointType { get; set; }
        public StringRef VpcId { get; set; }
        public bool? PrivateDnsEnabled { get; set; }

        public VPCEndpoint()
            : base()
        {
        }

        public VPCEndpoint(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
        public enum VpcEndpointTypes
        {
            Gateway,
            Interface,
        }
    }
}
