using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            // make new JObject from filestream text
            JObject obj = JObject.Parse(text);
            List<object> tiles = new List<object>();

            // count amount of tile object in JSON
            int count = obj["features"].Count();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(obj["features"][count]["properties"]["name"]);
            }


            string firstDrive = (string)obj["features"][0]["properties"]["name"];
            Console.WriteLine(firstDrive);


        }

        public int tileSize()
        {
            string text;
            FileStream fileStream = new FileStream(@"C:\Users\Paul\Documents\GitHub\ConsoleTileQA\TileLayout.json", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            JObject obj = JObject.Parse(text);


            int xmax = (int)obj["features"][0]["properties"]["xmax"];
            int xmin = (int)obj["features"][0]["properties"]["xmin"];

            int size = xmax - xmin;

            return size;

        }


    }

}
