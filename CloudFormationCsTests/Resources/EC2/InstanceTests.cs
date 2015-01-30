using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

using CFN = CloudFormationCs;
using CFNR = CloudFormationCs.Resources.CloudFormation;
using EC2 = CloudFormationCs.Resources.EC2;

namespace CloudFormationCsTests.Resources.EC2Tests
{
    [TestFixture()]
    public class InstanceTests
    {
        [Test()]
        public void Instance()
        {
            var target = @"
			{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Description"" : ""Ec2 block device mapping"",
				""Resources"" : {
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
            var template = new CFN.Template()
            {
                Descrption = "Ec2 block device mapping",
                Resources = new CFN.Resource[]
                {
                    new EC2.Instance("MyEC2Instance")
                    {
                        ImageId = "ami-79fd7eee",
                        KeyName = "testkey",
                        BlockDeviceMappings = new CFN.Entity.BlockDeviceMapping[]
                        {
                            new CFN.Entity.BlockDeviceMapping()
                            {
                                DeviceName = "/dev/sdm",
                                Ebs = new CFN.Entity.Ebs()
                                {
                                    VolumeType =  CFN.VolumeTypes.io1,
                                    Iops = 200,
                                    DeleteOnTermination = false,
                                    VolumeSize = 20,
                                }
                            },
                            new CFN.Entity.BlockDeviceMapping()
                            {
                                DeviceName = "/dev/sdk",
                                NoDevice = new object(),
                            },
							
                        }						 
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }

        [Test()]
        public void InstanceMetadata()
        {
            var target = @"
			{
				""AWSTemplateFormatVersion"" : ""2010-09-09"",
				""Description"" : ""Ec2 metadata"",
				""Resources"" : {
					""MyEC2Instance"" : {
						""Type"" : ""AWS::EC2::Instance"",

						""Metadata"" : {
							  ""Comment"" : ""Cfn Comment"",
						      ""AWS::CloudFormation::Init"" : {

						        ""config"" : {

									""packages"" : {

										""rpm"" : {
											""epel"" : ""http://download.fedoraproject.org/pub/epel/5/i386/epel-release-5-4.noarch.rpm""
										},
										""yum"" : {
										  ""httpd"" : [],
										  ""php"" : []
										},
										""rubygems"" : {
										  ""chef"" : [ ""0.10.2"" ]
										}
									},

						          ""sources"" : {

									""/etc/puppet"" : ""https://github.com/user1/cfn-demo/tarball/master""

						          },

						          ""commands"" : {
								    ""test"" : {
								        ""command"" : ""echo \""$MAGIC\"" > test.txt"",
								        ""env"" : { ""MAGIC"" : ""I come from the environment!"" },
								        ""cwd"" : ""~"",
								        ""test"" : ""test ! -e ~/test.txt"",
								        ""ignoreErrors"" : ""false""
								    }						            
						          },


						          ""files"" : {
									  ""/tmp/setup.mysql"" : {
									    ""mode""  : ""000644"",
									    ""owner"" : ""root"",
									    ""group"" : ""root""
									  }
						          },


						          ""services"" : {

									  ""sysvinit"" : {
									    ""nginx"" : {
									      ""enabled"" : ""true"",
									      ""ensureRunning"" : ""true"",
									      ""files"" : [""/etc/nginx/nginx.conf""],
									      ""sources"" : [""/var/www/html""]
									    }
									  }
									  
						          },
" + @"

						          ""users"" : {

								    ""myUser"" : {
								        ""groups"" : [""groupOne"", ""groupTwo""],
								        ""uid"" : ""50"",
								        ""homeDir"" : ""/tmp""
								    }

						          },
						          ""groups"" : {

									""groupOne"" : {},
									""groupTwo"" : { ""gid"" : ""45"" }

						          }


						        }
						      }
						},
						""Properties"" : {
							""ImageId"" : ""ami-79fd7eee"",
							""KeyName"" : ""testkey""
						}
					}
				}
			}
";
/*
									    ""content"" : { ""Fn::Join"" : ["""", [
									      ""CREATE DATABASE "", { ""Ref"" : ""DBName"" }, "";\n"",
									      ""CREATE USER '"", { ""Ref"" : ""DBUsername"" }, ""'@'localhost' IDENTIFIED BY '"",
									                       { ""Ref"" : ""DBPassword"" }, ""';\n"",
									      ""GRANT ALL ON "", { ""Ref"" : ""DBName"" }, "".* TO '"", { ""Ref"" : ""DBUsername"" },
									                       ""'@'localhost';\n"",
									      ""FLUSH PRIVILEGES;\n""
									      ]]},
*/
            var template = new CFN.Template()
            {
                Descrption = "Ec2 metadata",
                Resources = new CFN.Resource[]
                {
                    new EC2.Instance("MyEC2Instance")
                    {
                        ImageId = "ami-79fd7eee",
                        KeyName = "testkey",
                        Metadata = new EC2.Metadata()
                        {
                            Comment = "Cfn Comment",
                            Init = new CFNR.Init()
                            {
                                config = new CFNR.config()
                                {
                                    packages = new CFNR.package()
                                    {
                                        rpm = new CFNR.rpm()
                                        {
                                            epel = "http://download.fedoraproject.org/pub/epel/5/i386/epel-release-5-4.noarch.rpm",
                                        },
                                        yum = new Dictionary<String, String[]>()
                                        {
                                            { "httpd", new String[] { } },
                                            { "php", new String[] { } },
                                        },
                                        rubygems = new Dictionary<String, String[]>()
                                        {
                                            { "chef", new String[] { "0.10.2", } },
                                        }
                                    },
                                    sources = new Dictionary<String, String>()
                                    {
                                        { "/etc/puppet", "https://github.com/user1/cfn-demo/tarball/master" },
                                    },

                                    commands = new Dictionary<String, CFNR.commandDef>()
                                    {
                                        { "test", new CFNR.commandDef()
											{
												command = "echo \"$MAGIC\" > test.txt",
												env = new Dictionary<String, String>()
												{
													{ "MAGIC", "I come from the environment!" },
												},
												cwd = "~",
												test = "test ! -e ~/test.txt",
												ignoreErrors = false,
											}
										},
									},
									files = new Dictionary<String, CFNR.file>()
									{
										{ "/tmp/setup.mysql", new CFNR.file()
											{
//												content = new CFN.Fn__Join(new CFN.StringRef[]
//												    {
//												
//														"CREATE DATABASE ",  new CFN.Ref("DBName"), ";\n",
//													    "CREATE USER '", new CFN.Ref("DBUsername"), "'@'localhost' IDENTIFIED BY '",
//														             new CFN.Ref("DBPassword"), "';\n",
//													    "GRANT ALL ON ", new CFN.Ref("DBName"), ".* TO '", new CFN.Ref("DBUsername"),
//														                         "'@'localhost';\n",
//							                            "FLUSH PRIVILEGES;\n"
//
//													}
//												),
												mode = "000644",
												group = "root",
												owner = "root",
											}
										},
									},
									services = new CFNR.services()
									{
										sysvinit = new Dictionary<String, CFNR.sysvinit>()
										{
											{ "nginx", new CFNR.sysvinit()
												{
													enabled = true,
													ensureRunning = true,
													files = new string[] { "/etc/nginx/nginx.conf" },
													sources = new string[] { "/var/www/html" },
												}
											},
										},							
									},
									users = new Dictionary<String, CFNR.user>()
									{
										{
											"myUser", new CFNR.user()
												{
													groups = new string[] {"groupOne", "groupTwo"},
													uid = "50",
													homeDir= "/tmp"
												}
										},
									},
									groups = new Dictionary<String, CFNR.group>()
									{
										{
											"groupOne", new CFNR.group()
											{
											}
										},
										{
											"groupTwo", new CFNR.group()
											{
												gid = "45",
											}
										},
									},
								}
							},
						},
					},
				},
			};
			
			Assert.IsTrue (CompareUtils.TemplatesAreEqual(target, template));
		}
	}
}
