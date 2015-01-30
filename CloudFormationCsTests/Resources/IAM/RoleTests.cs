using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using IAM = CloudFormationCs.Resources.IAM;
using EC2 = CloudFormationCs.Resources.EC2;
using AutoScaling = CloudFormationCs.Resources.AutoScaling;

namespace CloudFormationCsTests.Resources.IAMTests
{
    [TestFixture()]
    public class RoleTests
    {
        [Test()]
        public void IAMRole()
        {
            // http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html
            // - IAM Role with AutoScaling Group
            // changes to expected:
            //   RolePolicies Statement Action (added square brackets)
            var target = @"
			{
			   ""AWSTemplateFormatVersion"": ""2010-09-09"",
			   ""Resources"": {
			      ""RootRole"": {
			         ""Type"": ""AWS::IAM::Role"",
			         ""Properties"": {
			            ""AssumeRolePolicyDocument"": {
			               ""Version"" : ""2012-10-17"",
			               ""Statement"": [ {
			                  ""Effect"": ""Allow"",
			                  ""Principal"": {
			                     ""Service"": [ ""ec2.amazonaws.com"" ]
			                  },
			                  ""Action"": [ ""sts:AssumeRole"" ]
			               } ]
			            },
			            ""Path"": ""/""
			         }
			      },
			      ""RolePolicies"": {
			         ""Type"": ""AWS::IAM::Policy"",
			         ""Properties"": {
			            ""PolicyName"": ""root"",
			            ""PolicyDocument"": {
			               ""Version"" : ""2012-10-17"",
			               ""Statement"": [ {
			                  ""Effect"": ""Allow"",
			                  ""Action"": [ ""*"" ],
			                  ""Resource"": ""*""
			               } ]
			            },
			            ""Roles"": [ { ""Ref"": ""RootRole"" } ]
			         }
			      },
			      ""RootInstanceProfile"": {
			         ""Type"": ""AWS::IAM::InstanceProfile"",
			         ""Properties"": {
			            ""Path"": ""/"",
			            ""Roles"": [ { ""Ref"": ""RootRole"" } ]
			         }
			      }
			   }
			}  
";
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                  //""myLCOne"": {
                  //   ""Type"": ""AWS::AutoScaling::LaunchConfiguration"",
                  //   ""Version"": ""2009-05-15"",
                  //   ""Properties"": {
                  //      ""ImageId"": ""ami-205fba49"",
                  //      ""InstanceType"": ""m1.small"",
                  //      ""InstanceMonitoring"": ""true"",
                  //      ""IamInstanceProfile"": { ""Ref"": ""RootInstanceProfile"" }
                  //   }
                  //},
                  //""myASGrpOne"": {
                  //   ""Type"": ""AWS::AutoScaling::AutoScalingGroup"",
                  //   ""Version"": ""2009-05-15"",
                  //   ""Properties"": {
                  //      ""AvailabilityZones"": [ ""us-east-1a"" ],
                  //      ""LaunchConfigurationName"": { ""Ref"": ""myLCOne"" },
                  //      ""MinSize"": ""0"",
                  //      ""MaxSize"": ""0"",
                  //      ""HealthCheckType"": ""EC2"",
                  //      ""HealthCheckGracePeriod"": ""120""
                  //   }
                  //},
                  //  new AutoScaling.LaunchConfiguration("myLCOne")
                  //  {

                  //      Version = "2009-05-15",
                  //      ImageId = "ami-205fba49",
                  //      InstanceType = "m1.small",
                  //      InstanceMonitoring = true,
                  //      IamInstanceProfile = new CFN.Ref("RootInstanceProfile"),
                  //  },
                  //  new AutoScaling.AutoScalingGroup("myASGrpOne")
                  //  {
                  //      Version = "2009-05-15",
                  //      AvailabilityZones = new CFN.StringRef[] { "us-east-1a" },
                  //      LaunchConfigurationName = new CFN.Ref("myLCOne"),
                  //      MinSize = "0",
                  //      MaxSize = "0",
                  //      HealthCheckType = "EC2",
                  //      HealthCheckGracePeriod = 120
                  //  },
                    new IAM.Role("RootRole")
                    {
                        AssumeRolePolicyDocument = new IAM.PolicyDocument()
                        {
                            Version = "2012-10-17",
                            Statement = new IAM.Statement[]
                            {
                                new IAM.Statement()
                                {
                                    Effect = IAM.Statement.Effects.Allow,
                                    Action = new IAM.PolicyDocumentStatementActions[]
                                    {
                                        IAM.PolicyDocumentStatementActions.sts_AssumeRole,
                                    },
                                    Principal = new IAM.Principal()
                                    {
                                        Service1 = "ec2.amazonaws.com",
                                    },
                                },
                            },
                        },
                        Path = "/",
                    },
                    new IAM.Policy("RolePolicies")
                    {
                        PolicyName = "root",
                        PolicyDocument = new IAM.PolicyDocument()
                        {
                            Version = "2012-10-17",
                            Statement = new IAM.Statement[]
                            {
                                new IAM.Statement()
                                {
                                    Effect = IAM.Statement.Effects.Allow,
                                    Action = new IAM.PolicyDocumentStatementActions[]
                                    {
                                        IAM.PolicyDocumentStatementActions.STAR,
                                    },
                                    Resource = "*",
                                },
                            },
                        },
                        Roles1 = new CFN.Ref("RootRole"),
                    },
                    new IAM.InstanceProfile("RootInstanceProfile")
                    {
                        Path = "/",
                        Roles1 = new CFN.Ref("RootRole"),
                    },
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
