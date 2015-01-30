using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class SecurityGroupTests
    {
        [Test()]
        public void SecurityGroup()
        {
            // http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html
            // http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html

            var target = @"
			{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Resources"" : {
                    ""SecurityGroup1"" : 
                    {
                        ""Type"" : ""AWS::EC2::SecurityGroup"",            
                        ""Properties"" : 
                        {
                            ""VpcId"" : 
                            {
                                ""Ref"" : ""VPC1""
                            },                
                            ""GroupDescription"" : ""Group 1 Rules"",                
                            ""SecurityGroupIngress"" : [
                                {
                                    ""IpProtocol"" : ""-1"",                        
                                    ""FromPort"" : ""-1"",                        
                                    ""ToPort"" : ""-1"",                        
                                    ""CidrIp"" : ""10.2.2.3/32""
                                },                    
                                {
                                    ""IpProtocol"" : ""icmp"",                        
                                    ""FromPort"" : ""-1"",                        
                                    ""ToPort"" : ""-1"",                        
                                    ""CidrIp"" : ""10.0.0.0/0""
                                },                    
                                {
                                    ""IpProtocol"" : ""tcp"",                        
                                    ""FromPort"" : ""456"",                        
                                    ""ToPort"" : ""789"",                        
                                    ""SourceSecurityGroupId"" : 
                                    {
                                        ""Ref"" : ""SecurityGroup2""
                                    }
                                },                    
                                {
                                    ""IpProtocol"" : ""udp"",                        
                                    ""FromPort"" : ""100"",                        
                                    ""ToPort"" : ""100"",                        
                                    ""CidrIp"" : ""0.0.0.0/0""
                                },
                                {
                                    ""IpProtocol"" : ""tcp"",
                                    ""FromPort"" : { ""Ref"" : ""WebServerPort"" },
                                    ""ToPort"" : { ""Ref"" : ""WebServerPort"" },
                                    ""SourceSecurityGroupOwnerId"" : {""Fn::GetAtt"" : [""ElasticLoadBalancer"", ""SourceSecurityGroup.OwnerAlias""]},
                                    ""SourceSecurityGroupName"" : {""Fn::GetAtt"" : [""ElasticLoadBalancer"", ""SourceSecurityGroup.GroupName""]}
                                }
                            ],
                            ""Tags"" : [
                                {
                                    ""Key"" : ""Name"",                        
                                    ""Value"" : ""VPC - SecurityGroup1""
                                }]
                        }
                    }
                }
			}
";
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new EC2.SecurityGroup("SecurityGroup1")
                    {
                        VpcId = new CFN.Ref("VPC1"),
                        GroupDescription = "Group 1 Rules",
                        SecurityGroupIngress = new EC2.SecurityGroupRuleIngress[]
                        {
                            new EC2.SecurityGroupRuleIngress()
                            {
                                IpProtocol = "-1",
                                FromPort = "-1",
                                ToPort = "-1",
                                CidrIp = "10.2.2.3/32",
                            },
                            new EC2.SecurityGroupRuleIngress()
                            {
                                IpProtocol = "icmp",
                                FromPort = "-1",
                                ToPort = "-1",
                                CidrIp = "10.0.0.0/0",
                            },
                            new EC2.SecurityGroupRuleIngress()
                            {
                                IpProtocol = "tcp",
                                FromPort = "456",
                                ToPort = "789",
                                SourceSecurityGroupId = new CFN.Ref("SecurityGroup2"),
                            },
                            new EC2.SecurityGroupRuleIngress()
                            {
                                IpProtocol = "udp",
                                FromPort = "100",
                                ToPort = "100",
                                CidrIp = "0.0.0.0/0",
                            },
                            new EC2.SecurityGroupRuleIngress()
                            {
                                    IpProtocol = "tcp",
                                    FromPort = new CFN.Ref("WebServerPort"),
                                    ToPort = new CFN.Ref("WebServerPort"),
                                    SourceSecurityGroupOwnerId = new CFN.Fn__GetAtt("ElasticLoadBalancer", "SourceSecurityGroup.OwnerAlias"),
                                    SourceSecurityGroupName  = new CFN.Fn__GetAtt("ElasticLoadBalancer", "SourceSecurityGroup.GroupName"),
                            }
                        },
                        Tags = new CFN.Tag[]
                        {
                            new CFN.Tag("Name", "VPC - SecurityGroup1"),
                        }
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
