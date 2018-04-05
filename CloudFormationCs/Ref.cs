using System;

namespace CloudFormationCs
{
    public class Ref : KeyByType
    {
        public Ref() { }

        public Ref(StringOrEnum name)
        {
            this._name = name;
        }

        public Object Value { get { return this._name; } }

        string _name;
    }
}

