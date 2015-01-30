using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.OpsWorks
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html
    /// </summary>
    public class Layer : Resource
    {
        [Required(false)]
        public Dictionary<String, StringRef> Attributes { get; set; }

        [Required(true)]
        public Boolean AutoAssignElasticIps { get; set; }

        [Required(true)]
        public Boolean AutoAssignPublicIps { get; set; }

        [Required(false)]
        public String CustomInstanceProfileArn { get; set; }

        [Required(false)]
        public Recipes CustomRecipes { get; set; }

        [Required(false)]
        public String[] CustomSecurityGroupIds { get; set; }

        [Required(true)]
        public Boolean EnableAutoHealing { get; set; }

        [Required(false)]
        public Boolean InstallUpdatesOnBoot { get; set; }

        [Required(true)]
        public String Name { get; set; }

        [Required(false)]
        public String[] Packages { get; set; }

        [Required(true)]
        public String Shortname { get; set; }

        [Required(true)]
        public String StackId { get; set; }

        [Required(true)]
        public String Type { get; set; }

        [Required(false)]
        public VolumeConfiguration[] VolumeConfigurations { get; set; }

        public Layer()
            : base()
        {
        }

        public Layer(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
