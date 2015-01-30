using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.OpsWorks
{
    public class Stack : Resource
    {
        [Required(false)]
        public Dictionary<String, StringRef> Attributes { get; set; }

        [Required(false)]
        public StackConfigurationManager ConfigurationManager { get; set; }

        [Required(false)]
        public Source CustomCookbooksSource { get; set; }

        [Required(false)]
        public Entity.JSON CustomJson { get; set; }

        [Required(false)]
        public String DefaultAvailabilityZone { get; set; }

        [Required(true)]
        public String DefaultInstanceProfileArn { get; set; }

        [Required(false)]
        public String DefaultOs { get; set; }

        [Required(false)]
        public String DefaultRootDeviceType { get; set; }

        [Required(false)]
        public String DefaultSshKeyName { get; set; }

        [Required(false)]
        public String DefaultSubnetId { get; set; }

        [Required(false)]
        public String HostnameTheme { get; set; }

        [Required(true)]
        public String Name { get; set; }

        [Required(true)]
        public String ServiceRoleArn { get; set; }

        [Required(false)]
        public Boolean UseCustomCookbooks { get; set; }

        [Required(false)]
        public String VpcId { get; set; }

        public Stack()
            : base()
        {
        }

        public Stack(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
