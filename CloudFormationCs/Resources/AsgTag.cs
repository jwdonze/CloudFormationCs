using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudFormationCs
{
    /// <summary>
    /// Tag for AutoScalingGroup
    /// </summary>
    public class AsgTag : Tag
    {
        public AsgTag() : base() { }
        public AsgTag(String key, StringRef val) : base(key, val) { }

        [EmitAsString]
        public bool PropagateAtLaunch { get; set; }
    }
}
