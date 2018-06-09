using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.ElasticLoadBalancingV2
{
    public class SubnetMapping
    {
        public StringRef SubnetId { get; set; }
        /// <summary>
        /// The ID that represents the allocation of the Elastic IP address.
        /// </summary>
        public StringRef AllocationId { get; set; }
    }
}
