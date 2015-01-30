using System;

namespace CloudFormationCs.Resources.DynamoDB
{
    /// <summary>
    /// Table.
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class Table : Resource
    {
        [Required(true)]
        public AttributeDefinition[] AttributeDefinitions { get; set; }

        [Required(false)]
        public GlobalSecondaryIndexe[] GlobalSecondaryIndexes { get; set; }

        [Required(true)]
        public KeySchema[] KeySchema { get; set; }

        [Required(false)]
        public LocalSecondaryIndex[] LocalSecondaryIndexes { get; set; }

        [Required(true)]
        public ProvisionedThroughput ProvisionedThroughput { get; set; }

        [Required(false)]
        public String TableName { get; set; }

        public Table()
            : base()
        {
        }

        public Table(string resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
