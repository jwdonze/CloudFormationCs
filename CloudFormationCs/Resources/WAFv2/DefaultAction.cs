namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-defaultaction.html
    ///</summary>
    public class DefaultAction
    {
        public object Allow
        {
            get;
            set;
        }

        public object Block
        {
            get;
            set;
        }
    }
}