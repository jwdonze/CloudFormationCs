using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using Newtonsoft.Json;

namespace CloudFormationCs
{
    public class Template
    {
        protected JsonSerializerSettings s;

        public string AWSTemplateFormatVersion { get; set; } = "2010-09-09";
        public String Description { get; set; }

        [JsonConverter(typeof(Converters.KeyArrayConverter))]
        public Parameter[] Parameters { get; set; }

        [JsonConverter(typeof(Converters.KeyArrayConverter))]
        public IKeyValue[] Mappings { get; set; }

        [JsonConverter(typeof(Converters.ResourceMapConverter))]
        public List<Resource> Resources { get; set; }

        public Template()
        {
        }
        public string AsJson()
        {
            var s = new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore, };
            return JsonConvert.SerializeObject(this, Formatting.Indented, s);
        }
    }
}

