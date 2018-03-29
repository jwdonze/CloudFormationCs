using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;
using System.Collections.Generic;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class SubnetRouteTableAssociationTests
    {
        [Test()]
        public void SubnetRouteTableAssociation()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""SubnetRouteTable1Association"" : 
                    {
                        ""Type"" : ""AWS::EC2::SubnetRouteTableAssociation"",            
                        ""Properties"" : 
                        {
                            ""SubnetId"" : 
                            {
                                ""Ref"" : ""PublicSubnet1""
                            },                
                            ""RouteTableId"" : 
                            {
                                ""Ref"" : ""PublicRouteTable1""
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
                    new EC2.SubnetRouteTableAssociation("SubnetRouteTable1Association")
                    {
                        SubnetId = new CFN.Ref("PublicSubnet1"),
                        RouteTableId = new CFN.Ref("PublicRouteTable1"),
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
