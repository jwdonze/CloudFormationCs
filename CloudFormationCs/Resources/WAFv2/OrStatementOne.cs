namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-orstatementone.html
    ///</summary>
    public class OrStatementOne
    {
        public StatementTwo[] Statements
        {
            get;
            set;
        }
    }
}