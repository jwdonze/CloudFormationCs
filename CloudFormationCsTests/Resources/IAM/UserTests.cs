using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using IAM = CloudFormationCs.Resources.IAM;

namespace CloudFormationCsTests.Resources.IAMTests
{
    [TestFixture()]
    public class UserTests
    {
        [Test()]
        public void User()
        {
            var target = @"
			{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Resources"" : {
					 ""WorkerUser"" : {
					      ""Type"" : ""AWS::IAM::User"",
					      ""Properties"" : {
					        ""Path"": ""/"",
					      ""LoginProfile"" : {
					         ""Password"" : ""myP@ssW0rd""
					      },
					      ""Policies"" : [ {
					         ""PolicyName"" : ""giveaccesstoqueueonly"",
					         ""PolicyDocument"" : {
					            ""Version"": ""2012-10-17"",
					            ""Statement"" : [ {
					               ""Effect"" : ""Allow"",
					               ""Action"" : [ ""sqs:*"" ],
					               ""Resource"" : [ {
					                  ""Fn::GetAtt"" : [ ""myqueue"", ""Arn"" ]
					               } ]
					            }, {
					               ""Effect"" : ""Deny"",
					               ""Action"" : [ ""sqs:*"" ],
					               ""NotResource"" : [ {
					                  ""Fn::GetAtt"" : [ ""myqueue"", ""Arn"" ]
					               } ]
					            }
					         ] }
					      }, {
					         ""PolicyName"" : ""giveaccesstotopiconly"",
					         ""PolicyDocument"" : {
					            ""Version"": ""2012-10-17"",
					            ""Statement"" : [ {
					               ""Effect"" : ""Allow"",
					               ""Action"" : [ ""sns:*"" ],
					               ""Resource"" : [ { ""Ref"" : ""mytopic"" } ]
					            }, {
					               ""Effect"" : ""Deny"",
					               ""Action"" : [ ""sns:*"" ],
					               ""NotResource"" : [ { ""Ref"" : ""mytopic"" } ]
					            } ]
					         }
					      } ]
					      }
					 }
				}
			}        
";

            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new IAM.User("WorkerUser")
                    {
                        Path = "/",
                        LoginProfile = new IAM.LoginProfile()
                        {
                            Password = "myP@ssW0rd",
                        },
                        Policies = new IAM.Policy[]
                        {
                            new IAM.Policy()
                            {
                                PolicyName = "giveaccesstoqueueonly",
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
                                                IAM.PolicyDocumentStatementActions.sqs_STAR,
                                            },
                                            Resource1 = new CFN.Fn__GetAtt("myqueue", "Arn"),
                                        },
                                        new IAM.Statement()
                                        {
                                            Effect = IAM.Statement.Effects.Deny,
                                            Action = new IAM.PolicyDocumentStatementActions[]
                                            {
                                                IAM.PolicyDocumentStatementActions.sqs_STAR,
                                            },
                                            NotResource1 = new CFN.Fn__GetAtt("myqueue", "Arn"),
                                        },
                                    },
                                },
                            },
                            new IAM.Policy()
                            {
                                PolicyName = "giveaccesstotopiconly",
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
                                                IAM.PolicyDocumentStatementActions.sns_STAR,
                                            },
                                            Resource1 = new CFN.Ref("mytopic"),
                                        },
                                        new IAM.Statement()
                                        {
                                            Effect = IAM.Statement.Effects.Deny,
                                            Action = new IAM.PolicyDocumentStatementActions[]
                                            {
                                                IAM.PolicyDocumentStatementActions.sns_STAR,
                                            },
                                            NotResource1 = new CFN.Ref("mytopic"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
