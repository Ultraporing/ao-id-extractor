using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using ao_id_extractor.Helpers;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace ao_id_extractor.Extractors
{
    public class IDContainer
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public enum ExportType
    {
        TextList,
        Json
    }

    public abstract class BaseExtractor
    {
        protected string BinFilePath { get; set; }
        protected string OutputFolderPath { get; set; }
        protected ExportType ExportType { get; set; }
        protected string AOLauncherFolder { get; set; }

        public BaseExtractor(string outputFolderPath, ExportType exportType)
        {
            OutputFolderPath = outputFolderPath == string.Empty ? Path.GetDirectoryName(Application.ExecutablePath) : outputFolderPath;
            ExportType = exportType;

            string obj = (string)Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\SandboxAlbionOnline", false).GetValue("DisplayIcon");
            AOLauncherFolder = Path.GetDirectoryName(obj.Trim('\"'));
        }
        
        protected abstract List<IDContainer> ExtractFromXML(string xmlFile);

        protected XmlElement FindElement(XmlNode node, string elementName)
        {
            foreach (XmlElement ele in node.ChildNodes)
            {
                if (ele.Name == elementName)
                {
                    return ele;
                }
            }

            return null;
        }

        public void Extract()
        {
            string s = DecryptBinFile(BinFilePath);
            List<IDContainer> ls = ExtractFromXML(s);
            File.Delete(s);

            WriteToFile(ls);
        }

        private string DecryptBinFile(string binFile)
        {
            string binFileWOE = Path.GetFileNameWithoutExtension(binFile);

            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "quickbms.exe";
            p.StartInfo.Arguments = "-R -Q decryptAObin.bms " + binFile + " .";

            p.Start();

            string output = p.StandardOutput.ReadToEnd();

            p.WaitForExit();

            return binFileWOE + ".xml";
        }

        private void WriteToFile(List<IDContainer> items)
        {

            string filePath = Path.Combine(OutputFolderPath, Path.GetFileNameWithoutExtension(BinFilePath)) + (ExportType == ExportType.TextList ? ".txt" : ".json");
            StreamWriter sw = File.CreateText(filePath);
            
            if (ExportType == ExportType.TextList)
            {
                foreach (IDContainer i in items)
                {
                    sw.WriteLine("{0}:{1}", i.ID, i.Name);
                }               
            }
            else if (ExportType == ExportType.Json)
            {
                sw.Write(JSONHelper.FormatJson(items.ToJSON()));
            }

            sw.Close();
        }
    }
}
