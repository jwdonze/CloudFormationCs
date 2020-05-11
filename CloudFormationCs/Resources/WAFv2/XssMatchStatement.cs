namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-xssmatchstatement.html
    ///</summary>
    public class XssMatchStatement
    {
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