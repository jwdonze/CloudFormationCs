namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html
    ///</summary>
    public class ManagedRuleGroupStatement
    {
        public ExcludedRule[] ExcludedRules
        {
            get;
            set;
        }

        public StringRef Name
        {
            get;
            set;
        }

        public StringRef VendorName
        {
            get;
            set;
        }
    }
}