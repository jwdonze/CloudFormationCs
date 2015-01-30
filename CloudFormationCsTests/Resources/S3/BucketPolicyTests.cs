using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using S3 = CloudFormationCs.Resources.S3;
using IAM = CloudFormationCs.Resources.IAM;

namespace CloudFormationCsTests.Resources.S3Tests
{
	[TestFixture()]
	public class BucketPolicyTests
	{
		//[Test()]
		public void TemplateOk()
		{
			var target = @"
			{
			   ""AWSTemplateFormatVersion"": ""2010-09-09"",
			   ""Resources"": {
					""mybucketpolicy"" : {
					   ""Type"" : ""AWS::S3::BucketPolicy"",
					   ""Properties"" : {
					      ""PolicyDocument"" : {
					         ""Id"" : ""MyPolicy"",
					         ""Version"": ""2012-10-17"",
					         ""Statement"" : [ {
					            ""Sid"" : ""ReadAccess"",
					            ""Action"" : [ ""s3:GetObject"" ],
					            ""Effect"" : ""Allow"",
					            ""Resource"" : { ""Fn::Join"" : [
					                  """", [ ""arn:aws:s3:::"", { ""Ref"" : ""mybucket"" } , ""/*"" ]
					               ] },
					            ""Principal"" : {
					               ""AWS"" : { ""Fn::GetAtt"" : [ ""mygroup"", ""Arn"" ] }
					            }
					         } ]
					      },
					      ""Bucket"" : { ""Ref"" : ""mybucket"" }
					      }
					   }
					} 
			   }
			}
";
			
//			var template = new CFN.Template ()
//			{
//				Resources = new CFN.ResourceBase[] {
//					new S3.BucketPolicy ("mybucketpolicy")
//					{
//
//						PolicyDocument = new IAM.PolicyDocument1()
//						{
//							Version = "2012-10-17",
//							Statement = new IAM.Statement1[]
//							{
//								new IAM.Statement1()
//								{
//									Effect = IAM.Statement.Effects.Allow,
//									Action = new IAM.Statement.Actions[]
//									{
//										IAM.Statement.Actions.s3_GetObject,
//										IAM.Statement.Actions.s3_PutObject,
//										IAM.Statement.Actions.s3_PutObjectAcl,
//									},
//									Resource = "arn:aws:s3:::myAWSBucket/*",
//								}
//							}
//						},
//						Groups = new CFN.StringRef[]
//						{
//							"myexistinggroup1",
//							new CFN.Ref("mygroup"),
//						}
//					},
//				},
//			};
//			
//			Assert.IsTrue (CompareUtils.TemplatesAreEqual(target, template));
		}
	}
}
