using System;
using System.Web.Script.Serialization;

namespace CloudFormationCs
{
    public class Resource
    {
        [ScriptIgnore]
        public string ResourceIdentifier { get; private set; }

        [ScriptIgnore]
        public string Version { get; set; }

        [NonProperty]
#warning "WARNING: TODO: convert to array of strings or single string"
        public String DependsOn { get; set; }

        public Resource()
        {
        }

        public Resource(StringOrEnum resourceIdentifier)
        {
            this.ResourceIdentifier = resourceIdentifier;
        }
    }
}

