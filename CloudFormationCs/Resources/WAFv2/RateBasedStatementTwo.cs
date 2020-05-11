namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementtwo.html
    ///</summary>
    public class RateBasedStatementTwo
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

        public StatementThree ScopeDownStatement
        {
            get;
            set;
        }
    }
}