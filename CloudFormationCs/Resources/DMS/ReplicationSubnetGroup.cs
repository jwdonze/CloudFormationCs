using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.DMS
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationsubnetgroup.html
    /// </summary>
    public class ReplicationSubnetGroup : Resource
    {
        public ReplicationSubnetGroup() : base() { }

        public ReplicationSubnetGroup(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }

        public string ReplicationSubnetGroupDescription { get; set; }
        public string ReplicationSubnetGroupIdentifier { get; set; }
        public StringRef[] SubnetIds { get; set; }
        public Tag[] Tags { get; set; }
    }
}
