namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html
    ///</summary>
    public class FieldToMatch
    {
        public object AllQueryArguments
        {
            get;
            set;
        }

        public object Body
        {
            get;
            set;
        }

        public object Method
        {
            get;
            set;
        }

        public object QueryString
        {
            get;
            set;
        }

        public object SingleHeader
        {
            get;
            set;
        }

        public object SingleQueryArgument
        {
            get;
            set;
        }

        public object UriPath
        {
            get;
            set;
        }
    }
}