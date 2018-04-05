using System.Collections.Generic;
using NUnit.Framework;

using CFN = CloudFormationCs;
using EC2 = CloudFormationCs.Resources.EC2;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class VolumeTests
    {
        [Test()]
        public void VolumeAndAttachment()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""Volume1"" : 
                    {
                        ""Type"" : ""AWS::EC2::Volume"",            
                        ""Properties"" : 
                        {
                            ""VolumeType"" : ""gp2""
                        }
                    },
                    ""Attachment1"" : 
                    {
                        ""Type"" : ""AWS::EC2::VolumeAttachment"",            
                        ""Properties"" : 
                        {
                            ""InstanceId"" : ""i-12345678"",                        
                            ""VolumeId"" : 
                            {
                                ""Ref"" : ""Volume1""
                            }
                        }
                    }
                }
            }
";
            var template = new CFN.Template()
            {
                Resources = new List<CFN.Resource>()
                {
                    new EC2.Volume("Volume1")
                    {
                        VolumeType = EC2.VolumeTypes.gp2,
                    },
                    new EC2.VolumeAttachment("Attachment1")
                    {
                        VolumeId = new CFN.Ref("Volume1"),
                        InstanceId = "i-12345678",
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
