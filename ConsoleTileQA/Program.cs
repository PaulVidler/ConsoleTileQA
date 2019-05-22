using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;
using ConsoleTileQA.DBConnection;

namespace TileQA
{
    class Program
    {
        static void Main(string[] args)
        {

            SQLiteConnection sqlite_conn;
            sqlite_conn =  DBConnector.CreateConnection();

            DBConnector.InsertData(sqlite_conn);

            //var lines = File.ReadLines(@"C:\Users\User\Desktop\tile.txt");

            //QAProject project = new QAProject();

            //foreach (var line in lines)
            //{
            //    Tile newTile = new Tile();
            //    newTile.TileName = line;
            //    newTile.TileSideLength = 500;

            //    Console.WriteLine("Line: " + line);

            //    Console.WriteLine("Tile name : " + newTile.TileName);
            //    Console.WriteLine("Tile colour: " + newTile.TileColour);
            //    Console.WriteLine("State of tile: " + newTile.ThisTileState);
            //    Console.WriteLine("Metres squared: " + newTile.TileSideLength);
            //    Console.WriteLine(newTile);
            //    Console.WriteLine(project.ProjectComplete);
            //    newTile.ThisTileState = TileState.inProgress;
            //    Console.WriteLine("New state of tile: " + newTile.ThisTileState);
            //    newTile.SetTileColour();
            //    Console.WriteLine("New tile colour: " + newTile.TileColour);
            //    project.ProjectTiles.Add(newTile);

            //}




        }
    }



}
