namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-ipset.html
    ///</summary>
    public class IPSet : Resource
    {
        public StringRef[] Addresses
        {
            get;
            set;
        }

        public StringRef Description
        {
            get;
            set;
        }

        public IPAddressVersions? IPAddressVersion
        {
            get;
            set;
        }

        public StringRef Name
        {
            get;
            set;
        }

        public Scopes? Scope
        {
            get;
            set;
        }

        public Tag[] Tags
        {
            get;
            set;
        }

        public IPSet(): base()
        {
        }

        public IPSet(StringOrEnum resourceIdentifier): base(resourceIdentifier)
        {
        }
        public enum Scopes
        {
            CLOUDFRONT,
            REGIONAL,
        }
        public enum IPAddressVersions
        {
            IPV4,
            IPV6,
        }
    }
}