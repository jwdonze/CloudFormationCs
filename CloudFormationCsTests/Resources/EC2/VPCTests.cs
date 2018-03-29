using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;
using System.Collections.Generic;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class VPCTests
    {
        [Test()]
        public void VPC()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""VPC1"" : 
                    {
                        ""Type"" : ""AWS::EC2::VPC"",            
                        ""Properties"" : 
                        {
                            ""CidrBlock"" : ""10.1.0.0/16"",                
                            ""Tags"" : [
                                {
                                    ""Key"" : ""Application"",                        
                                    ""Value"" : 
                                    {
                                        ""Ref"" : ""AWS::StackName""
                                    }
                                },                    
                                {
                                    ""Key"" : ""Network"",                        
                                    ""Value"" : ""Public""
                                },                    
                                {
                                    ""Key"" : ""Name"",                        
                                    ""Value"" : ""VPC1""
                                }]
                        }
                    }
                }
            }
";
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new EC2.VPC("VPC1")
                    {
                        CidrBlock = "10.1.0.0/16",
                        Tags = new CFN.Tag[]
                        {
                            new CFN.Tag("Application", new CFN.Ref("AWS::StackName")),
                            new CFN.Tag("Network", "Public"),
                            new CFN.Tag("Name", "VPC1"),
                        }
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
