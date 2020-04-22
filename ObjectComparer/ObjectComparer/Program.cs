using System;
using System.IO;
using GEP.SMART.Invoice.BusinessEntities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjComparerMinimal;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InvoiceSections invsec1 = JsonConvert.DeserializeObject<InvoiceSections>(File.ReadAllText(@"..\..\..\..\..\1"));
            InvoiceSections invsec2 = JsonConvert.DeserializeObject<InvoiceSections>(File.ReadAllText(@"..\..\..\..\..\2"));
            Console.WriteLine(JsonConvert.SerializeObject(new ObjectComparer().Compare(invsec1, invsec2), Formatting.Indented));
            JObject inv1 = JObject.Parse(File.ReadAllText(@"..\..\..\..\..\1"));
            JObject inv2 = JObject.Parse(File.ReadAllText(@"..\..\..\..\..\2"));
            Console.WriteLine(JsonConvert.SerializeObject(new JsonComparer().Compare(inv1, inv2), Formatting.Indented));
        }
    }
}
