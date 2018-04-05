using CloudFormationCs.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class commandDef
    {
        public StringRef command { get; set; }

        public Dictionary<String, String> env { get; set; }

        public String cwd { get; set; }

        public String test { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        public Int16? waitAfterCompletion { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        public Boolean? ignoreErrors { get; set; }

        public commandDef()
        {
            ignoreErrors = true;
        }
    }
}
