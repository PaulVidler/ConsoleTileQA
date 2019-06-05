using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using Dapper;
using TileQA;

namespace ConsoleTileQA.DBConnection
{
    class DBConnector
    {

        public static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection(@"Data Source=C:\Users\User\source\repos\ConsoleTileQA\ConsoleTileQA\DBConnection\tileDB.db");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sqlite_conn;
        }

        // returns list of all tiles in project according to "jobName" passed into method
        public List<dynamic> ReadAll(string jobName)
        {
            using (SQLiteConnection sqlite_conn = new SQLiteConnection(CreateConnection()))
            {
                return sqlite_conn.Query($"SELECT * FROM tiles WHERE projectName = {jobName}").ToList();
            }
        }



        // reads text file and creates tile objects and adds to DB
        public static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            var lines = File.ReadLines(@"C:\Users\User\Desktop\tile.txt");

            TcProject project = new TcProject();

            foreach (var line in lines)
            {
                TcTile newTile = new TcTile();
                newTile.TileName = line;
                project.ProjectName = "TestProject";

                sqlite_cmd.CommandText = "INSERT INTO tiles (ID, tileColour, projectName, thisTileState, tileSideLength, tileName, checkedBy)" +
                    $"VALUES( null, '{newTile.TileColour}', '{project.ProjectName}', '{newTile.ThisTileState}', '{newTile.TileSideLength}', '{newTile.TileName}', null)";

                // test query - working
                //sqlite_cmd.CommandText = "INSERT INTO tiles (ID, tileColour, projectName, thisTileState, tileSideLength, tileName, checkedBy)" +
                //    "VALUES( null, 'tileColour', 'projectName','theTILESTATE', 'thisTileLENGTH', 'tileNAME', 'CheckedBY')";


                sqlite_cmd.ExecuteNonQuery();

            }
            
        }
        
    }
    
}
