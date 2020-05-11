namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetreferencestatement.html
    ///</summary>
    public class IPSetReferenceStatement
    {
        public StringRef Arn
        {
            get;
            set;
        }
    }
}