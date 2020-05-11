namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-geomatchstatement.html
    ///</summary>
    public class GeoMatchStatement
    {
        public StringRef[] CountryCodes
        {
            get;
            set;
        }
    }
}