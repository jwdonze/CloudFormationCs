using CloudFormationCs.Converters;
using Newtonsoft.Json;
using System;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class WaitCondition : Resource
    {
        [JsonConverter(typeof(LowerCaseStringConverter))]
        public int Count { get; set; }

        public StringRef Handle { get; set; }

        [JsonConverter(typeof(LowerCaseStringConverter))]
        public Int16 Timeout { get; set; }

        public WaitCondition()
            : base()
        {
        }

        public WaitCondition(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
