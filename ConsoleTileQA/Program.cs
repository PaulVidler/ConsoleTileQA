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

            //SQLiteConnection sqlite_conn;
            //sqlite_conn =  DBConnector.CreateConnection();

            //List<dynamic> showDb;

            //DBConnector readList;
            //readList = DBConnector.ReadAll("TestProject");

            ConsoleTileQA.JSONParser test = new ConsoleTileQA.JSONParser();

            test.stringParser();

            Console.WriteLine(test.tileSize());
            


        }
    }



}
