namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementthree.html
    ///</summary>
    public class StatementThree
    {
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