using System;
using System.Collections;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace CloudFormationCs
{
    /// <summary>
    /// Serializes as either a plain string, a Ref object or a function class.
    /// </summary>
    [EmitAsString(typeof(StringRefFormatter))]
    public class StringRef
    {
        public class StringRefFormatter : IAwsCustomFormatter
        {
            public object FormatForAws(object input)
            {
                var sref = input as StringRef;
                var kv = sref._ref as IKeyValue;
                if (kv == null)
                {
                    return sref._ref;
                }
                else
                {
                    return new Hashtable()
                    {
                        { kv.Key, HashHelper(kv.Value) }
                    };
                }
            }
        }

        public static Object HashHelper(Object value)
        {
            var ht = value as Hashtable;
            if (ht != null)
            {
                var ht2 = new Hashtable();
                foreach (KeyValuePair<string, object> kv in ht)
                {
                    var sr = kv.Value as StringRef;
                    if (sr != null)
                    {
                        ht2.Add(kv.Key, sr.Ref);
                    }
                    else
                    {
                        ht2.Add(kv.Key, HashHelper(kv.Value));
                    }
                }
                value = ht2;
            }
            return value;
        }

        private object _ref;

        [ScriptIgnore]
        public object Ref { get { return this._ref; } }

        public StringRef(IKeyValue reference)
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
    }
}

