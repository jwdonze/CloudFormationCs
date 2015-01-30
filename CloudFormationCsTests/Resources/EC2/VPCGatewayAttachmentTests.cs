using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class VPCGatewayAttachmentTests
    {
        [Test()]
        public void VPCGatewayAttachment()
        {
            var target = @"{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Resources"" : {
                    ""AttachGateway"" : 
                    {
                        ""Type"" : ""AWS::EC2::VPCGatewayAttachment"",            
                        ""Properties"" : 
                        {
                            ""VpcId"" : 
                            {
                                ""Ref"" : ""VPC1""
                            },                
                            ""InternetGatewayId"" : 
                            {
                                ""Ref"" : ""InternetGateway""
                            }
                        }
                    }
				}
			} ";
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new EC2.VPCGatewayAttachment("AttachGateway")
                    {
                        VpcId = new CFN.Ref("VPC1"),
                        InternetGatewayId = new CFN.Ref("InternetGateway"),
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
