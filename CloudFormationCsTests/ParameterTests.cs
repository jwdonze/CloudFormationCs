using System;

using NUnit.Framework;

using CFN = CloudFormationCs;

namespace CloudFormationCsTests
{
    [TestFixture]
    public class ParameterTests
    {
        [Test]
        public void Parameter()
        {
            var target = @"{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Parameters"" : {
					""InstanceType"" : {
						""Description"" : ""Type of EC2 instance to launch"",
						""Type"" : ""String"",
						""Default"" : ""m1.small""
					},
					""WebServerPort"" : {
						""Description"" : ""TCP/IP port of the web server"",
						""Type"" : ""String"",
						""Default"" : ""8888""
					},
					""KeyName"" : {
						""Description"" : ""Name of an existing EC2 KeyPair to enable SSH access to the instances"",
					""Type"" : ""String""
					}
				}
			} ";
            var template = new CFN.Template()
            {
                Parameters = new CFN.Parameter[]
                {
                    new CFN.Parameter("InstanceType")
                    {
                        Description = "Type of EC2 instance to launch",
                        Type = CFN.ParameterTypes.String,
                        Default = "m1.small",
                    },
                    new CFN.Parameter("WebServerPort")
                    {
                        Description = "TCP/IP port of the web server",
                        Type = CFN.ParameterTypes.String,
                        Default = "8888",
                    },
                    new CFN.Parameter("KeyName")
                    {
                        Description = "Name of an existing EC2 KeyPair to enable SSH access to the instances",
                        Type = CFN.ParameterTypes.String,
                    },
                }
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}

