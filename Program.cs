using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace XmlThingy
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ao-itemid-extractor <ItemsBinFile> [outputfile]");
                Console.ReadKey();
                return;
            }

            // Create the extractor
            AO_XML_ItemExtractor aox = new AO_XML_ItemExtractor();
            
            // use the Bin specified in the first parameter
            List<string> items = aox.Extract(args[0]);

            // Write items to file specified in second param or default name
            aox.WriteToFile(args.Length > 1 ? args[1] : "AOItems.txt", items);
        }
    }
}
