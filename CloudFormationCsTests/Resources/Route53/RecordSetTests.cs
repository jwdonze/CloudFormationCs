using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using Route53 = CloudFormationCs.Resources.Route53;

namespace CloudFormationCsTests.Resources.Route53Tests
{
    [TestFixture()]
    public class RecordSetTests
    {
        [Test()]
        public void RecordSetGroup()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""SOMEDOMAIN1dotCOM"" : 
                    {
                        ""Type"" : ""AWS::Route53::RecordSetGroup"",            
                        ""Properties"" : 
                        {
                            ""HostedZoneId"" : ""/hostedzone/Z9BQ999999999"",                
                            ""RecordSets"" : [
                                {
                                    ""Name"" : ""www.somedomain1.com."",                        
                                    ""AliasTarget"" : 
                                    {
                                        ""DNSName"" : ""ELB-999999999.us-west-2.elb.amazonaws.com"",                            
                                        ""EvaluateTargetHealth"" : false,                            
                                        ""HostedZoneId"" : ""Z33M9999999999""
                                    },                        
                                    ""Type"" : ""A""
                                },                    
                                {
                                    ""TTL"" : ""300"",                        
                                    ""Name"" : ""ns.somedomain1.com."",                        
                                    ""ResourceRecords"" : [""8.8.8.8""],                        
                                    ""Type"" : ""A""
                                },                    
                                {
                                    ""TTL"" : ""300"",                        
                                    ""Name"" : ""autodiscover.somedomain1.com."",                        
                                    ""ResourceRecords"" : [""autodiscover.outlook.com""],                        
                                    ""Type"" : ""CNAME""
                                }]
                        }
                    },        
                    ""SOMEDOMAIN2dotCOM"" : 
                    {
                        ""Type"" : ""AWS::Route53::RecordSetGroup"",            
                        ""Properties"" : 
                        {
                            ""HostedZoneId"" : ""/hostedzone/Z6DP999999999"",                
                            ""RecordSets"" : [
                                {
                                    ""Name"" : ""www.somedomain2.com."",                        
                                    ""AliasTarget"" : 
                                    {
                                        ""DNSName"" : ""ELB-999999999.us-west-2.elb.amazonaws.com"",                            
                                        ""EvaluateTargetHealth"" : false,                            
                                        ""HostedZoneId"" : ""Z33MT999999999""
                                    },                        
                                    ""Type"" : ""A""
                                },                    
                                {
                                    ""TTL"" : ""300"",                        
                                    ""Name"" : ""12345.somedomain2.COM."",                        
                                    ""ResourceRecords"" : [""verify.bing.com.""],                        
                                    ""Type"" : ""CNAME""
                                }]
                        }
                    }
                }
            }
";
            var template = new CFN.Template()
            {
                Resources = new CFN.Resource[]
                {
                    new Route53.RecordSetGroup("SOMEDOMAIN1dotCOM")
                    {
                        HostedZoneId = "/hostedzone/Z9BQ999999999",
                        RecordSets = new Route53.RecordSet[]
                        {
                            new Route53.RecordSet()
                            {
                                Name = "www.somedomain1.com.",
                                AliasTarget = new Route53.AliasTarget()
                                {
                                    DNSName = "ELB-999999999.us-west-2.elb.amazonaws.com",
                                    EvaluateTargetHealth = false,
                                    HostedZoneId = "Z33M9999999999",
                                },
                                Type = Route53.NameTypes.A,
                            },
                            new Route53.RecordSet()
                            {
                                TTL = "300",
                                Name = "ns.somedomain1.com.",
                                ResourceRecords = new string[]
                                {
                                    "8.8.8.8",
                                },
                                Type = Route53.NameTypes.A,
                            },
                            new Route53.RecordSet()
                            {
                                TTL = "300",
                                Name = "autodiscover.somedomain1.com.",
                                ResourceRecords = new string[]
                                {
                                    "autodiscover.outlook.com",
                                },
                                Type = Route53.NameTypes.CNAME,
                            },
                        },
                    },
                    new Route53.RecordSetGroup("SOMEDOMAIN2dotCOM")
                    {
                        HostedZoneId = "/hostedzone/Z6DP999999999",
                        RecordSets = new Route53.RecordSet[]
                        {
                            new Route53.RecordSet()
                            {
                                Name = "www.somedomain2.com.",
                                AliasTarget = new Route53.AliasTarget()
                                {
                                    DNSName = "ELB-999999999.us-west-2.elb.amazonaws.com",
                                    EvaluateTargetHealth = false,
                                    HostedZoneId = "Z33MT999999999",
                                },
                                Type = Route53.NameTypes.A,
                            },
                            new Route53.RecordSet()
                            {
                                TTL = "300",
                                Name = "12345.somedomain2.COM.",
                                ResourceRecords = new string[]
                                {
                                    "verify.bing.com.",
                                },
                                Type = Route53.NameTypes.CNAME,

                            },
                        },
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
