using System;

namespace CloudFormationCs.Resources.DynamoDB
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class KeySchema
    {
        [Required(true)]
        public String AttributeName { get; set; }

        [Required(true)]
        public KeyType KeyType { get; set; }
    }
}
