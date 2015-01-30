using System;

namespace CloudFormationCs.Resources.DynamoDB
{
    /// <summary>
    /// Table.
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class Projection
    {
        [Required(false)]
        public String[] NonKeyAttributes { get; set; }

        [Required(false)]
        public ProjectionType ProjectionType { get; set; }
    }
}
