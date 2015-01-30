using System;

namespace CloudFormationCs.Resources.OpsWorks
{
    public class VolumeConfiguration
    {
        [Required(true)]
        public String MountPoint { get; set; }

        [Required(true)]
        public Int32 NumberOfDisks { get; set; }

        [Required(false)]
        public Int32 RaidLevel { get; set; }

        [Required(true)]
        public Int32 Size { get; set; }
    }
}
