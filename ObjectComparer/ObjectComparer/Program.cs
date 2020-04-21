using System;
using System.Collections.Generic;
using System.IO;
using GEP.SMART.Invoice.BusinessEntities;
using Newtonsoft.Json;

namespace Compare
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

}
