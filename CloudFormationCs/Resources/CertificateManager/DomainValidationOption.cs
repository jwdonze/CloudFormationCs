using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudFormationCs.Resources.CertificateManager
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html
    /// </summary>
    public class DomainValidationOption
    {
        public string DomainName { get; set; }
        public string ValidationDomain { get; set; }
    }
}
