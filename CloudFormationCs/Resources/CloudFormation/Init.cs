using System;

namespace CloudFormationCs.Resources.CloudFormation
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-init.html
    /// </summary>
    [ElementName("AWS::CloudFormation::Init")]
    public class Init : Resource
    {
        public config config { get; set; }

        public Init() : base() { }

        public Init(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }
    }
}
