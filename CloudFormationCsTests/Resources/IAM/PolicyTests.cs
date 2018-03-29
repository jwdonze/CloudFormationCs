using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using IAM = CloudFormationCs.Resources.IAM;
using System.Collections.Generic;

namespace CloudFormationCsTests.Resources.IAMTests
{
    [TestFixture()]
    public class PolicyTests
    {
        [Test()]
        public void Policy()
        {
            var target = @"
			{
			   ""AWSTemplateFormatVersion"": ""2010-09-09"",
			   ""Resources"": {
					""mypolicy"" : {
					   ""Type"" : ""AWS::IAM::Policy"",
					   ""Properties"" : {
					      ""PolicyName"" : ""mygrouppolicy"",
					      ""PolicyDocument"" : {
					         ""Version"": ""2012-10-17"",
					         ""Statement"" : [ {
					            ""Effect"" : ""Allow"",
					            ""Action"" : [
					               ""s3:GetObject"" , ""s3:PutObject"" , ""s3:PutObjectAcl"" ],
					            ""Resource"" : ""arn:aws:s3:::myAWSBucket/*""
					         } ]
					      },
					      ""Groups"" : [ ""myexistinggroup1"", { ""Ref"" : ""mygroup"" } ]
					   }
					}
			   }
			}
";
			
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new IAM.Policy("mypolicy")
                    {
                        PolicyName = "mygrouppolicy",
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
                                        IAM.PolicyDocumentStatementActions.s3_GetObject,
                                        IAM.PolicyDocumentStatementActions.s3_PutObject,
                                        IAM.PolicyDocumentStatementActions.s3_PutObjectAcl,
                                    },
                                    Resource = "arn:aws:s3:::myAWSBucket/*",
                                }
                            }
                        },
                        Groups = new CFN.StringRef[]
                        {
                            "myexistinggroup1",
                            new CFN.Ref("mygroup"),
                        }
                    },
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
