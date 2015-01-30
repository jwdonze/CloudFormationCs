using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.CloudFront
{
    public class CustomOriginConfig
    {
        public string HTTPPort { get; set; }
        public string OriginProtocolPolicy { get; set; }
    }
}
