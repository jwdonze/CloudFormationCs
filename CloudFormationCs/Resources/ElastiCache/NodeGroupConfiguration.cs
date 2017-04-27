using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.ElastiCache
{
    public class NodeGroupConfiguration
    {
        public String PrimaryAvailabilityZone { get; set; }

        public String[] ReplicaAvailabilityZones { get; set; }

        public int ReplicaCount { get; set; }

        public String Slots { get; set; }
    }
}
