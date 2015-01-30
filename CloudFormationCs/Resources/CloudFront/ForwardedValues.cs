using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.CloudFront
{
    public class ForwardedValues
    {
        [EmitAsString]
        public bool QueryString { get; set; }
    }
}
