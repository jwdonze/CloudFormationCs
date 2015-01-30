using System;

using NUnit.Framework;

using CFN = CloudFormationCs;
using System.Collections.Generic;

namespace CloudFormationCsTests
{
    [TestFixture]
    public class MappingTests
    {
        [Test]
        public void Mapping()
        {
            var target = @"{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Mappings"" : {
					""AWSInstanceType2Arch"" : {
						""t2.micro""    : { ""Arch"" : ""64"" },
						""t2.small""    : { ""Arch"" : ""32"" },
						""m3.large""    : { ""Arch"" : ""64"" },
						""m3.xlarge""   : { ""Arch"" : ""64"" },
						""cg1.4xlarge"" : { ""Arch"" : ""64HVM"" }
					},
					""AWSRegionArch2AMI"" : {
						""us-east-1"" : { ""32"" : ""ami-6411e20d"", ""64"" : ""ami-7a11e213"", ""64HVM"" : ""NOT_YET_SUPPORTED"" },
						""us-west-1"" : { ""32"" : ""ami-c9c7978c"", ""64"" : ""ami-cfc7978a"", ""64HVM"" : ""NOT_YET_SUPPORTED"" }
					}
				}
			} ";

            var template = new CFN.Template()
            {
                Mappings = new CFN.IKeyValue[]
                {
                    new CFN.Mappings.InstanceType2Arch("AWSInstanceType2Arch",
                        new Dictionary<CFN.InstanceTypes, CFN.ArchTypes>()
                        {
                            { CFN.InstanceTypes.t2_micro, CFN.ArchTypes._64 },
                            { CFN.InstanceTypes.t2_small, CFN.ArchTypes._32 },
                            { CFN.InstanceTypes.m3_large, CFN.ArchTypes._64 },
                            { CFN.InstanceTypes.m3_xlarge, CFN.ArchTypes._64 },
                            { CFN.InstanceTypes.cg1_4xlarge, CFN.ArchTypes._64HVM },
                        }),

                    new CFN.Mappings.RegionArch2AMI("AWSRegionArch2AMI",
                        new Dictionary<CFN.Regions, Dictionary<CFN.ArchTypes, String>>()
                        {
                            { 
                                CFN.Regions.us_east_1, new Dictionary<CFN.ArchTypes, String>()
                                {
                                    { CFN.ArchTypes._32, "ami-6411e20d" },
                                    { CFN.ArchTypes._64, "ami-7a11e213" },
                                    { CFN.ArchTypes._64HVM, "NOT_YET_SUPPORTED" },
                                }
                            },
                            { 
							CFN.Regions.us_west_1, new Dictionary<CFN.ArchTypes, String>()
							{
								{ CFN.ArchTypes._32, "ami-c9c7978c" },
								{ CFN.ArchTypes._64, "ami-cfc7978a" },
								{ CFN.ArchTypes._64HVM, "NOT_YET_SUPPORTED" },
							}
						},
					}),
				},
			};

			Assert.IsTrue (CompareUtils.TemplatesAreEqual (target, template));
		}
	}
}

