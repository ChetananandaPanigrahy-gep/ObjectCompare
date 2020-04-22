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
            InvoiceSections invsec1 = JsonConvert.DeserializeObject<InvoiceSections>(File.ReadAllText(@"..\..\..\..\..\1"));
            InvoiceSections invsec2 = JsonConvert.DeserializeObject<InvoiceSections>(File.ReadAllText(@"..\..\..\..\..\2"));
            Console.WriteLine(JsonConvert.SerializeObject(new Comparer().Compare(invsec1, invsec2), Formatting.Indented));
        }


    }
}
