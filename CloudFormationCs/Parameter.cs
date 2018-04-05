using System;
using Newtonsoft.Json;

namespace CloudFormationCs
{
    public class Parameter : IKeyValue
    {
        [JsonIgnore]
        public String Name { get; private set; }

        public String Description { get; set; }

        public ParameterTypes Type { get; set; }

        public String Default { get; set; }

        public String[] AllowedValues { get; set; }

        public Parameter()
        {
            this.Type = ParameterTypes.Undefined;
        }
        [JsonIgnore]
        public string Key {  get { return this.Name; } }
        [JsonIgnore]
        public Object Value{  get { return this; } }

        public Parameter(string name)
            : this()
        {
            this.Name = name;
        }

        public Parameter(string name, ParameterTypes parameterType, string defaultValue)
        {
            this.Name = name;
            this.Type = parameterType;
            this.Default = defaultValue;
        }
    }
}

