using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.RDS
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbparametergroup.html
    /// </summary>
    public class DBParameterGroup : Resource
    {
		
        [Required(RequiredAttribute.RequirementTypes.Undocumented)]
        public String Description { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Undocumented)]
        public String Family { get; set; }
		
        // DBParameters
        /*
"Parameters" : {
   "Key1" : "Value1",
   "Key2" : "Value2",
   "Key3" : "Value3"
} 
		 */
        [Required(RequiredAttribute.RequirementTypes.Undocumented)]
        public Dictionary<String, StringRef> Parameters { get; set; }

        [Required(false)]
        public Tag[] Tags { get; set; }

        public DBParameterGroup()
            : base()
        {
        }

        public DBParameterGroup(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
