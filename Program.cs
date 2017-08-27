using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ao_id_extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Views.MainView());

            


            Extractors.LocationExtractor aol = new Extractors.LocationExtractor("", Extractors.ExportType.TextList);
            aol.Extract();
        }
    }
}
