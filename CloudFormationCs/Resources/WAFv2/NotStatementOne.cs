namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-notstatementone.html
    ///</summary>
    public class NotStatementOne
    {
        public StatementTwo Statement
        {
            get;
            set;
        }
    }
}