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
        public string Index { get; set; }
        public string UniqueName { get; set; }
    }

    public class ItemContainer : IDContainer
    {
        public string LocalizationNameVariable { get; set; }
        public string LocalizationDescriptionVariable { get; set; }
        public Dictionary<string, string> LocalizedNames { get; set; }
        public Dictionary<string, string> LocalizedDescriptions { get; set; }
    }

    public enum ExportType
    {
        TextList,
        Json
    }

    public abstract class BaseExtractor
    {
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

        protected abstract string GetBinFilePath();
        protected abstract List<IDContainer> ExtractFromXML(string xmlFile, bool withLocal = true);

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

        public void Extract(bool withLocal = true)
        {
            string s = DecryptBinFile(GetBinFilePath());
            List<IDContainer> ls = ExtractFromXML(s, withLocal);
            File.Delete(s);

            WriteToFile(ls);
        }

        public List<IDContainer> PureExtract(bool withLocal = true)
        {
            string s = DecryptBinFile(GetBinFilePath());
            return ExtractFromXML(s, withLocal);
        }

        private string DecryptBinFile(string binFile)
        {
            string output = BinaryDecrypter.DecryptBinaryFile(binFile);
            string binFileWOE = Path.GetFileNameWithoutExtension(binFile);

            StreamWriter sw = File.CreateText(binFileWOE + ".xml");
            sw.Write(output);
            sw.Close();

            return binFileWOE + ".xml";
        }

        private void WriteToFile(List<IDContainer> items)
        {

            string filePath = Path.Combine(OutputFolderPath, Path.GetFileNameWithoutExtension(GetBinFilePath())) + (ExportType == ExportType.TextList ? ".txt" : ".json");
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                DirectoryInfo di = Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            StreamWriter sw = File.CreateText(filePath);
            
            if (ExportType == ExportType.TextList)
            {
                foreach (IDContainer i in items)
                {
                    sw.WriteLine("{0}:{1}", i.Index, i.UniqueName);
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
