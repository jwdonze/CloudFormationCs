using System;

namespace CloudFormationCs
{
    /// <summary>
    /// Static methods for converting C# compatible identifier names to AWS names
    /// </summary>
    public static class CfnHelpers
    {
        public static string GetSize(InstanceTypes size) 
        { 
            return size.ToString().ToLower().Replace("_", "."); 
        }
        /// <summary>
        /// Returns the AWS resource type for the supplied object.
        /// For example, CloudFormationCs.Resources.EC2.Instance returns 'AWS::EC2::Instance'
        /// </summary>
        public static string GetNameFull(Resource res)
        {
            return res.GetType().FullName.Replace("CloudFormationCs.Resources", "AWS").Replace(".", "::");
        }
        public static string GetNameShort(KeyByType obj)
        {
            return obj.GetType().Name.Replace("__", "::");
        }
        public static string GetRegionName(Regions nameIn)
        {
            return nameIn.ToString().Replace("_", "-");
        }
        public static string GetZoneName(AvailabilityZones name)
        {
            return name.ToString().Replace("_", "-");
        }
        public static string GetInstnaceName(InstanceTypes nameIn)
        {
            return nameIn.ToString().Replace("_", ".");
        }
        public static string GetArchName(ArchTypes nameIn)
        {
            return nameIn.ToString().Substring(1);
        }
        public static string GetPolicyName(Resources.IAM.PolicyDocumentStatementActions policyAction)
        {
            return policyAction.ToString().Replace("_", ":").Replace("STAR", "*");
        }
    }
}

