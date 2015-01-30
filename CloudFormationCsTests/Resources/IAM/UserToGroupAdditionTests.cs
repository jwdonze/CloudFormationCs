using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using IAM = CloudFormationCs.Resources.IAM;

namespace CloudFormationCsTests.Resources.IAMTests
{
    [TestFixture()]
    public class UserToGroupAdditionTests
    {
        [Test()]
        public void UserToGroupAddition()
        {
            var target = @"
				{
				   ""AWSTemplateFormatVersion"": ""2010-09-09"",
				   ""Resources"": {
						""addUserToGroup"" : {
						   ""Type"" : ""AWS::IAM::UserToGroupAddition"",
						   ""Properties"" : {
						      ""GroupName"" : ""myexistinggroup2"",
						      ""Users"" : [ ""existinguser1"", { ""Ref"" : ""myuser"" } ]
						   }
						}
				   }
				}
";
			
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new IAM.UserToGroupAddition("addUserToGroup")
                    {
                        GroupName = "myexistinggroup2",
                        Users = new CFN.StringRef[]
                        {
                            "existinguser1",
                            new CFN.Ref("myuser"),
                        }
                    },
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
