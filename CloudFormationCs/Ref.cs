using System;

namespace CloudFormationCs
{
    public class Ref : KeyByType, IKeyValue
    {
        public Ref() { }

        public Ref(string name)
        {
            this._name = name;
        }

        public Object Value { get { return this._name; } }

        string _name;
    }
}

