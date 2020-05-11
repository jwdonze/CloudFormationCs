namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html
    ///</summary>
    public class ByteMatchStatement
    {
        public FieldToMatch FieldToMatch
        {
            get;
            set;
        }

        public StringRef PositionalConstraint
        {
            get;
            set;
        }

        public StringRef SearchString
        {
            get;
            set;
        }

        public StringRef SearchStringBase64
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