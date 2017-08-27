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
        static void PrintCmdHelp()
        {
            Console.WriteLine("How to use:\nao-id-extractor.exe modeID outFormat [outFolder]\n" +
                "modeID\t\t#0=Item Extraction, 1= Location Extraction, 2=Both\n" +
                "outFormat\t#l=Text List, j=JSON\n" +
                "[outFolder]\t#OPTITIONAL: Output folder path. Default: current directory");
        }

        static List<string> ParseCommandline(string[] args)
        {
            string modeID;
            string outFormat;
            string outFolder = "";

            if (args.Length >= 2)
            {
                
                if (int.Parse(args[0]) > -1 && int.Parse(args[0]) <= 2)
                {
                    modeID = args[0];
                }
                else
                {
                    PrintCmdHelp();
                    return null;
                }

                
                if (args[1] == "l" || args[1] == "j")
                {
                    outFormat = args[1];
                }
                else
                {
                    PrintCmdHelp();
                    return null;
                }

                if (args.Length == 3)
                {
                    outFolder = args[2];
                }
            }
            else
            {
                PrintCmdHelp();
                return null;
            }

            return new List<string>() { modeID, outFormat, outFolder};
        }

        static void Main(string[] args)
        {
            List<string> cmds = ParseCommandline(args);

            if (cmds == null)
            {
                Console.Read();
                return;
            }

            if (cmds[0] == "0" || cmds[0] == "2")
            {
                new Extractors.ItemExtractor(cmds[2], cmds[1] == "l" ? Extractors.ExportType.TextList : Extractors.ExportType.Json).Extract();
            }

            if (cmds[0] == "1" || cmds[0] == "2")
            {
                new Extractors.LocationExtractor(cmds[2], cmds[1] == "l" ? Extractors.ExportType.TextList : Extractors.ExportType.Json).Extract();
            }
        }
    }
}
