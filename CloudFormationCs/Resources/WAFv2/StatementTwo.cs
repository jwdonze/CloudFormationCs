namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementtwo.html
    ///</summary>
    public class StatementTwo
    {
        public AndStatementTwo AndStatement
        {
            get;
            set;
        }

        public ByteMatchStatement ByteMatchStatement
        {
            get;
            set;
        }

        public GeoMatchStatement GeoMatchStatement
        {
            get;
            set;
        }

        public IPSetReferenceStatement IPSetReferenceStatement
        {
            get;
            set;
        }

        public ManagedRuleGroupStatement ManagedRuleGroupStatement
        {
            get;
            set;
        }

        public NotStatementTwo NotStatement
        {
            get;
            set;
        }

        public OrStatementTwo OrStatement
        {
            get;
            set;
        }

        public RateBasedStatementTwo RateBasedStatement
        {
            get;
            set;
        }

        public RegexPatternSetReferenceStatement RegexPatternSetReferenceStatement
        {
            get;
            set;
        }

        public RuleGroupReferenceStatement RuleGroupReferenceStatement
        {
            get;
            set;
        }

        public SizeConstraintStatement SizeConstraintStatement
        {
            get;
            set;
        }

        public SqliMatchStatement SqliMatchStatement
        {
            get;
            set;
        }

        public XssMatchStatement XssMatchStatement
        {
            get;
            set;
        }
    }
}