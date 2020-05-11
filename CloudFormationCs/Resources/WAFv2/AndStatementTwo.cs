namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-andstatementtwo.html
    ///</summary>
    public class AndStatementTwo
    {
        public StatementThree[] Statements
        {
            get;
            set;
        }
    }
}