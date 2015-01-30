using System;

namespace CloudFormationCs.Resources.DynamoDB
{
    /// <summary>
    /// Table.
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public enum ProjectionType
    {
        KEYS_ONLY,
        INCLUDE,
        ALL,
    }
}
