namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-texttransformation.html
    ///</summary>
    public class TextTransformation
    {
        public int Priority
        {
            get;
            set;
        }

        public Types Type
        {
            get;
            set;
        }

        public enum Types
        {
            CMD_LINE, 
            COMPRESS_WHITE_SPACE, 
            HTML_ENTITY_DECODE, 
            LOWERCASE, 
            NONE, 
            URL_DECODE,
        }
    }
}