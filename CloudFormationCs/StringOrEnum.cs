using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs
{
    public class StringOrEnum
    {
        public StringOrEnum() { }

        public StringOrEnum(string name)
        {
            this._value = name;
        }
        public StringOrEnum(Enum name)
        {
            this._value = name.ToString();
        }
        public static implicit operator String(StringOrEnum d)
        {
            return d._value.ToString();
        }
        public static implicit operator StringOrEnum(String d)
        {
            return new StringOrEnum(d);
        }
        public static implicit operator StringOrEnum(Enum d)
        {
            return new StringOrEnum(d);
        }

        private string _value;
    }
}
