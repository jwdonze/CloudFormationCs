using System;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CloudFormationCs
{
    /// <summary>
    /// Serializes as either a plain string, a Ref object or a function class.
    /// </summary>
    public class StringRef
    {
        private object _ref;

       // [JsonIgnore]
        public object Ref { get { return this._ref; } }

        public StringRef(Ref reference)
        {
            this._ref = reference;
        }
        public StringRef(IWriteObject reference)
        {
            this._ref = reference;
        }

        public StringRef(String reference)
        {
            this._ref = reference;
        }

        public StringRef()
        {
        }

        public override string ToString()
        {
            return this._ref != null ? this._ref.ToString() : null;
        }

        public static implicit operator StringRef(String d)
        {
            return new StringRef(d);
        }

        public static implicit operator StringRef(Fn__GetAZs d)
        {
            return new StringRef(d);
        }

        public static implicit operator StringRef(Ref d)
        {
            return new StringRef(d);
        }

        public static implicit operator StringRef(InstanceTypes d)
        {
            return new StringRef(CfnHelpers.GetInstnaceName(d));
        }

        public static implicit operator StringRef(Fn__GetAtt d)
        {
            return new StringRef(d);
        }

        public static implicit operator StringRef(Fn__Join d)
        {
            return new StringRef(d);
        }
        public static implicit operator StringRef(Fn__FindInMap d)
        {
            return new StringRef(d);
        }
        public static implicit operator StringRef(Fn__Base64 d)
        {
            return new StringRef(d);
        }
        public static implicit operator StringRef(Fn__Sub d)
        {
            return new StringRef(d);
        }
    }
}

