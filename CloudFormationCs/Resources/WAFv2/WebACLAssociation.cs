using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.WAFv2
{
    /// <summary>
    ///https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webaclassociation.html
    /// </summary>
    public class WebACLAssociation : Resource
    {
        public StringRef ResourceArn { get; set; }
        public StringRef WebACLArn { get; set; }


        public WebACLAssociation()
            : base()
        {
        }

        public WebACLAssociation(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
