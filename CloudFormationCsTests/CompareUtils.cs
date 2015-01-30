using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace CloudFormationCsTests
{
    public static class CompareUtils
    {
        public static bool TemplatesAreEqual(string expected, CloudFormationCs.Template template)
        {
            var output = template.AsJson();
            return TemplatesAreEqual(expected, output);
        }
        public static bool TemplatesAreEqual(string expected, string output)
        {
            var json = new JavaScriptSerializer();
            Dictionary<string, object> htExpected;
            Dictionary<string, object> htReturned;

            try
            {
                htExpected = json.Deserialize<Dictionary<string, object>>(expected);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to deserialize expected");
                Console.WriteLine();
                Console.WriteLine(expected);
                Console.WriteLine();

                throw ex;
            }
            try
            {
                htReturned = json.Deserialize<Dictionary<string, object>>(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to deserialize output");
                Console.WriteLine();
                Console.WriteLine(output);
                Console.WriteLine();

                throw ex;
            }

            var eq = DictEquals(htExpected, htReturned);

            if (!eq)
            {
                Console.WriteLine();
                Console.WriteLine(TryFormat(expected));
                Console.WriteLine();
                Console.WriteLine(TryFormat(output));
                Console.WriteLine();
            }
            return eq;
        }

        public static string TryFormat(string json)
        {
            return TryFormat(json, false);
        }
        public static string TryFormat(string json, bool sort)
        {
            try
            {
                var parsedJson = new JavaScriptSerializer().Deserialize <Dictionary<string, Object>>(json);

                if (sort)
                {
                    var sortedObject = new Dictionary<string, object>();
                    string[] keys = parsedJson.Keys.ToArray();
                    Array.Sort<string>(keys);
                    foreach (string k in keys)
                    {
                        sortedObject.Add(k, TrySort(parsedJson[k]));
                    }
                    parsedJson = sortedObject;
                }

                return Newtonsoft.Json.JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.Indented).Replace("  ", "      ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("excption formatting: " + ex.Message);
                return json;
            }
        }
        private static object TrySort(object inObject)
        {
            var name = inObject.GetType().FullName;

            var sortedObject = new Dictionary<string, object>();
            var unsortedDict = inObject as Dictionary<string, object>;
            if (unsortedDict != null)
            {
                var keysList = new List<string>();
                foreach (var x in unsortedDict)
                {
                    keysList.Add(x.Key);
                }
                string[] keys = keysList.ToArray();
                Array.Sort<string>(keys);
                //Console.WriteLine("sort 1 " + name);
                foreach (string k in keys)
                {
                    //Console.WriteLine("   key 1 = " + k);
                    sortedObject.Add(k, TrySort(unsortedDict[k]));
                }
                return sortedObject;
            }

            var ary = inObject as System.Collections.ArrayList;
            if (ary != null)
            {
                var sorted = new List<object>();
                foreach (var e in ary)
                {
                    sorted.Add(TrySort(e));
                }
                return sorted.ToArray();
            }

            return inObject;
        }

        public static bool DictEquals(object left, object right)
        {
            return DictEquals(left, right, "/", false);
        }

        private static bool DictEquals(object left, object right, string trace, bool expectMismatch)
        {
            if (left == null && right == null)
            {
                return true;
            }
            if (left == null || right == null)
            {
                if (!expectMismatch)
                {
                    Console.WriteLine("NULL != at " + trace);
                }
                return false;
            }
            var leftType = left.GetType().FullName;
            var rightType = right.GetType().FullName;

            if (leftType != rightType)
            {
                if (!expectMismatch)
                {
                    Console.WriteLine("types " + leftType + " != " + rightType + " not equal at " + trace);
                }
                return false;
            }
            if (left.GetType() == typeof(Dictionary<string, object>))
            {
                if (!expectMismatch)
                {
                   // Console.WriteLine("DICT START " + trace);
                }

                var d1 = left as Dictionary<string, object>;
                var d2 = right as Dictionary<string, object>;

                if (d1.Count != d2.Count)
                {
                    if (!expectMismatch)
                    {
                        Console.WriteLine("dict count " + d1.Count + " != " + d2.Count + " " + trace);
                    }
                    return false;
                }

                foreach (KeyValuePair<string, object> pair in d1)
                {

                    if (!d2.ContainsKey(pair.Key))
                    {
                        if (!expectMismatch)
                        {
                            Console.WriteLine(pair.Key + " Not found in d2 " + trace);
                        }
                        return false;
                    }
                    if (!DictEquals(pair.Value, d2[pair.Key], trace + pair.Key + "/", expectMismatch))
                    {
                        if (!expectMismatch)
                        {
                            //Console.WriteLine ("dict not equal at " + trace + " Key=" + pair.Key);
                        }
                        return false;
                    }
                }
                if (!expectMismatch)
                {
                   // Console.WriteLine("DICT END " + trace);
                }
            }
            else if (left.GetType() == typeof(System.Collections.ArrayList))
            {
                if (!expectMismatch)
                {
                    //Console.WriteLine("ARRAYLIST START " + trace);
                }

                var a1 = left as System.Collections.ArrayList;
                var a2 = right as System.Collections.ArrayList;

                if (a1.Count != a2.Count)
                {
                    if (!expectMismatch)
                    {
                        Console.WriteLine("array count" + a1.Count + " != " + a2.Count + " " + trace);
                    }
                    return false;
                }
                if (!expectMismatch)
                {
                    Console.WriteLine("  array count = " + a1.Count);
                }
                int ac = 0;
                foreach (object listLeft in a1)
                {
                    var found = false;
                    var bc = 0;
                    foreach (object listRight in a2)
                    {
                        if (DictEquals(listLeft, listRight, trace, true))
                        {
                            found = true;
                            break;
                        }
                        bc++;
                    }
                    if (!found)
                    {
                        if (!expectMismatch)
                        {
                            Console.WriteLine("array mismatch at " + trace + " ac=" + ac);
                            Console.WriteLine("================== LEFT ================== ");
                            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(listLeft, Newtonsoft.Json.Formatting.Indented));
                            Console.WriteLine("================== RIGHT ================== ");
                            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(a2, Newtonsoft.Json.Formatting.Indented));
                            Console.WriteLine("================== DONE ================== ");
                        }
                        return false;
                    }
                    ac++;
                }
                if (!expectMismatch)
                {
                    //Console.WriteLine("ARRAYLIST END " + trace);
                }
            }
            else
            {
                if (!expectMismatch)
                {
                    //Console.WriteLine("SIMPLE " + trace);
                }

                if (!Equals(left, right))
                {
                    if (!expectMismatch)
                    {
                        Console.WriteLine("values '" + left + "' != '" + right + "' not equal at " + trace);
                    }
                    return false;
                }
            }
            if (!expectMismatch)
            {
                //Console.WriteLine("  ARE EQUAL");
            }
            return true;
        }
    }
}
