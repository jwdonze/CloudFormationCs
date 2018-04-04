using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;

namespace CloudFormationCsTests
{
    [TestFixture]
    class FunctionTests
    {
        [Test]
        public void Fn__FindInMap()
        {
            var target = @"
			{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Resources"" : {
                    ""SecurityGroup1"" : 
                    {
                        ""Type"" : ""AWS::EC2::SecurityGroup"",            
                        ""Properties"" : 
                        {
                            ""VpcId"" : {""Fn::FindInMap"" : [""MapName"", ""Key1"", ""Key2""]}
                        }
                    }
                }
			}
";
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new EC2.SecurityGroup("SecurityGroup1")
                    {
                        VpcId = new CFN.Fn__FindInMap("MapName", "Key1", "Key2"),
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
        [Test]
        public void Fn__GetAtt()
        {
            var target = @"
			{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Resources"" : {
                    ""SecurityGroup1"" : 
                    {
                        ""Type"" : ""AWS::EC2::SecurityGroup"",            
                        ""Properties"" : 
                        {
                            ""SecurityGroupIngress"" : [
                                {
                                    ""SourceSecurityGroupName"" : {""Fn::GetAtt"" : [""ElasticLoadBalancer"", ""SourceSecurityGroup.GroupName""]}
                                }
                            ]
                        }
                    }
                }
			}
";
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new EC2.SecurityGroup("SecurityGroup1")
                    {
                        SecurityGroupIngress = new EC2.SecurityGroupRuleIngress[]
                        {
                            new EC2.SecurityGroupRuleIngress()
                            {
                                    SourceSecurityGroupName  = new CFN.Fn__GetAtt("ElasticLoadBalancer", "SourceSecurityGroup.GroupName"),
                            }
                        },
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
        [Test]
        public void Fn__Join()
        {
            var target = @"
			{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Resources"" : {
                    ""SecurityGroup1"" : 
                    {
                        ""Type"" : ""AWS::EC2::SecurityGroup"",            
                        ""Properties"" : 
                        {
                            ""SecurityGroupIngress"" : [
                                {
                                    ""SourceSecurityGroupName"" : {""Fn::Join"" : ["","", [""Line1"", ""Line2""]]}
                                }
                            ]
                        }
                    }
                }
			}
";
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new EC2.SecurityGroup("SecurityGroup1")
                    {
                        SecurityGroupIngress = new EC2.SecurityGroupRuleIngress[]
                        {
                            new EC2.SecurityGroupRuleIngress()
                            {
                                    SourceSecurityGroupName  = new CFN.Fn__Join(",", new CFN.StringRef[] {
                                        "Line1",
                                        "Line2",
                                    } ),
                            }
                        },
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
       
    }
}

