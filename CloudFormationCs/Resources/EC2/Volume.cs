using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html
    /// </summary>
    public class Volume : Resource
    {
        [Required(true)]
        public StringRef AvailabilityZone { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public Int32 Iops { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public Int32? Size { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String SnapshotId { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        [Required(false)]
        [EmitAsString]
        public VolumeTypes VolumeType { get; set; }

        public Volume()
            : base()
        {
        }

        public Volume(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
