namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html
    ///</summary>
    public class SizeConstraintStatement
    {
        public StringRef ComparisonOperator
        {
            get;
            set;
        }

        public FieldToMatch FieldToMatch
        {
            get;
            set;
        }

        public int Size
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