using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

namespace TileQA
{

    class TcTileLayoutParser
    {
        /// <summary>
        /// GetLayout
        /// </summary>
        /// <param name="prmFilePath">The .json file.</param>
        /// <returns>new TcTileLayout Object</returns>
        public static TcTileLayout GetLayout(string prmFilePath)
        {
            Debug.Assert(File.Exists(prmFilePath), "File Not found.");

            var fileData = File.ReadAllText(prmFilePath);
            var obj      = JsonConvert.DeserializeObject<TcTileLayout>(fileData);

            if (obj != null)
            {
                return obj;
            }

            throw new JsonSerializationException("Could not deserialize TcFileLayout from lpFile");
        }

        #region IDisposable 
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

        //string json = File.ReadAllText(@"C:\Users\Paul\Documents\GitHub\ConsoleTileQA\TileLayout.json");

        //not sure the point of all of this.
        /*
        public List<object> stringParser()
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

            string tileName;

            // count amount of tile object in JSON
            int count = obj["features"].Count();

            for (int i = 0; i < count; i++)
            {
                tileName = (string)obj["features"][i]["properties"]["name"];

                tiles.Add(tileName);
                
            }

            return tiles;

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
        */

    }

}
