using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using IAM = CloudFormationCs.Resources.IAM;
using EC2 = CloudFormationCs.Resources.EC2;
using AutoScaling = CloudFormationCs.Resources.AutoScaling;
using System.Collections.Generic;

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
              ""Statement"": [
                {
                  ""Effect"": ""Allow"",
                  ""Principal"": {
                    ""Service"": [
                      ""ec2.amazonaws.com""
                    ]
                  },
                  ""Action"": [
                    ""sts:AssumeRole""
                  ]
                }
              ]
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
            ""Statement"": [ 
              {
                 ""Effect"": ""Allow"",
                 ""Action"": [
                   ""*""
                 ],
                 ""Resource"": ""*""
              }
            ]
          },
          ""Roles"": [
            {
              ""Ref"": ""RootRole""
            }
          ]
        }
     },
     ""RootInstanceProfile"": {
       ""Type"": ""AWS::IAM::InstanceProfile"",
       ""Properties"": {
         ""Path"": ""/"",
         ""Roles"": [ 
           {
             ""Ref"": ""RootRole""
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
