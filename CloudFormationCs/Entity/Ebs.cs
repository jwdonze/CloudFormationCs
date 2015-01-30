using System;

namespace CloudFormationCs.Entity
{
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

        public Ebs()
        {
            this.DeleteOnTermination = true;
        }
    }
}

