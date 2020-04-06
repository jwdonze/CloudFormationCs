using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.WAFRegional
{
    /// <summary>
    ///https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webaclassociation.html
    /// </summary>
    public class WebACLAssociation : Resource
    {
        public StringRef ResourceArn { get; set; }
        public StringRef WebACLId { get; set; }


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
