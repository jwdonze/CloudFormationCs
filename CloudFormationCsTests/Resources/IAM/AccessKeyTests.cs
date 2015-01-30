using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using IAM = CloudFormationCs.Resources.IAM;

namespace CloudFormationCsTests.Resources.IAMTests
{
    [TestFixture()]
    public class AccessKeyTests
    {
        [Test()]
        public void AccessKey()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""IAMUserAccessKey"" : 
                    {
                        ""Type"" : ""AWS::IAM::AccessKey"",            
                        ""Properties"" : 
                        {
                            ""UserName"" : 
                            {
                                ""Ref"" : ""IAMUser""
                            }
                        }
                    }        
                }
            }
";
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new IAM.AccessKey("IAMUserAccessKey")
                    {
                        UserName = new CFN.StringRef(new CFN.Ref("IAMUser")),
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
