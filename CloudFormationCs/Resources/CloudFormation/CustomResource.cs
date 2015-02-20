using System;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class CustomResource : Resource
    {
        public CustomResource()
            : base()
        {
            throw new NotImplementedException();
        }

        public CustomResource(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
