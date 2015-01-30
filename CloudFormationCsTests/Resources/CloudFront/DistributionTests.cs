using System;
using NUnit.Framework;

using CFN = CloudFormationCs;
using CF = CloudFormationCs.Resources.CloudFront;

namespace CloudFormationCsTests.Resources.CloudFrontTests
{
    [TestFixture()]
    public class DistributionTests
    {
        [Test()]
        public void Distribution()
        {
            var target = @"
            {
                ""AWSTemplateFormatVersion"" : ""2010-09-09"",    
                ""Resources"" : 
                {
                    ""MyCdn"" : 
                    {
                        ""Type"" : ""AWS::CloudFront::Distribution"",            
                        ""Properties"" : 
                        {
                            ""DistributionConfig"" : 
                            {
                                ""Comment"" : ""CDN 1"",                    
                                ""DefaultCacheBehavior"" : 
                                {
                                    ""ForwardedValues"" : 
                                    {
                                        ""QueryString"" : ""true""
                                    },                        
                                    ""MinTTL"" : ""30"",                        
                                    ""TargetOriginId"" : ""origin-www.mydomain1.com"",                        
                                    ""ViewerProtocolPolicy"" : ""allow-all""
                                },                    
                                ""Enabled"" : ""true"",                    
                                ""Origins"" : [
                                    {
                                        ""CustomOriginConfig"" : 
                                        {
                                            ""HTTPPort"" : ""80"",                                
                                            ""OriginProtocolPolicy"" : ""http-only""
                                        },                            
                                        ""DomainName"" : ""cdn.mydomain1.com"",                            
                                        ""Id"" : ""origin-www.mydomain1.com""
                                    }],                    
                                ""PriceClass"" : ""PriceClass_100""
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
                    new CF.Distribution("MyCdn")
                    {
                        DistributionConfig = new CF.DistributionConfig()
                        {
                            Comment = "CDN 1",
                            DefaultCacheBehavior = new CF.CacheBehavior()
                            {
                                ForwardedValues = new CF.ForwardedValues()
                                {
                                    QueryString = true,
                                },
                                MinTTL = "30",
                                TargetOriginId = "origin-www.mydomain1.com",
                                ViewerProtocolPolicy = "allow-all",
                            },
                            Enabled = true,
                            Origins = new CF.Origin[]{
                                new CF.Origin()
                                {
                                    CustomOriginConfig = new CF.CustomOriginConfig()
                                    {
                                        HTTPPort = "80",
                                        OriginProtocolPolicy = "http-only",
                                    },
                                    DomainName = "cdn.mydomain1.com",
                                    Id = "origin-www.mydomain1.com",
                                },
                            },
                            PriceClass = "PriceClass_100",
                        },
                    },
                },
            };

            Assert.IsTrue(CompareUtils.TemplatesAreEqual(target, template));
        }
    }
}
