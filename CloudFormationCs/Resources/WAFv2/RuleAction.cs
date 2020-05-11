namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html
    ///</summary>
    public class RuleAction
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

        public object Count
        {
            get;
            set;
        }
    }
}