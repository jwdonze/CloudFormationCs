using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;
using System.Collections.Generic;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class RouteTableTests
    {
        [Test()]
        public void RouteTable()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""PublicRouteTable1"" : 
                    {
                        ""Type"" : ""AWS::EC2::RouteTable"",            
                        ""Properties"" : 
                        {
                            ""VpcId"" : 
                            {
                                ""Ref"" : ""VPC1""
                            },                
                            ""Tags"" : [
                                {
                                    ""Key"" : ""Name"",                        
                                    ""Value"" : ""VPC1 - PublicRouteTable""
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
                    new EC2.RouteTable("PublicRouteTable1")
                    {
                        VpcId = new CFN.Ref("VPC1"),
                        Tags = new CFN.Tag[]{
                            new CFN.Tag("Name", "VPC1 - PublicRouteTable")
                        },
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
