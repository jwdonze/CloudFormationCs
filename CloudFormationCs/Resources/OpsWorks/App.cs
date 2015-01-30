using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.OpsWorks
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-app.html
    /// </summary>
    public class App : Resource
    {
        [Required(false)]
        public Source AppSource { get; set; }

        [Required(false)]
        public Dictionary<String, StringRef> Attributes { get; set; }

        [Required(false)]
        public String Description { get; set; }

        [Required(false)]
        public String[] Domains { get; set; }

        [Required(false)]
        public Boolean EnableSsl { get; set; }

        [Required(true)]
        public String Name { get; set; }

        [Required(false)]
        public String Shortname { get; set; }

        [Required(false)]
        public SslConfiguration SslConfiguration { get; set; }

        [Required(true)]
        public String StackId { get; set; }

        [Required(true)]
        public String Type { get; set; }

        public App()
            : base()
        {
        }

        public App(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
