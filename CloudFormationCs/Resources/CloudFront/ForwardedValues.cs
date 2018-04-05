using CloudFormationCs.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs.Resources.CloudFront
{
    public class ForwardedValues
    {
        [JsonConverter(typeof(LowerCaseStringConverter))]
        public bool QueryString { get; set; }
    }
}
