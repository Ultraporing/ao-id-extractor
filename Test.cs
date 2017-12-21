using ao_id_extractor.Extractors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ao_id_extractor
{
    public class Test
    {
        readonly string GAMEDATA_FOLDER = "D:\\AlbionOnline\\game\\Albion-Online_Data\\StreamingAssets\\GameData";
        readonly string CLUSTER_FOLDER = "D:\\AlbionOnline\\game\\Albion-Online_Data\\StreamingAssets\\GameData\\cluster";

        private void ExtractXML()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "xmlFiles");
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                DirectoryInfo di = Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            string[] fileList = { "spells", "mobs", "items", "spellanimmappings", "assetvfx", "sockets", "audio", "buildings",
                                "emotes", "gamedata", "loot", "characters", "guildlogos", "resources", "world", "achievements",
                                "avatars", "missions", "factions", "agents", "accessrights", "territorytypes", "worldsettings",
                                "chatsettings", "treasures", "worldbosses", "resourcedistpresets", "resourceprefabmappings",
                                "expeditioncategories", "expeditions", "expeditionagents", "arena", "randomspawnbehaviors",
                                "itemroles", "orbtypes", "matchtypes", "tokens", "gvgseasons" };

            foreach (string s in fileList)
            {
                string GDbinFilePath = Path.Combine(GAMEDATA_FOLDER, s + ".bin");
                string CLbinFilePath = Path.Combine(CLUSTER_FOLDER, s + ".bin");
                string pathToUse = "";

                if (File.Exists(GDbinFilePath))
                    pathToUse = GDbinFilePath;
                else
                    pathToUse = CLbinFilePath;

                string xmlFilePath = Path.Combine(filePath, s + ".xml");
                string data = BinaryDecrypter.DecryptBinaryFile(pathToUse);
                File.Delete(xmlFilePath);


                StreamWriter sw = File.CreateText(xmlFilePath);
                sw.Write(data);
                sw.Close();
            }
        }

        private h0 InitAOClass()
        {
            h0 h = new h0();
            h.ap(Path.Combine(Directory.GetCurrentDirectory(), "xmlFiles"), Path.Combine(Directory.GetCurrentDirectory(), "xmlFiles"));
            h.bv();

            var itemListObj = h.aq();
            
            int count = 0;
            ca item = itemListObj.ir(count);
            List<ca> itemList = new List<ca>();
            
            while (item != null)
            {
                itemList.Add(item);
                count++;
                item = itemListObj.ir(count);
            }

            List<string> itemUIDS = new List<string>();
            foreach (ca c in itemList)
            {
                itemUIDS.Add(c.d);
            }

            ItemExtractor itemExtractor = new ItemExtractor(Directory.GetCurrentDirectory(), ExportType.Json);
            List<IDContainer> list = itemExtractor.PureExtract(false);

            List<string> nameListExtractor = new List<string>();
            foreach (IDContainer cont in list)
            {
                nameListExtractor.Add(cont.UniqueName);
            }

            for (int id = 0; id < list.Count; id++)
            {
                string dllVal = itemUIDS[id];
                string extrVal = nameListExtractor[id];
                if (dllVal != extrVal)
                    break;
            }
            
            return h;
        }

        public Test()
        {
            ExtractXML();
            h0 myH0 = InitAOClass();
        }
    }
}
