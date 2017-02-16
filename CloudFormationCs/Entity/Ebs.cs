using System;

namespace CloudFormationCs.Entity
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-blockdev-template.html
    /// </summary>
    public class Ebs
    {
        [EmitAsString]
        public VolumeTypes VolumeType { get; set; }

        [EmitAsString]
        public Int32 Iops { get; set; }

        [EmitAsString]
        public Boolean DeleteOnTermination { get; set; }

        [EmitAsString]
        public Int32 VolumeSize { get; set; }

        [EmitAsString]
        public bool Encrypted { get; set; }

        public String SnapshotId { get; set; }

        public Ebs()
        {
            this.DeleteOnTermination = true;
        }
    }
}

