namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html
    ///</summary>
    public class WebACL : Resource
    {
        public DefaultAction DefaultAction
        {
            get;
            set;
        }

        public StringRef Description
        {
            get;
            set;
        }

        public StringRef Name
        {
            get;
            set;
        }

        public Rule[] Rules
        {
            get;
            set;
        }

        public StringRef Scope
        {
            get;
            set;
        }

        public Tag[] Tags
        {
            get;
            set;
        }

        public VisibilityConfig VisibilityConfig
        {
            get;
            set;
        }

        public WebACL(): base()
        {
        }

        public WebACL(StringOrEnum resourceIdentifier): base(resourceIdentifier)
        {
        }
    }
}