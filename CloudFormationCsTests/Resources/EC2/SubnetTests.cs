using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;
using System.Collections.Generic;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class SubnetTests
    {
        [Test()]
        public void Subnet()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""PublicSubnet1"" : 
                    {
                        ""Type"" : ""AWS::EC2::Subnet"",            
                        ""Properties"" : 
                        {
                            ""VpcId"" : 
                            {
                                ""Ref"" : ""VPC1""
                            },                
                            ""CidrBlock"" : ""10.1.0.0/24"",                
                            ""AvailabilityZone"" : 
                            {
                                ""Fn::FindInMap"" : [""AZs"",                        
                                    {
                                        ""Ref"" : ""AWS::Region""
                                    },                        
                                    ""AZ""]
                            },                
                            ""Tags"" : [
                                {
                                    ""Key"" : ""Name"",                        
                                    ""Value"" : ""VPC1 - PublicSubnet""
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
                    new EC2.Subnet("PublicSubnet1")
                    {
                        VpcId = new CFN.Ref("VPC1"),
                        CidrBlock = "10.1.0.0/24",
                        AvailabilityZone = new CFN.Fn__FindInMap("AZs", new CFN.Ref("AWS::Region"), "AZ"),
                        Tags = new CFN.Tag[]{
                            new CFN.Tag("Name", "VPC1 - PublicSubnet")
                        },
                    }
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
