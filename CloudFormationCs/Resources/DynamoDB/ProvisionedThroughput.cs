using System;

namespace CloudFormationCs.Resources.DynamoDB
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class ProvisionedThroughput
    {
        [Required(true)]
        public Int32 ReadCapacityUnits { get; set; }

        [Required(true)]
        public Int32 WriteCapacityUnits { get; set; }
    }
}
