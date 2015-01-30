using System;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class Stack : Resource
    {
        public String[] NotificationARNs { get; set; }

        public Entity.Parameters Parameters { get; set; }

        public String TemplateURL { get; set; }

        public String TimeoutInMinutes { get; set; }

        public Stack()
            : base()
        {
        }

        public Stack(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
