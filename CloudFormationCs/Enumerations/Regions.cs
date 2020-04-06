using System;
using System.Runtime.Serialization;

namespace CloudFormationCs
{
    public enum Regions
    {
        Undefined,

        [EnumMember(Value = "US East (Ohio)")]
        us_east_2,

        [EnumMember(Value = "US East (N. Virginia)")]
        us_east_1,

        [EnumMember(Value = "US West (Oregon)")]
        us_west_2,

        [EnumMember(Value = "US West (N. California)")]
        us_west_1,

        [EnumMember(Value = "Asia Pacific (Hong Kong)")]
        ap_east_1,

        [EnumMember(Value = "Asia Pacific (Mumbai)")]
        ap_south_1,

        [EnumMember(Value = "Asia Pacific (Osaka-Local)")]
        ap_northeast_3,

        [EnumMember(Value = "Asia Pacific (Seoul)")]
        ap_northeast_2,

        [EnumMember(Value = "Asia Pacific (Singapore)")]
        ap_southeast_1,

        [EnumMember(Value = "Asia Pacific (Sydney)")]
        ap_southeast_2,

        [EnumMember(Value = "Asia Pacific (Tokyo)")]
        ap_northeast_1,

        [EnumMember(Value = "Canada (Central)")]
        ca_central_1,

        [EnumMember(Value = "China (Beijing)")]
        cn_north_1,

        [EnumMember(Value = "China (Beijing Ningxia)")]
        cn_northwest_1,

        [EnumMember(Value = "EU (Frankfurt)")]
        eu_central_1,

        [EnumMember(Value = "EU (Ireland)")]
        eu_west_1,

        [EnumMember(Value = "EU (London)")]
        eu_west_2,

        [EnumMember(Value = "EU (Paris)")]
        eu_west_3,

        [EnumMember(Value = "EU (Stockholm)")]
        eu_north_1,

        [EnumMember(Value = "South America (Sao Paulo)")]
        sa_east_1,

        [EnumMember(Value = "AWS GovCloud (US)")]
        us_gov_east_1,

        [EnumMember(Value = "AWS GovCloud (US-East)")]
        us_gov_west_1,

        [EnumMember(Value = "Middle East (Bahrain)")]
        me_south_1,

    }
}

