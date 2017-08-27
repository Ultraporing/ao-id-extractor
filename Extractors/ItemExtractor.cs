using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace ao_id_extractor.Extractors
{
    public class ItemExtractor : BaseExtractor
    {
        public ItemExtractor(string outputFolderPath, ExportType exportType) : base(outputFolderPath, exportType)
        {
        }

        protected override List<IDContainer> ExtractFromXML(string xmlFile)
        {
            List<IDContainer> outputList = new List<IDContainer>();
            List<IDContainer> journals = new List<IDContainer>();

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
                    XmlAttribute ent = node.Attributes["enchantmentlevel"];
                    string entch = "";
                    if (ent != null)
                    {
                        entch = "@" + ent.Value;
                    }
                    outputList.Add(new IDContainer() { ID = index.ToString(), Name = aName + entch });
                    index++;

                    if (node.Name == "journalitem")
                    {
                        journals.Add(new IDContainer() { Name = aName });
                    }

                    XmlElement ele = FindElement(node, "enchantments");
                    if (ele != null)
                    {
                        foreach (XmlElement el in ele.ChildNodes)
                        {
                            string eName = node.Attributes["uniquename"].Value + "@" + el.Attributes["enchantmentlevel"].Value;
                            outputList.Add(new IDContainer() { ID = index.ToString(), Name = eName });

                            index++;
                        }
                    }

                }
            }

            ms.Close();


            foreach (IDContainer j in journals)
            {
                outputList.Add(new IDContainer() { ID = index.ToString(), Name = j + "_EMPTY" });
                index++;
                outputList.Add(new IDContainer() { ID = index.ToString(), Name = j + "_FULL" });
                index++;
            }

            return outputList;
        }

        protected override string GetBinFilePath()
        {
            return Path.Combine(AOLauncherFolder, @"..\game\Albion-Online_Data\StreamingAssets\GameData\items.bin");
        }
    }
}
