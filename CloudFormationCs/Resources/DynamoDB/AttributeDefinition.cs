using System;

namespace CloudFormationCs.Resources.DynamoDB
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class AttributeDefinition
    {
        [Required(true)]
        public String AttributeName { get; set; }

        [Required(true)]
        public String AttributeType { get; set; }
    }
}
