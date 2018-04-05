using Newtonsoft.Json;
using System;

using CloudFormationCs.Converters;

namespace CloudFormationCs.Entity
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-blockdev-template.html
    /// </summary>
    public class Ebs
    {
        public VolumeTypes VolumeType { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        public Int32 Iops { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        public Boolean? DeleteOnTermination { get; set; } = null;

        [JsonConverter(typeof(LowerCaseStringConverter))]
        public Int32 VolumeSize { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        public bool Encrypted { get; set; }

        public String SnapshotId { get; set; }

        public Ebs()
        {
        }
    }
}

