using System;
using TileQA.Types;

namespace TileQA
{
    class Program
    {
        static void Main(string[] args)
        {
            //SQLiteConnection sqlite_conn;
            //sqlite_conn =  DBConnector.CreateConnection();

            //List<dynamic> showDb;

            //DBConnector readList;
            //readList = DBConnector.ReadAll("TestProject");

            //ConsoleTileQA.JSONParser test = new ConsoleTileQA.JSONParser();

            //List<object> tiles = new List<object>(test.stringParser());

            //foreach (var item in tiles)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(test.tileSize());


            using (var layout = TcTileLayoutParser.GetLayout(@"..\..\..\..\TileLayout.json"))
            {
                foreach (var feature in layout.Features)
                {
                    if (feature.Geometry.Type == "Polygon")
                    {
                        var tile = new TcTile
                        {
                            TileName      = feature.Properties.Name,
                            ThisTileState = TileState.notChecked,
                            Rect          = new TcTileRect(feature.Geometry)
                        };

                        Console.WriteLine("Tile: {0} TileSize: {1}", tile, tile.TileSideLength);
                    }

                }
            }
        }
    }



}
