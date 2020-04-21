using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using GEP.SMART.Invoice.BusinessEntities;
using Newtonsoft.Json;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestClass invoice1 = new TestClass
            {
                MyProperty1 = 1,
                MyProperty2 = 2,
                TestClassChild = new TestClassChild
                {
                    MyProperty1 = 3
                },
                TestClassChildren = new List<TestClassChild>
                {
                    new TestClassChild{ MyProperty1 = 101},
                    new TestClassChild{ MyProperty1 = 102},
                }

            };
            TestClass invoice2 = new TestClass
            {
                MyProperty1 = 4,
                MyProperty2 = 5,
                TestClassChild = new TestClassChild
                {
                    MyProperty1 = 6
                },
                TestClassChildren = new List<TestClassChild>
                {
                    new TestClassChild{ MyProperty1 = 201},
                    new TestClassChild{ MyProperty1 = 202},
                }
            };
            //Console.WriteLine(JsonConvert.SerializeObject(new Comparer().Compare(invoice1, invoice2), Formatting.Indented));
            InvoiceSections invsec1 = JsonConvert.DeserializeObject<InvoiceSections>(File.ReadAllText(@"..\..\..\..\..\1"));
            InvoiceSections invsec2 = JsonConvert.DeserializeObject<InvoiceSections>(File.ReadAllText(@"..\..\..\..\..\2"));
            Console.WriteLine(JsonConvert.SerializeObject(new Comparer().Compare(invsec1, invsec2), Formatting.Indented));
        }


    }
    class TestClass
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public TestClassChild TestClassChild { get; set; }
        public List<TestClassChild> TestClassChildren { get; set; }
    }
    class TestClassChild
    {
        public int MyProperty1 { get; set; }
    }


    class Comparer
    {
        internal class PropertyCompareResult
        {
            public string PropertyPath { get; private set; }
            public object OldValue { get; private set; }
            public object NewValue { get; private set; }

            public PropertyCompareResult(string propertyPath, object oldValue, object newValue)
            {
                PropertyPath = propertyPath;
                OldValue = oldValue;
                NewValue = newValue;
            }
        }
        List<PropertyCompareResult> updated = new List<PropertyCompareResult>();
        internal List<PropertyCompareResult> Compare<T>(T oldObject, T newObject, string name = "")
        {

            Type t = oldObject != null ? oldObject.GetType() : newObject.GetType();
            PropertyInfo[] properties = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo pi in properties)
            {
                object oldValue = oldObject != null ? pi.GetValue(oldObject) : null, newValue = newObject != null ? pi.GetValue(newObject) : null;
                if (pi.PropertyType.IsPrimitive || pi.PropertyType == typeof(string) || pi.PropertyType == typeof(DateTime))
                {
                    
                    if (!object.Equals(oldValue, newValue))
                    {
                        updated.Add(new PropertyCompareResult(!string.IsNullOrEmpty(name) ? name + "." + pi.Name : pi.Name, oldValue, newValue));
                    }
                }
                else if (pi.PropertyType.GetInterfaces().Any(i => i == typeof(IEnumerable)))
                {
                    IList oldValues = (IList)oldValue;
                    IList newValues = (IList)newValue;
                    if (oldValues != null || newValues != null )
                    {
                        int count1 = oldValues != null ? oldValues.Count : 0;
                        int count2 = newValues != null ? newValues.Count : 0;
                        if (count1 == count2)
                        {
                            for (int i = 0; i < Math.Min(count1, count2); i++)
                            {
                                Compare(oldValues[i], newValues[i], !string.IsNullOrEmpty(name) ? name + "." + pi.Name + "[" + i + "]" : pi.Name + "[" + i + "]");
                            }
                        }
                        else if(count1 > count2)
                        {
                            for (int i = Math.Min(count1, count2); i < Math.Max(count1, count2); i++)
                            {
                                Compare(oldValues[i], null, !string.IsNullOrEmpty(name) ? name + "." + pi.Name + "[" + i + "]" : pi.Name + "[" + i + "]");
                            }
                        }
                        else
                        {
                            for (int i = Math.Min(count1, count2); i < Math.Max(count1, count2); i++)
                            {
                                Compare(null, newValues[i], !string.IsNullOrEmpty(name) ? name + "." + pi.Name + "[" + i + "]" : pi.Name + "[" + i + "]");
                            }
                        }
                    }
                }
                else
                {
                    if (oldValue != null || newValue != null)
                    {
                        Compare(oldValue, newValue, !string.IsNullOrEmpty(name) ? name + "." + pi.Name : pi.Name);
                    }

                }
            }
            return updated;
        }

    }

}
