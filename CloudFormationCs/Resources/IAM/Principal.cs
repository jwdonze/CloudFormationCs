using System;
using Newtonsoft.Json;

namespace CloudFormationCs.Resources.IAM
{
    public class Principal
    {
        public String AWS { get; set; }

        public String[] Service { get; set; }

        [JsonIgnore]
        public String Service1 { set { this.Service = new String[] { value, }; } }
    }
}
