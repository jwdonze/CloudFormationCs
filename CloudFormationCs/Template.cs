using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Reflection;

namespace CloudFormationCs
{
    public class Template
    {
        public String Descrption { get; set; }

        public Parameter[] Parameters { get; set; }

        public IKeyValue[] Mappings { get; set; }

        public List<Resource> Resources { get; set; }

        public Template()
        {
        }
        public string AsJson()
        {
            var ht = new Hashtable();
            ht.Add("AWSTemplateFormatVersion", "2010-09-09");
            if (!string.IsNullOrWhiteSpace(this.Descrption))
            {
                ht.Add("Description", this.Descrption);
            }

            if (this.Parameters != null)
            {
                var ht2 = new Hashtable();
                foreach (var res in this.Parameters)
                {
                    ht2.Add(res.Name, res);
                }
                if (ht2.Count > 0)
                {
                    ht.Add("Parameters", ht2);
                }
            }
			
            if (this.Mappings != null)
            {
                var ht2 = new Hashtable();
                foreach (var res in this.Mappings)
                {
                    ht2.Add(res.Key, res.Value);
                }
                ht.Add("Mappings", ht2);
            }

            if (this.Resources != null)
            {
                var ht2 = new Hashtable();
                foreach (var res in this.Resources)
                {
                    var ht3 = new ResourcePropertyContainer()
                    {
                        Type = CfnHelpers.GetNameFull(res),
                        Version = res.Version,
                        DependsOn = res.DependsOn,
                        Properties = res,
                    };
                    Resources.EC2.Instance ints = res as Resources.EC2.Instance;
                    if (ints != null)
                    {
                        ht3.Metadata = ints.Metadata;
                    }
                    ht2.Add(res.ResourceIdentifier, ht3);
                }
                ht.Add("Resources", ht2);
            }

            var json = new JavaScriptSerializer();
            json.RegisterConverters(new JavaScriptConverter[] { new CustomSerializer(), });

            return json.Serialize(ht);
        }

        private class CustomSerializer : JavaScriptConverter
        {
            public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
            {
                throw new NotImplementedException();
            }

            public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
            {
                const int verbosity = 0;

                if (verbosity > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("============== Serialize " + obj.GetType().FullName);
                }

                var outputDictionary = new Dictionary<string, object>();
                object defValues;
                try
                {
                    defValues = Activator.CreateInstance(obj.GetType());
                }
                catch(Exception ex)
                {
                    throw new Exception("Failed to create object of " + obj.GetType().FullName, ex);
                }
                var kv = obj as IKeyValue;
                if (kv != null)
                {
                    outputDictionary.Add(kv.Key, kv.Value);

                    return outputDictionary;
                }

                var fc = obj as CloudFormationCs.Resources.CloudFormation.fileCollection;
                if (fc != null)
                {
                    foreach (var f in fc)
                    {
                        outputDictionary.Add(f.Key, f.Value);
                    }
                    return outputDictionary;
                }

                foreach (var prop in obj.GetType().GetProperties())
                {
                    bool ignoreProp1 = prop.IsDefined(typeof(ScriptIgnoreAttribute), true)
                        || prop.IsDefined(typeof(NonPropertyAttribute), true)
                         || !prop.CanRead;

                    if (verbosity > 0)
                    {
                        Console.WriteLine("Prop: " + obj.GetType().FullName + "::" + prop.Name + " ignore: " + ignoreProp1);
                        Console.WriteLine("  " + prop.IsDefined(typeof(ScriptIgnoreAttribute), true) + " || " + prop.IsDefined(typeof(NonPropertyAttribute), true) + " || " + !prop.CanRead);
                    }
                    if (!ignoreProp1)
                    {
                        object defValue = prop.GetValue(defValues, BindingFlags.Public, null, null, null);
                        object value = prop.GetValue(obj, BindingFlags.Public, null, null, null);
                        var propName = prop.Name;
                        Array ary = value as Array;

                        var emitNulls = prop.GetCustomAttributes(typeof(CloudFormationCs.EmitNullsAttribute), true);
                        var attrsName = prop.PropertyType.GetCustomAttributes(typeof(CloudFormationCs.ElementNameAttribute), true);
                        if (attrsName.Length > 0)
                        {
                            propName = ((ElementNameAttribute)attrsName[0]).Name;
                        }
                        if (ary != null && ary.Length == 1 )
                        {
                            var compressAttr = prop.GetCustomAttributes(typeof(CloudFormationCs.CompressSingleArrayAttribute), true);
                            if (compressAttr.Length > 0)
                            {
                                value = ary.GetValue(0);
                                ary = null;
                                if (verbosity > 0)
                                {
                                    Console.WriteLine((prop.PropertyType == typeof(StringRef[])) + prop.Name + " " + prop.PropertyType.FullName);
                                }
                            }
                        }
                        CloudFormationCs.EmitAsStringAttribute emitAsStringAttr = null;
                        var emitAsString = prop.GetCustomAttributes(typeof(CloudFormationCs.EmitAsStringAttribute), true);
                        if (emitAsString.Length == 0 && value != null)
                        {
                            if (ary != null)
                            {
                                if (ary.Length > 0)
                                {
                                    if (ary.GetValue(0).GetType() == typeof(CloudFormationCs.StringRef))
                                    {
                                        if (verbosity > 0)
                                        {
                                            Console.WriteLine("StringRef ============ " + prop.Name);
                                        }
                                    }
                                    emitAsString = ary.GetValue(0).GetType().GetCustomAttributes(typeof(CloudFormationCs.EmitAsStringAttribute), true);
                                }
                            }
                            else
                            {
                                emitAsString = value.GetType().GetCustomAttributes(typeof(CloudFormationCs.EmitAsStringAttribute), true);
                            }
                        }
                        if (emitAsString.Length > 0)
                        {
                            emitAsStringAttr = emitAsString[0] as CloudFormationCs.EmitAsStringAttribute;
                        }


                        if (
                                (value == null && defValue != null) 
                                || (value != null && defValue == null) 
                                || (value != null && !value.Equals(defValue))
                                || emitNulls.Length > 0
                            )
                        {
                            if (verbosity > 0)
                            {
                                Console.WriteLine("  - emit");
                            }
                            if (value != null && (emitAsStringAttr != null))
                            {
                                if (value is Boolean)
                                {
                                    outputDictionary.Add(propName, value.ToString().ToLowerInvariant());
                                }
                                else if (ary != null)
                                {
                                    var l = new List<Object>();
                                    foreach (object i in ary)
                                    {
                                        l.Add(emitAsStringAttr.FormatForAws(i));
                                    }
                                    outputDictionary.Add(propName, l);
                                }
                                else
                                {
                                    outputDictionary.Add(propName, emitAsStringAttr.FormatForAws(value));
                                }
                            }
                            else
                            {
                                if (prop.PropertyType.IsEnum)
                                {
                                    value = value.ToString();
                                }
                                outputDictionary.Add(propName, value);
                            }
                        }
                        else
                        {
                            if (verbosity > 0)
                            {
                                Console.WriteLine("  - skip");
                            }
                        }
                    }
                }

                return outputDictionary;
            }

            public override IEnumerable<Type> SupportedTypes
            {
                get { return GetType().Assembly.GetTypes(); }
            }
        }
    }
}

