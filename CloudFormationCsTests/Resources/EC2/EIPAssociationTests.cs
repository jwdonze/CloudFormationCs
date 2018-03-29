using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;
using System.Collections.Generic;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class EIPAssociationTests
    {
        [Test()]
        public void AllocationGetAttToEni()
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
                    ""EIP1Assoc"" : 
                    {
                        ""Type"" : ""AWS::EC2::EIPAssociation"",            
                        ""DependsOn"" : ""InstanceResourceName1"",            
                        ""Properties"" : 
                        {
                            ""AllocationId"" : 
                            {
                                ""Fn::GetAtt"" : [""EIP1"",                        
                                    ""AllocationId""]
                            },                
                            ""NetworkInterfaceId"" : ""eni-12345678""
                        }
                    }
                }
            }
";
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new EC2.EIP("EIP1")
                    {
                        Domain = EC2.EIP.Domains.vpc,
                    },
                    new EC2.EIPAssociation("EIP1Assoc")
                    {
                        DependsOn = new string[] { "InstanceResourceName1", },
                        AllocationId = new CFN.Fn__GetAtt("AllocationId", "EIP1"), 
                        NetworkInterfaceId = "eni-12345678",
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
        [Test()]
        public void AllocationGetAttToEniRef()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""EIP1Assoc"" : 
                    {
                        ""Type"" : ""AWS::EC2::EIPAssociation"",            
                        ""Properties"" : 
                        {
                            ""AllocationId"" : ""eipalloc-12345678"",
                            ""NetworkInterfaceId"" : 
                            {
                                ""Ref"" : ""Eni1""
                            }
                        }
                    }
                }
            }
";
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new EC2.EIPAssociation("EIP1Assoc")
                    {
                        AllocationId = "eipalloc-12345678", 
                        NetworkInterfaceId = new CFN.Ref("Eni1"),
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
