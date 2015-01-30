using System;

namespace CloudFormationCs
{
    /// <summary>
    /// Serialize at the same level as Properties rather than in Properties
    /// Examples: Instance MetaData and DependsOn
    /// </summary>
    public class NonPropertyAttribute : System.Attribute
    {
    }
}

