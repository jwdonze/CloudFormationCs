using System;
using System.Web.Script.Serialization;

namespace CloudFormationCs
{
    internal class ResourcePropertyContainer
    {
        public string ResourceIdentifier { get; private set; }
        public string Version { get; set; }
        public Resource Properties { get; set; }
        public string Type { get; set; }
        [CompressSingleArray]
        public string[] DependsOn { get; set; }
        public Resources.EC2.Metadata Metadata { get; set; }
    }
    public class Resource
    {
        [ScriptIgnore]
        public string ResourceIdentifier { get; private set; }

        [ScriptIgnore]
        public string Version { get; set; }

        [NonProperty]
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

