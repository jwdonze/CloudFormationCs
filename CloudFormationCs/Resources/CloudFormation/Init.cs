using System;

namespace CloudFormationCs.Resources.CloudFormation
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-init.html
    /// </summary>
    public class Init : Resource
    {
        public config config { get; set; }

        public Init() : base() { }

        public Init(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }
    }
}
