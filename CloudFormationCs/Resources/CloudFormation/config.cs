using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class config
    {
        public package packages { get; set; }

        public Dictionary<String, String> sources { get; set; }

        public Dictionary<String, commandDef> commands { get; set; }

        public Dictionary<String, file> files { get; set; }

        public services services { get; set; }

        public Dictionary<String, user> users { get; set; }

        public Dictionary<String, group> groups { get; set; }
    }

}
