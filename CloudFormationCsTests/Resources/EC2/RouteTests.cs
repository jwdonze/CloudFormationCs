using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;
using System.Collections.Generic;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class RouteTests
    {
        [Test()]
        public void RouteGateway()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""PublicRoute1"" : 
                    {
                        ""Type"" : ""AWS::EC2::Route"",            
                        ""Properties"" : 
                        {
                            ""RouteTableId"" : 
                            {
                                ""Ref"" : ""PublicRouteTable1""
                            },                
                            ""DestinationCidrBlock"" : ""0.0.0.0/0"",                
                            ""GatewayId"" : 
                            {
                                ""Ref"" : ""InternetGateway1""
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
                    new EC2.Route("PublicRoute1")
                    {
                        RouteTableId = new CFN.Ref("PublicRouteTable1"),
                        DestinationCidrBlock = "0.0.0.0/0",
                        GatewayId = new CFN.Ref("InternetGateway1"),
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
        [Test()]
        public void RouteEni()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""PublicRoute1"" : 
                    {
                        ""Type"" : ""AWS::EC2::Route"",            
                        ""Properties"" : 
                        {
                            ""RouteTableId"" : 
                            {
                                ""Ref"" : ""PublicRouteTable1""
                            },                
                            ""DestinationCidrBlock"" : ""10.0.10.0/24"",                
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
                    new EC2.Route("PublicRoute1")
                    {
                        RouteTableId = new CFN.Ref("PublicRouteTable1"),
                        DestinationCidrBlock = "10.0.10.0/24",
                        NetworkInterfaceId = new CFN.Ref("Eni1"),
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
