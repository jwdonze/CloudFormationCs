using CloudFormationCs.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class sysvinit
    {
        [JsonConverter(typeof(LowerCaseStringConverter))]
        public Boolean enabled { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        public Boolean ensureRunning { get; set; }

        public String[] files { get; set; }

        public String[] sources { get; set; }
    }
}
