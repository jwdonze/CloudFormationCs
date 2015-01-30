using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.CloudFront
{
    public class Origin
    {
        public CustomOriginConfig CustomOriginConfig { get; set; }
        public string DomainName { get; set; }
        public string Id { get; set; }
    }
}
