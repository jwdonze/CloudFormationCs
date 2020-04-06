using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CloudFormationCs.Mappings
{
    public class Region2AMI : IKeyValue
    {
        [JsonIgnore]
        public String Key { get; set; }

        private Dictionary<Regions, string> _dictionaryOfStrings;
        protected Dictionary<Regions, Dictionary<ArchTypes, string>> _dictionary;

        public Region2AMI()
        {
        }

        public Region2AMI(string name, Dictionary<Regions, string> dictionary)
        {
            this.Key = name;
            this._dictionaryOfStrings = dictionary;
        }
        public Fn__FindInMap Fn__FindInMap(Ref ref1)
        {
            return new Fn__FindInMap(this.Key, ref1, "AMI");
        }

        public Object Value
        {
            get
            {
                var v = new Dictionary<string, object>();
				
                foreach (var pair in this._dictionaryOfStrings)
                {
                    v.Add(CfnHelpers.GetRegionName(pair.Key), new Dictionary<string, object>() { { "AMI", pair.Value } });
                }
                return v;
            }
        }
    }
}

