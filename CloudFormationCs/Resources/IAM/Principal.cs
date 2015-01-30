using System;
using System.Web.Script.Serialization;

namespace CloudFormationCs.Resources.IAM
{
    public class Principal
    {
        public String AWS { get; set; }

        public String[] Service { get; set; }

        [ScriptIgnore]
        public String Service1 { set { this.Service = new String[] { value, }; } }
    }
}
