using System;
using System.Web.Script.Serialization;

namespace CloudFormationCs.Resources.IAM
{
    /// <summary>
    /// Statement Resource and NotResource may be a single StringRef or an array of StringRef.
    /// AWS Documentation shows arrays being used for AWS::IAM::User and AWS::IAM::Group
    /// and single elements (string, FN::Join, etc) for other resource types.
    /// </summary>
    public class Statement
    {
        [EmitAsStringAttribute]
        public Effects Effect { get; set; }

        public PolicyDocumentStatementActions[] Action { get; set; }

        public Principal Principal { get; set; }

        public Object Resource
        { 
            get
            {
                if (this._resource != null)
                {
                    return this._resource;
                }
                else
                {
                    return this._resources;
                }
            } 
            set
            {
                if (value is StringRef || value is String)
                {
                    if (value is String)
                    {
                        this._resource = new StringRef(value as String);
                    }
                    else
                    {
                        this._resource = (StringRef)value;
                    }
                    this._resources = null;
                }
                else if (value is StringRef[])
                {
                    this._resources = value as StringRef[];
                    this._resource = null;
                }
            }
        }

        public Object NotResource
        { 
            get
            {
                if (this._notResource != null)
                {
                    return this._notResource;
                }
                else
                {
                    return this._notResources;
                }
            } 
            set
            {
                if (value is StringRef)
                {
                    this._notResource = value as StringRef;
                    this._notResources = null;
                }
                else if (value is StringRef[])
                {
                    this._notResources = value as StringRef[];
                    this._notResource = null;
                }
            }
        }

        private StringRef _resource;
        private StringRef _notResource;
        private StringRef[] _resources;
        private StringRef[] _notResources;

        /// <summary>
        /// Creates an array of StringRef with a single value.
        /// </summary>
        [ScriptIgnore]
        public StringRef Resource1 { set { this._resources = new StringRef[] { value }; } }

        /// <summary>
        /// Creates an array of StringRef with a single value.
        /// </summary>
        [ScriptIgnore]
        public StringRef NotResource1 { set { this._notResources = new StringRef[] { value }; } }


        public enum Effects
        {
            Undefined,
            Allow,
            Deny,
        }
    }
}
