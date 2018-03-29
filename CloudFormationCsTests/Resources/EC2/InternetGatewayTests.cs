using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;
using System.Collections.Generic;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class InternetGatewayTests
    {
        [Test()]
        public void InternetGateway()
        {
            var target = @"{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Resources"" : {
					""myInternetGateway"" : {
						""Type"" : ""AWS::EC2::InternetGateway"",
						""Properties"" : {
							""Tags"" : [ {""Key"" : ""Name"", ""Value"" : ""VPN1""}]
						}
					}
				}
			} ";
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new EC2.InternetGateway("myInternetGateway")
                    {
                        Tags = new CFN.Tag[]
                        {
                            new CFN.Tag("Name", "VPN1"),
                        },
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
