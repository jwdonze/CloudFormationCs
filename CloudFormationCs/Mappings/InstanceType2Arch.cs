using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CloudFormationCs.Mappings
{
    public class InstanceType2Arch : IKeyValue
    {
        public String Key { get; set; }

        protected Dictionary<InstanceTypes, ArchTypes> _dictionary;

        public InstanceType2Arch()
        {
        }

        public InstanceType2Arch(string name, Dictionary<InstanceTypes, ArchTypes> dictionary)
        {
            this.Key = name;
            this._dictionary = dictionary;
        }

        public Object Value
        {
            get
            {
                var v = new Dictionary<string, object>();
				
                foreach (var pair in this._dictionary)
                {
                    v.Add(CfnHelpers.GetInstnaceName(pair.Key),
                        new Hashtable()
                        {
                            { "Arch", CfnHelpers.GetArchName(pair.Value) }
                        });
                }
                return v;
            }
        }
    }
}

