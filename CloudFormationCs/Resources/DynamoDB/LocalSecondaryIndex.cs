using System;

namespace CloudFormationCs.Resources.DynamoDB
{
    /// <summary>
    /// Table.
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class LocalSecondaryIndex
    {
        [Required(true)]
        public String IndexName { get; set; }

        [Required(true)]
        public KeySchema[] KeySchema { get; set; }

        [Required(true)]
        public Projection Projection { get; set; }
    }
}
