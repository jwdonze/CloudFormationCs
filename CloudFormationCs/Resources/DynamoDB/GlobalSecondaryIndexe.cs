using System;

namespace CloudFormationCs.Resources.DynamoDB
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class GlobalSecondaryIndexe
    {
        [Required(true)]
        public String IndexName { get; set; }

        [Required(true)]
        public KeySchema[] KeySchema { get; set; }

        [Required(true)]
        public Projection Projection { get; set; }

        [Required(true)]
        public ProvisionedThroughput ProvisionedThroughput { get; set; }
    }
}
