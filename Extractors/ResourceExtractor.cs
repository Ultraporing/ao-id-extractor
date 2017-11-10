using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace ao_id_extractor.Extractors
{
    

    public class ResourceExtractor : BaseExtractor
    {
        public ResourceExtractor(string outputFolderPath, ExportType exportType) : base(outputFolderPath, exportType)
        {
            
        }
        
        protected override List<IDContainer> ExtractFromXML(string xmlFile)
        {
            HashSet<IDContainer> outputList = new HashSet<IDContainer>();

            // Param 0 is the xml file
            byte[] encodedString = Encoding.UTF8.GetBytes(File.ReadAllText(xmlFile, Encoding.UTF8));

            // Put the byte array into a stream and rewind it to the beginning
            MemoryStream ms = new MemoryStream(encodedString);
            ms.Flush();
            ms.Position = 0;

            // Build the XmlDocument from the MemorySteam of UTF-8 encoded bytes
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ms);

            XmlNode rootNode = xmlDoc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    string locID = node.Attributes["id"].Value;
                    string locName = node.Attributes["displayname"].Value;

                    outputList.Add(new IDContainer() { Index = locID, UniqueName = locName });
                }
            }

            ms.Close();

            return outputList.ToList();
        }

        //private Dictionary<string, hx> bo = new Dictionary<string, hx>();
        //private List<string> bs = new List<string>();
        //private HashSet<string> bl = new HashSet<string>();
        /*
        private void ib(List<string> A_0)
        {
            this.bs = A_0;
        }

        private void ParseResourceElement(XmlElement ele)
        {
            if (ele.Name != "AO-Resources")
            {
                throw new Exception("[ResourceData] LoadDataFromXml: XmlTag AO-Resources not found! Invalid Xml File?");
            }
            foreach (XmlNode xmlNode in ele.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (!(name == "Harvestables"))
                    {
                        if (name == "Resources")
                        {
                            this.ib(xmlElement);
                        }
                    }
                    else
                    {
                        this.ic(xmlElement);
                    }
                }
            }
            this.ib(new List<string>(this.bo.Keys));
            this.bs.Sort();
        }

        static int b = 0;
        

        private void ic(XmlElement A_0)
        {
            b = 0;
            this.bl.Clear();
            foreach (XmlElement xmlElement in A_0.GetElementsByTagName("Harvestable"))
            {
                string text = al5.A(xmlElement, "name", "");
                if (string.IsNullOrEmpty(text))
                {
                    throw new Exception("[GameData] couldn't parse Harvestable element " + xmlElement.Name);
                }
                string a_ = al5.A(xmlElement, "resource", "");
                if (string.IsNullOrEmpty(text))
                {
                    throw new Exception("[GameData] couldn't parse Harvestable element " + xmlElement.Name);
                }

                hv hv = new hv(text, a_);
                hv.E(xmlElement);
                this.bm[text] = hv;
                this.bn[hv.H()] = hv;
                if (!text.Contains("SILVERCOINS") && !text.Contains("ESSENCE"))
                {
                    this.bl.Add(text);
                }
                this.bl.Add("MOBCAMP");
            }
        }


        private void ib(XmlElement A_0)
        {
            hx.C();
            foreach (XmlElement a_ in A_0.GetElementsByTagName("Resource"))
            {
                hx hx = new hx();
                hx.C(a_);
                this.bo[hx.D()] = hx;
                this.bp[hx.E()] = hx;
            }
        }
        */
        protected override string GetBinFilePath()
        {
            return Path.Combine(AOLauncherFolder, @"..\game\Albion-Online_Data\StreamingAssets\GameData\resources.bin");
        }
    }
}
