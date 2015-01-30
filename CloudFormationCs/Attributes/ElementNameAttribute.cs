using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs
{
    public class ElementNameAttribute : System.Attribute
    {
        public string Name { get; private set; }

        public ElementNameAttribute(string name) : base()
        {
            this.Name = name;
        }
    }
}
