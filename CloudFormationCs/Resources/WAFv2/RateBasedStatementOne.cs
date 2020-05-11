namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementone.html
    ///</summary>
    public class RateBasedStatementOne
    {
        public StringRef AggregateKeyType
        {
            get;
            set;
        }

        public int Limit
        {
            get;
            set;
        }

        public StatementTwo ScopeDownStatement
        {
            get;
            set;
        }
    }
}