using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjComparerMinimal
{
    public class JsonComparer
    {
        List<PropertyCompareResult> updated = new List<PropertyCompareResult>();
        public List<PropertyCompareResult> Compare(JObject source, JObject target, string name = "")
        {
            if (source == null || target == null)
            {
                updated.Add(new PropertyCompareResult(name, source, target));
            }
            else
            {
                foreach (KeyValuePair<string, JToken> sourcePair in source)
                {
                    if (sourcePair.Value.Type == JTokenType.Object)
                    {
                        if (target.GetValue(sourcePair.Key) == null || target.GetValue(sourcePair.Key).Type != JTokenType.Object)
                        {
                            updated.Add(new PropertyCompareResult(!string.IsNullOrEmpty(name) ? name + "." +  sourcePair.Key : sourcePair.Key, sourcePair.Value, target.GetValue(sourcePair.Key)));
                        }
                        else
                        {
                            Compare(sourcePair.Value.ToObject<JObject>(),
                                target.GetValue(sourcePair.Key).ToObject<JObject>(), !string.IsNullOrEmpty(name) ? name + "." + sourcePair.Key : sourcePair.Key);
                        }
                    }
                    else if (sourcePair.Value.Type == JTokenType.Array)
                    {
                        if (target.GetValue(sourcePair.Key) == null)
                        {
                            updated.Add(new PropertyCompareResult(sourcePair.Key, sourcePair.Value, target.GetValue(sourcePair.Key)));
                        }
                        else
                        {
                            JArray oldValues = sourcePair.Value.ToObject<JArray>();
                            JArray newValues = target.GetValue(sourcePair.Key).ToObject<JArray>();
                            if (oldValues != null && newValues != null)
                            {
                                int count1 = oldValues != null ? oldValues.Count : 0;
                                int count2 = newValues != null ? newValues.Count : 0;
                                if (count1 == count2)
                                {
                                    for (int i = 0; i < Math.Min(count1, count2); i++)
                                    {
                                        Compare(oldValues[i].ToObject<JObject>(), newValues[i].ToObject<JObject>(), !string.IsNullOrEmpty(name) ? name + "." + sourcePair.Key + "[" + i + "]" : sourcePair.Key + "[" + i + "]");
                                    }
                                }
                                else if (count1 > count2)
                                {
                                    for (int i = Math.Min(count1, count2); i < Math.Max(count1, count2); i++)
                                    {
                                        Compare(oldValues[i].ToObject<JObject>(), null, !string.IsNullOrEmpty(name) ? name + "." + sourcePair.Key + "[" + i + "]" : sourcePair.Key + "[" + i + "]");
                                    }
                                }
                                else
                                {
                                    for (int i = Math.Min(count1, count2); i < Math.Max(count1, count2); i++)
                                    {
                                        Compare(null, newValues[i].ToObject<JObject>(), !string.IsNullOrEmpty(name) ? name + "." + sourcePair.Key + "[" + i + "]" : sourcePair.Key + "[" + i + "]");
                                    }
                                }
                            }
                            else
                            {
                                updated.Add(new PropertyCompareResult(!string.IsNullOrEmpty(name) ? name + "." + sourcePair.Key : sourcePair.Key, oldValues, newValues));
                            }
                        }
                    }
                    else
                    {
                        JToken expected = sourcePair.Value;
                        var actual = target.SelectToken(sourcePair.Key);
                        if (actual == null)
                        {
                            updated.Add(new PropertyCompareResult(!string.IsNullOrEmpty(name) ? name + "." + sourcePair.Key : sourcePair.Key, expected.ToString(), null));
                        }
                        else
                        {
                            if (!JToken.DeepEquals(expected, actual))
                            {
                                updated.Add(new PropertyCompareResult(!string.IsNullOrEmpty(name) ? name + "." + sourcePair.Key : sourcePair.Key, expected.ToString(), actual.ToString()));
                            }
                        }
                    }
                }
            }

            return updated;
        }

        //private static StringBuilder CompareArrays(JArray source, JArray target, string arrayName = "")
        //{
        //    var returnString = new StringBuilder();
        //    for (var index = 0; index < source.Count; index++)
        //    {

        //        var expected = source[index];
        //        if (expected.Type == JTokenType.Object)
        //        {
        //            var actual = (index >= target.Count) ? new JObject() : target[index];
        //            returnString.Append(Compare(expected.ToObject<JObject>(),
        //                actual.ToObject<JObject>()));
        //        }
        //        else
        //        {

        //            var actual = (index >= target.Count) ? "" : target[index];
        //            if (!JToken.DeepEquals(expected, actual))
        //            {
        //                if (String.IsNullOrEmpty(arrayName))
        //                {
        //                    returnString.Append("Index " + index + ": " + expected
        //                                        + " != " + actual + Environment.NewLine);
        //                }
        //                else
        //                {
        //                    returnString.Append("Key " + arrayName
        //                                        + "[" + index + "]: " + expected
        //                                        + " != " + actual + Environment.NewLine);
        //                }
        //            }
        //        }
        //    }
        //    return returnString;
        //}
    }
}
