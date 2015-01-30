using System;
using System.Web.Script.Serialization;

namespace CloudFormationCs
{
    public class Parameter
    {
        [ScriptIgnore]
        public String Name { get; private set; }

        public String Description { get; set; }

        [EmitAsString]
        public ParameterTypes Type { get; set; }

        [EmitNullsAttribute]
        public String Default { get; set; }

        public String[] AllowedValues { get; set; }

        public Parameter()
        {
            this.Type = ParameterTypes.Undefined;
        }


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

