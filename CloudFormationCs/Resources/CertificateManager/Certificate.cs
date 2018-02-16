using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudFormationCs.Resources.CertificateManager
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html
    /// </summary>
    public class Certificate : Resource
    {
        public StringRef DomainName { get; set; }

        public DomainValidationOption[] DomainValidationOptions { get; set; }

        public String[] SubjectAlternativeNames { get; set; }

        public Tag[] Tags { get; set; }

        public Certificate()
            : base()
        {
        }

        public Certificate(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
