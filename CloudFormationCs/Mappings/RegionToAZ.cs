using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CloudFormationCs.Mappings
{
    public class RegionToAZ : IKeyValue
    {
        [JsonIgnore]
        public String Key { get; set; }

        protected Dictionary<Regions, Dictionary<String, String>> _dictionary;

        public RegionToAZ() 
        {
        }

        public RegionToAZ(string name)
        {
            this.Key = name;
        }

        public Object Value
        {
            get
            {
                var v = new Dictionary<String, object>();
				
                foreach (var pair in this._dictionary)
                {
                    var v2 = new Dictionary<String, object>();
                    foreach (var pair2 in pair.Value)
                    {
                        v2.Add(pair2.Key.ToString(), pair2.Value);
                    }
                    v.Add(CfnHelpers.GetRegionName(pair.Key), v2);
                }
                return v;
            }
        }
    }
}

