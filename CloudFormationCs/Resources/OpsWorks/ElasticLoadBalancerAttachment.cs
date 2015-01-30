using System;

namespace CloudFormationCs.Resources.OpsWorks
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-elbattachment.html
    /// </summary>
    public class ElasticLoadBalancerAttachment : Resource
    {
        [Required(true)]
        public String ElasticLoadBalancerName { get; set; }

        [Required(true)]
        public String LayerId { get; set; }

        public ElasticLoadBalancerAttachment()
            : base()
        {
        }

        public ElasticLoadBalancerAttachment(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
