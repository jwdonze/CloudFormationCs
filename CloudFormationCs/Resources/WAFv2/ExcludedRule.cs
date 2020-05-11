namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-excludedrule.html
    ///</summary>
    public class ExcludedRule
    {
        public ExcludedRule()
        {

        }
        public ExcludedRule(string ruleName)
        {
            this.Name = ruleName;
        }
        public StringRef Name
        {
            get;
            set;
        }
    }
}