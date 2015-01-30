using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using NUnit.Framework;
using System.Text;

namespace CloudFormationCsTests
{
    [TestFixture]
    public class CompareTests
    {
        [Test()]
        public void Identical()
        {
            var target = @"
{
	""AWSTemplateFormatVersion"" : ""2010-09-09"",
	""Description"" : ""Ec2 block device mapping"",
	""Resources"" : {
			 ""WorkerUser"" : {
			      ""Type"" : ""AWS::IAM::User"",
			      ""Properties"" : {
			        ""Path"": ""/"",
			        ""Policies"": [{
			          ""PolicyName"": ""root"",
			          ""PolicyDocument"": {
			            ""Version"": ""2012-10-17"",
			            ""Statement"":[{
			              ""Effect"": ""Allow"",
			              ""Action"": [
			                ""cloudformation:DescribeStackResource"",
			                ""sqs:ReceiveMessage"",
			                ""sqs:DeleteMessage"", 
			                ""sns:Publish""
			              ],
			              ""Resource"": ""*""
			            }]
			          }
			        }]
			      }
			    },
		""MyEC2Instance"" : {
			""Type"" : ""AWS::EC2::Instance"",
			""Properties"" : {
				""ImageId"" : ""ami-79fd7eee"",
				""KeyName"" : ""testkey"",
				""BlockDeviceMappings"" : [
					{
						""DeviceName"" : ""/dev/sdm"",
						""Ebs"" : {
							""VolumeType"" : ""io1"",
							""Iops"" : ""200"",
							""DeleteOnTermination"" : ""false"",
							""VolumeSize"" : ""20""
						}
					},
					{
						""DeviceName"" : ""/dev/sdk"",
						""NoDevice"" : {}
					}
				]
			}
		}
	}
}        
";
            var target2 = @"
{
	""AWSTemplateFormatVersion"" : ""2010-09-09"",
	""Description"" : ""Ec2 block device mapping"",
	""Resources"" : {
					 ""WorkerUser"" : {
					      ""Type"" : ""AWS::IAM::User"",
					      ""Properties"" : {
					        ""Path"": ""/"",
					        ""Policies"": [{
					          ""PolicyName"": ""root"",
					          ""PolicyDocument"": {
					            ""Version"": ""2012-10-17"",
					            ""Statement"":[{
					              ""Effect"": ""Allow"",
					              ""Action"": [
					                ""cloudformation:DescribeStackResource"",
					                ""sqs:DeleteMessage"", 
					                ""sns:Publish""
					              ],
					              ""Resource"": ""*""
					            }]
					          }
					        }]
					      }
					    },
		""MyEC2Instance"" : {
			""Type"" : ""AWS::EC2::Instance"",
			""Properties"" : {
				""ImageId"" : ""ami-79fd7eee"",
				""BlockDeviceMappings"" : [
					{
						""DeviceName"" : ""/dev/sdm"",
						""Ebs"" : {
							""VolumeType"" : ""io1"",
							""Iops"" : ""200"",
							""DeleteOnTermination"" : ""false"",
							""VolumeSize"" : ""20""
						}
					},
					{
						""DeviceName"" : ""/dev/sdk"",
						""NoDevice"" : {}
					}
				]
			}
		}
	}
}        
";
            var json = new JavaScriptSerializer();
			
			
            var ht1 = json.Deserialize<Dictionary<string, object>>(target);
            var ht2 = json.Deserialize<Dictionary<string, object>>(target);

            Console.WriteLine("test 1");
            Assert.IsTrue(CompareUtils.DictEquals(ht1, ht2));

            ht1 = json.Deserialize<Dictionary<string, object>>(target);
            ht2 = json.Deserialize<Dictionary<string, object>>(target2);

            Console.WriteLine("test 2");
            Assert.IsFalse(CompareUtils.DictEquals(ht1, ht2));
        }

    }
}

