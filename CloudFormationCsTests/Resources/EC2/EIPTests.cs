using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class EIPTests
    {
        [Test()]
        public void EIP()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""EIP1"" : 
                    {
                        ""Type"" : ""AWS::EC2::EIP"",            
                        ""Properties"" : 
                        {
                            ""Domain"" : ""vpc""
                        }
                    },        
                    ""EIP2"" : 
                    {
                        ""Type"" : ""AWS::EC2::EIP"",            
                        ""Properties"" : 
                        {
                            ""Domain"" : ""vpc""
                        }
                    }
                }
            }
";
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new EC2.EIP("EIP1")
                    {
                        Domain = EC2.EIP.Domains.vpc,
                    },
                    new EC2.EIP("EIP2")
                    {
                        Domain = EC2.EIP.Domains.vpc,
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
