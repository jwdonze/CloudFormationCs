using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using AutoScaling = CloudFormationCs.Resources.AutoScaling;
using CloudWatch = CloudFormationCs.Resources.CloudWatch;

namespace CloudFormationCsTests.Resources.AutoScalingTests
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/quickref-autoscaling.html
    /// </summary>
    [TestFixture()]
    public class AutoScalingGroupTests
    {
        [Test()]
        public void SinpleConfig()
        {
            var target = @"
			{
			   ""AWSTemplateFormatVersion"" : ""2010-09-09"",
			   ""Resources"" : {
					""SimpleConfig"" : {
						   ""Type"" : ""AWS::AutoScaling::LaunchConfiguration"",
						   ""Properties"" : {
						      ""ImageId"" : ""ami-6411e20d"",
						      ""SecurityGroups"" : [ { ""Ref"" : ""myEC2SecurityGroup"" }, ""myExistingEC2SecurityGroup"" ],
						      ""InstanceType"" : ""m1.small"",
						      ""BlockDeviceMappings"" : [ {
						            ""DeviceName"" : ""/dev/sdk"",
						            ""Ebs"" : {""VolumeSize"" : ""50""}
						         }, {
						            ""DeviceName"" : ""/dev/sdc"",
						            ""VirtualName"" : ""ephemeral0""
						      } ]
						   }
						}
			      }
			}
  ";
			
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new AutoScaling.LaunchConfiguration("SimpleConfig")
                    {
                        ImageId = "ami-6411e20d",
                        SecurityGroups = new CFN.StringRef[]
                        {
                            new CFN.Ref("myEC2SecurityGroup"), "myExistingEC2SecurityGroup",
                        },
                        InstanceType = "m1.small",
                        BlockDeviceMappings = new CFN.Entity.BlockDeviceMapping[]
                        {
                            new CFN.Entity.BlockDeviceMapping()
                            {
                                DeviceName = "/dev/sdk",
                                Ebs = new CFN.Entity.Ebs()
                                {
                                    VolumeSize = 50,
                                }
                            },
                            new CFN.Entity.BlockDeviceMapping()
                            {
                                DeviceName = "/dev/sdc",
                                VirtualName = "ephemeral0",
                            },

                        },
                    }
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }

        [Test()]
        public void GroupResource()
        {
            var target = @"
			{
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",
                ""Resources"" : 
                {
                    ""MyServerGroup"" : 
                    {
                        ""Type"" : ""AWS::AutoScaling::AutoScalingGroup"",
                        ""Properties"" : 
                        {
                            ""AvailabilityZones"" : { ""Fn::GetAZs"" : """"},
                            ""LaunchConfigurationName"" : { ""Ref"" : ""SimpleConfig"" },
                            ""MinSize"" : ""1"",
                            ""MaxSize"" : ""3"",
                            ""LoadBalancerNames"" : [ { ""Ref"" : ""LB"" } ]
                        }
                    }
                }
			}
";

            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new AutoScaling.AutoScalingGroup("MyServerGroup")
                    {
                        AvailabilityZone = new CFN.Fn__GetAZs(string.Empty),
                        LaunchConfigurationName = new CFN.Ref("SimpleConfig"),
                        MinSize = "1",
                        MaxSize = "3",
                        LoadBalancerNames = new CFN.StringRef[]
                        {
                            new CFN.Ref("LB")
                        },
                    }
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }

        [Test()]
        public void WithCloudWatch()
        {
            var target = @"
			{
			   ""AWSTemplateFormatVersion"" : ""2010-09-09"",
			   ""Resources"" : {
				   ""ScaleUpPolicy"" : {
						   ""Type"" : ""AWS::AutoScaling::ScalingPolicy"",
						   ""Properties"" : {
						      ""AdjustmentType"" : ""ChangeInCapacity"",
						      ""AutoScalingGroupName"" : { ""Ref"" : ""asGroup"" },
						      ""Cooldown"" : ""1"",
						      ""ScalingAdjustment"" : ""1""
						   }
						},
					""CPUAlarmHigh"": {
					   ""Type"": ""AWS::CloudWatch::Alarm"",
					   ""Properties"": {
					      ""EvaluationPeriods"": ""1"",
					      ""Statistic"": ""Average"",
					      ""Threshold"": ""10"",
					      ""AlarmDescription"": ""Alarm if CPU too high or metric disappears indicating instance is down"",
					      ""Period"": ""60"",
					      ""AlarmActions"": [ { ""Ref"": ""ScaleUpPolicy"" } ],
					      ""Namespace"": ""AWS/EC2"",
					      ""Dimensions"": [ {
					         ""Name"": ""AutoScalingGroupName"",
					         ""Value"": { ""Ref"": ""asGroup"" }
					      } ],
					      ""ComparisonOperator"": ""GreaterThanThreshold"",
					      ""MetricName"": ""CPUUtilization""
					   }
					}
			      }
			}
";
			
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new AutoScaling.ScalingPolicy("ScaleUpPolicy")
                    {
                        AdjustmentType = "ChangeInCapacity",
                        AutoScalingGroupName = new CFN.Ref("asGroup"),
                        Cooldown = "1",
                        ScalingAdjustment = "1",
                    },
                    new CloudWatch.Alarm("CPUAlarmHigh")
                    {
                        EvaluationPeriods = "1",
                        Statistic = "Average",
                        Threshold = "10",
                        AlarmDescription = "Alarm if CPU too high or metric disappears indicating instance is down",
                        Period = "60",
                        AlarmActions = new CFN.StringRef[] { new CFN.Ref("ScaleUpPolicy"), },
                        Namespace = "AWS/EC2",
                        Dimensions1 = new CloudWatch.MetricDimension()
                        {
                            Name = "AutoScalingGroupName",
                            Value = new CFN.Ref("asGroup"),
                        },
                        ComparisonOperator = "GreaterThanThreshold",
                        MetricName = "CPUUtilization",
                    },
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }

        [Test()]
        public void WithNotifications()
        {
            var target = @"
			{
			   ""AWSTemplateFormatVersion"" : ""2010-09-09"",
			   ""Resources"" : {
					""MyAsGroupWithNotification"" : {
					   ""Type"" : ""AWS::AutoScaling::AutoScalingGroup"",
					   ""Properties"" : {
					      ""LaunchConfigurationName"" : { ""Ref"" : ""myLCOne"" },
					      ""MinSize"" : ""0"",
					      ""MaxSize"" : ""2"",
					      ""DesiredCapacity"" : ""1"",
					      ""NotificationConfiguration"" : {
					         ""TopicARN"" : { ""Ref"" : ""topic1"" },
					         ""NotificationTypes"" : [
					            ""autoscaling:EC2_INSTANCE_LAUNCH"",
					            ""autoscaling:EC2_INSTANCE_LAUNCH_ERROR"",
					            ""autoscaling:EC2_INSTANCE_TERMINATE"",
					            ""autoscaling:EC2_INSTANCE_TERMINATE_ERROR""
					         ]
					      }
					   }
					}     
			      }
			}
";
//		""AvailabilityZones"" : { ""Ref"" : ""azList"" },

            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new AutoScaling.AutoScalingGroup("MyAsGroupWithNotification")
                    {
                        //AvailabilityZones =  new CFN.Fn__GetAZs(string.Empty),
                        LaunchConfigurationName = new CFN.Ref("myLCOne"),
                        MinSize = "0",
                        MaxSize = "2",
                        DesiredCapacity = "1",
                        NotificationConfiguration = new AutoScaling.NotificationConfiguration()
                        {
                            TopicARN = new CFN.Ref("topic1"),
                            NotificationTypes = new string[]
                            {
                                "autoscaling:EC2_INSTANCE_LAUNCH",
                                "autoscaling:EC2_INSTANCE_LAUNCH_ERROR",
                                "autoscaling:EC2_INSTANCE_TERMINATE",
                                "autoscaling:EC2_INSTANCE_TERMINATE_ERROR",
                            },
                        },
                    },
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }

        [Test()]
        public void ResourceTrigger()
        {
            var target = @"
			{
			   ""AWSTemplateFormatVersion"" : ""2010-09-09"",
			   ""Resources"" : {
					""MyTrigger"" : {
					   ""Type"" : ""AWS::AutoScaling::Trigger"",
					   ""Properties"" : {
					      ""MetricName"" : ""CPUUtilization"",
					      ""Namespace"" : ""AWS/EC2"",
					      ""Statistic"" : ""Average"",
					      ""Period"" : ""300"",
					      ""UpperBreachScaleIncrement"" : ""1"",
					      ""LowerBreachScaleIncrement"" : ""-1"",
					      ""AutoScalingGroupName"" : { ""Ref"" : ""MyServerGroup"" },
					      ""BreachDuration"" : ""600"",
					      ""UpperThreshold"" : ""90"",
					      ""LowerThreshold"" : ""75"",
					      ""Dimensions"" : [ {
					         ""Name"" : ""AutoScalingGroupName"",
					         ""Value"" : { ""Ref"" : ""MyServerGroup"" }
					      } ]
					   }
					}
			      }
			}
";
			
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new AutoScaling.Trigger("MyTrigger")
                    {
                        MetricName = "CPUUtilization",
                        Namespace = "AWS/EC2",
                        Statistic = "Average",
                        Period = "300",
                        UpperBreachScaleIncrement = "1",
                        LowerBreachScaleIncrement = "-1",
                        AutoScalingGroupName = new CFN.Ref("MyServerGroup"),
                        BreachDuration = "600",
                        UpperThreshold = "90",
                        LowerThreshold = "75",
                        Dimensions1 = new CloudWatch.MetricDimension()
                        {
                            Name = "AutoScalingGroupName",
                            Value = new CFN.Ref("MyServerGroup"),
                        },
                    },
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
        //[Test()]
        public void WithUpdatePolicy()
        {
            var target = @"
			{
			   ""AWSTemplateFormatVersion"" : ""2010-09-09"",
			   ""Resources"" : {
					""ASG1"" : {
					   ""UpdatePolicy"" : {
					      ""AutoScalingRollingUpdate"" : {
					         ""MinInstancesInService"" : ""1"",
					         ""MaxBatchSize"" : ""1"",
					         ""PauseTime"" : ""PT12M5S""
					      }
					   },
					   ""Type"" : ""AWS::AutoScaling::AutoScalingGroup"",
					   ""Properties"" : {
					      ""AvailabilityZones"" : { ""Fn::GetAZs"" : { ""Ref"" : ""AWS::Region"" } },
					      ""LaunchConfigurationName"" : { ""Ref"" : ""ASLC"" },
					      ""MaxSize"" : ""3"",
					      ""MinSize"" : ""1""
					   }
					}
			      }
			}
";
			
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new AutoScaling.AutoScalingGroup("ASG1")
                    {

//						"" : {
//							"UpdatePolicy" : {
//								"AutoScalingRollingUpdate" : {
//									"MinInstancesInService" : "1",
//									"MaxBatchSize" : "1",
//									"PauseTime" : "PT12M5S"
//								}
//							},
//							"AvailabilityZones" : { "Fn::GetAZs" : { "Ref" : "AWS::Region" } },
//							"LaunchConfigurationName" : { "Ref" : "ASLC" },
//								"MaxSize" : "3",
//								"MinSize" : "1"
                    },
                },
            };
			
            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
