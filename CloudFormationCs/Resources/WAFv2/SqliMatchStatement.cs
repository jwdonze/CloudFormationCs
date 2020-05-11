namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sqlimatchstatement.html
    ///</summary>
    public class SqliMatchStatement
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