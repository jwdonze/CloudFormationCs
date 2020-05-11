namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rulegroupreferencestatement.html
    ///</summary>
    public class RuleGroupReferenceStatement
    {
        public StringRef Arn
        {
            get;
            set;
        }

        public ExcludedRule[] ExcludedRules
        {
            get;
            set;
        }
    }
}