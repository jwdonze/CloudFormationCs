namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexpatternsetreferencestatement.html
    ///</summary>
    public class RegexPatternSetReferenceStatement
    {
        public StringRef Arn
        {
            get;
            set;
        }

        public FieldToMatch FieldToMatch
        {
            get;
            set;
        }

        public TextTransformation[] TextTransformations
        {
            get;
            set;
        }
    }
}