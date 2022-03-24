using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFormationCs.Resources.DMS
{
    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html
    /// </summary>
    public class Endpoint : Resource
    {
        public enum EndpointTypes
        {
            source = 1,
            target,
        }
        public enum EngineNames
        {
            mysql = 1, 
            oracle, 
            postgres, 
            mariadb, 
            aurora, 
            aurora_postgresql, 
            opensearch, 
            redshift, 
            s3, 
            db2, 
            azuredb, 
            sybase, 
            dynamodb, 
            mongodb, 
            kinesis, 
            kafka, 
            elasticsearch, 
            docdb, 
            sqlserver, 
            neptune,
        }

        public Endpoint() : base() { }

        public Endpoint(StringOrEnum resourceIdentifier) : base(resourceIdentifier) { }

        public string CertificateArn { get; set; }
        public string DatabaseName { get; set; }

        public string SslMode { get; set; }
        public string Port { get; set; }
        public EndpointTypes EndpointType { get; set; }
        public string Password { get; set; }
        public string KmsKeyId { get; set; }
        public EngineNames EngineName { get; set; }
        public string Username { get; set; }
        /// <summary>
        /// Server IP address
        /// </summary>
        public string ServerName { get; set; }
        //public Extraconnectionattributes ExtraConnectionAttributes { get; set; }
        public string EndpointIdentifier { get; set; }
        public Tag[] Tags { get; set; }

        // Service Specific Settings

        //public Sybasesettings SybaseSettings { get; set; }
        //public Redissettings RedisSettings { get; set; }
        //public Oraclesettings OracleSettings { get; set; }
        //public Kafkasettings KafkaSettings { get; set; }
        //public Mysqlsettings MySqlSettings { get; set; }
        //public S3settings S3Settings { get; set; }
        //public Resourceidentifier ResourceIdentifier { get; set; }
        //public Kinesissettings KinesisSettings { get; set; }
        //public Redshiftsettings RedshiftSettings { get; set; }
        //public Mongodbsettings MongoDbSettings { get; set; }
        //public Ibmdb2settings IbmDb2Settings { get; set; }
        //public Neptunesettings NeptuneSettings { get; set; }
        //public Elasticsearchsettings ElasticsearchSettings { get; set; }
        //public Docdbsettings DocDbSettings { get; set; }
        //public Dynamodbsettings DynamoDbSettings { get; set; }
        //public Microsoftsqlserversettings MicrosoftSqlServerSettings { get; set; }
        //public Gcpmysqlsettings GcpMySQLSettings { get; set; }
        //public Postgresqlsettings PostgreSqlSettings { get; set; }
    }
}
