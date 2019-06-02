using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;

namespace ConsoleTileQA
{
    
    class JSONParser
    {
        //read json into text then pass to newtonsoft
        string json = File.ReadAllText(@"C:\Users\Paul\Documents\GitHub\ConsoleTileQA\TileLayout.json");


        public void stringParser()
        {
            string text;
            FileStream fileStream = new FileStream(@"C:\Users\Paul\Documents\GitHub\ConsoleTileQA\TileLayout.json", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            var tile = JsonConvert.DeserializeObject<jsonTile>(json);
            Console.WriteLine(tile.name + tile.xmax + tile.xmin);
            Console.WriteLine(tile);

            JObject o = JObject.Parse(json);

            List<jsonTile> list = JsonConvert.DeserializeObject<List<jsonTile>>(o["name"].ToString());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Last line");


        }


    }

    class jsonTile
    {
        [JsonProperty]
        public string name { get; set; }
        [JsonProperty]
        public string xmax { get; set; }
        [JsonProperty]
        public string xmin { get; set; }

    }
}
