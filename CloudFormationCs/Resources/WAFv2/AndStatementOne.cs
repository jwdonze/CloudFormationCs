namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-andstatementone.html
    ///</summary>
    public class AndStatementOne
    {
        public StatementTwo[] Statements
        {
            get;
            set;
        }
    }
}