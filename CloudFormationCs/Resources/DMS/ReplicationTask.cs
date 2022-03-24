using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.DMS
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationtask.html
    /// </summary>

    public class ReplicationTask : Resource
    {
        public ReplicationTask() : base() { }

        public ReplicationTask(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }

        public string ReplicationTaskSettings { get; set; }
        public double CdcStartPosition { get; set; }
        public string CdcStopPosition { get; set; }
        public string MigrationType { get; set; }
        public StringRef ReplicationInstanceArn { get; set; }
        public string CdcStartTime { get; set; }
        //public string ResourceIdentifier { get; set; }
        public string TableMappings { get; set; }
        public string ReplicationTaskIdentifier { get; set; }
        public StringRef SourceEndpointArn { get; set; }
        public Tag[] Tags { get; set; }
        public StringRef TargetEndpointArn { get; set; }
        public string TaskData { get; set; }
    }


}
