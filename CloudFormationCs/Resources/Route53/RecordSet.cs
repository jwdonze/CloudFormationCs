using System;
using System.Text;

namespace CloudFormationCs.Resources.Route53
{
    public class RecordSet : Resource
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public AliasTarget AliasTarget { get; set; }

        [Required(false)]
        public String Comment { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String HostedZoneId { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String HostedZoneName { get; set; }

        [Required(true)]
        public String Name { get; set; }

        [Required(false)]
        public String Region { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String[] ResourceRecords { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public String SetIdentifier { get; set; }

        [Required(false)]
        public String TTL { get; set; }

        [Required(true)]
        [EmitAsString]
        public NameTypes? Type { get; set; }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public Int32 Weight { get; set; }

        public RecordSet()
            : base()
        {
        }

        public RecordSet(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }

        public static string EscapeText(string stringIn)
        {
            var sb = new StringBuilder();
            const string stringOk = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!\"#$%&'()*+,-/:;<=>?@[\\]^_`{|}~. ";
            foreach (var charIn in stringIn.ToCharArray())
            {
                if (stringOk.IndexOf(charIn) >= 0)
                {
                    sb.Append(charIn);
                }
                else
                {
                    sb.Append("\\");
                    sb.Append(Convert.ToString((int)charIn, 8).PadLeft(3, '0'));
                }
            }
            return sb.ToString();
        }
    }
    public enum NameTypes
    {
        A = 1,
        AAAA,
        CNAME,
        MX,
        NS,
        PTR,
        SOA,
        SPF,
        SRV,
        TXT,
    }
}
