using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using ELB = CloudFormationCs.Resources.ElasticLoadBalancing;

namespace CloudFormationCsTests.Resources.ElasticLoadBalancingTests
{
    [TestFixture()]
    public class LoadBalancerTests
    {
        [Test()]
        public void LoadBalancer()
        {
            var target = @"
{
    ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
    ""Description"" : ""ELB Template"",
    ""Resources"" : 
    {
        ""MyELB"" : 
        {
            ""Type"" : ""AWS::ElasticLoadBalancing::LoadBalancer"",            
            ""Properties"" : 
            {
                ""Listeners"" : [
                    {
                        ""LoadBalancerPort"" : ""80"",                        
                        ""InstancePort"" : ""80"",                        
                        ""Protocol"" : ""HTTP""
                    },                    
                    {
                        ""LoadBalancerPort"" : ""443"",                        
                        ""InstancePort"" : ""443"",                        
                        ""Protocol"" : ""TCP""
                    }],                
                ""HealthCheck"" : 
                {
                    ""HealthyThreshold"" : ""2"",                    
                    ""Interval"" : ""30"",                    
                    ""Target"" : ""HTTP:8200/"",                    
                    ""Timeout"" : ""5"",                    
                    ""UnhealthyThreshold"" : ""2""
                },                
                ""SecurityGroups"" : [
                    ""sg-11111111"",
                    { ""Ref"" : ""mysecuritygroup"" }
                ],                
                ""Subnets"" : [
                    { ""Ref"" : ""mypublicsubnet"" },
                    ""subnet-22222222""
                ],                
                ""LoadBalancerName"" : ""ELB-1-Name"",                
                ""Tags"" : [
                    {
                        ""Key"" : ""Name"",                        
                        ""Value"" : ""ELB-1""
                    }]
            }
        }        
    }
}";

            var template = new CFN.Template()
            {
                Descrption = "ELB Template",
                Resources = new CFN.Resource[]
                {
                    new ELB.LoadBalancer("MyELB")
                    {
                        Listeners = new ELB.Listener[]
                        {
                            new ELB.Listener()
                            {
                                LoadBalancerPort = "80",
                                InstancePort = "80",
                                Protocol = "HTTP",
                            },
                            new ELB.Listener()
                            {
                                LoadBalancerPort = "443",
                                InstancePort = "443",
                                Protocol = "TCP",
                            },
                        },
                        HealthCheck = new ELB.HealthCheck()
                        {
                            HealthyThreshold = "2",
                            Interval = "30",
                            Target = "HTTP:8200/",
                            Timeout = "5",
                            UnhealthyThreshold = "2",
                        },
                        SecurityGroups = new CFN.StringRef[] { 
                            new CFN.Ref("mysecuritygroup"),
                            "sg-11111111", 
                        },
                        Subnets = new CFN.StringRef[] { 
                            "subnet-22222222", 
                            new CFN.Ref("mypublicsubnet"),
                        },
                        LoadBalancerName = "ELB-1-Name",
                        Tags = new CFN.Tag[] 
                        {
                            new CFN.Tag("Name", "ELB-1"),
                        },
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
