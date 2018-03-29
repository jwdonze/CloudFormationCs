using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using CloudFormation = CloudFormationCs.Resources.CloudFormation;
using System.Collections.Generic;

namespace CloudFormationCsTests.Resources.CloudFormationTests
{
    [TestFixture()]
    public class WaitConditionTests
    {
        [Test()]
        public void WaitCondition()
        {
            // This isn't needed but it's also not causing an error, so leaving it:
            //      "Properties": {},
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""WaitHandle"" : 
                    {
                        ""Properties"": {},
                        ""Type"" : ""AWS::CloudFormation::WaitConditionHandle""
                    },        
                    ""SetupWaitCondition"" : 
                    {
                        ""Type"" : ""AWS::CloudFormation::WaitCondition"",            
                        ""Properties"" : 
                        {
                            ""Handle"" : 
                            {
                                ""Ref"" : ""WaitHandle""
                            },                
                            ""Timeout"" : ""1800"",                
                            ""Count"" : ""2""
                        }
                    }
                }
            }
";
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new CFN.Resources.CloudFormation.WaitConditionHandle("WaitHandle"),
                    new CFN.Resources.CloudFormation.WaitCondition("SetupWaitCondition")
                    {
                        Handle = new CFN.Ref("WaitHandle"),
                        Timeout = 1800,
                        Count = 2,
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
