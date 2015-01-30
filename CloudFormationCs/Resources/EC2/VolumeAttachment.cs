using System;

namespace CloudFormationCs.Resources.EC2
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volumeattachment.html
    /// </summary>
    public class VolumeAttachment : Resource
    {
        [Required(true)]
        public String Device { get; set; }

        [Required(true)]
        public StringRef InstanceId { get; set; }

        [Required(true)]
        public StringRef VolumeId { get; set; }

        public VolumeAttachment()
            : base()
        {
        }

        public VolumeAttachment(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
