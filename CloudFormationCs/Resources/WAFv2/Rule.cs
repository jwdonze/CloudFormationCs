namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html
    ///</summary>
    public class Rule
    {
        public RuleAction Action
        {
            get;
            set;
        }

        public StringRef Name
        {
            get;
            set;
        }

        public OverrideAction OverrideAction
        {
            get;
            set;
        }

        public int Priority
        {
            get;
            set;
        }

        public StatementOne Statement
        {
            get;
            set;
        }

        public VisibilityConfig VisibilityConfig
        {
            get;
            set;
        }
    }
}