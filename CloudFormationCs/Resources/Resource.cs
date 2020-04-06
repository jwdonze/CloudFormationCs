using System;
using Newtonsoft.Json;

namespace CloudFormationCs
{
    public class Resource
    {
        [JsonIgnore]
        public string ResourceIdentifier { get; protected set; }

        [JsonIgnore]
        public string Version { get; set; }

        [JsonIgnore]
        public string[] DependsOn { get; set; }

        public Resource()
        {
        }

        public Resource(StringOrEnum resourceIdentifier)
        {
            this.ResourceIdentifier = resourceIdentifier;
        }
    }
}

