using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace XmlThingy
{
    public class AO_XML_ItemExtractor
    {
        private XmlElement FindElement(XmlNode node, string elementName)
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

        public List<string> Extract(string binFile)
        {
            string s = DecryptAndExtract(binFile);
            List<string> ls = ExtractItems(s);
            File.Delete(s);

            return ls;
        }

        private string DecryptAndExtract(string binFile)
        {
            
            string binFileWOE = Path.GetFileNameWithoutExtension(binFile);

            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "quickbms.exe";
            p.StartInfo.Arguments = "decryptAObin.bms " + binFile + " .";

            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            return binFileWOE + ".xml";
        }

        private List<string> ExtractItems(string xmlFile)
        {
            List<string> outputList = new List<string>();
            List<string> journals = new List<string>();

            // Param 0 is the xml file
            byte[] encodedString = Encoding.UTF8.GetBytes(File.ReadAllText(xmlFile, Encoding.UTF8));

            // Put the byte array into a stream and rewind it to the beginning
            MemoryStream ms = new MemoryStream(encodedString);
            ms.Flush();
            ms.Position = 0;

            // Build the XmlDocument from the MemorySteam of UTF-8 encoded bytes
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ms);

            XmlNode rootNode = xmlDoc.LastChild;

            int index = 0;
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    string aName = node.Attributes["uniquename"].Value;
                    outputList.Add("[" + index + "]:" + aName);
                    index++;

                    if (node.Name == "journalitem")
                    {
                        journals.Add(aName);
                    }

                    XmlElement ele = FindElement(node, "enchantments");
                    if (ele != null)
                    {
                        foreach (XmlElement el in ele.ChildNodes)
                        {
                            string eName = node.Attributes["uniquename"].Value;
                            outputList.Add("[" + index + "]:" + eName);
                            index++;
                        }
                    }

                }
            }

            ms.Close();
 

            foreach (string j in journals)
            {
                outputList.Add("[" + index + "]:" + j + "_EMPTY");
                index++;
                outputList.Add("[" + index + "]:" + j + "_FULL");
                index++;
            }

            return outputList;
        }

        public void WriteToFile(string fileName, List<string> items)
        {
            var sw = File.CreateText(fileName);

            foreach (string s in items)
            {
                sw.WriteLine(s);
            }

            sw.Close();
        }
    }
}
