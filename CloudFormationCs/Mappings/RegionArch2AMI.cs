using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CloudFormationCs.Mappings
{
    public class RegionArch2AMI : IKeyValue
    {
        [JsonIgnore]
        public String Key { get; set; }

        protected Dictionary<Regions, Dictionary<ArchTypes, string>> _dictionary;

        public RegionArch2AMI()
        {
        }

        public RegionArch2AMI(string name, Dictionary<Regions, Dictionary<ArchTypes, string>> dictionary)
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
                    var v2 = new Dictionary<string, object>();
                    foreach (var pair2 in pair.Value)
                    {
                        v2.Add(CfnHelpers.GetArchName(pair2.Key), pair2.Value);
                    }
                    v.Add(CfnHelpers.GetRegionName(pair.Key), v2);
                }
                return v;
            }
        }
    }
}

