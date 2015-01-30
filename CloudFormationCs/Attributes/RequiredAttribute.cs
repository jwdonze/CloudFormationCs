using System;

namespace CloudFormationCs
{
    public class RequiredAttribute : Attribute
    {
        public RequiredAttribute(Boolean isRequired)
        {
        }

        public RequiredAttribute(RequirementTypes isRequired)
        {
        }

        public enum RequirementTypes
        {
            Conditional,
            Undocumented,
        }
    }
}

