using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace ConsoleTileQA.DBConnection
{
    class DBConnector
    {

        static SQLiteConnection CreateConnection()
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
              
            }
            return sqlite_conn;
        }


    }
}
