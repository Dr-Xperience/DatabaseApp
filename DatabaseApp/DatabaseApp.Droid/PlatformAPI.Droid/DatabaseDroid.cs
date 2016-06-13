using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data;
using Mono.Data;
using System.IO;
using Mono.Data.Sqlite;

namespace PlatformAPI.Droid
{
    class DatabaseDroid : IDatabase
    {                
        SqliteConnection Connection { get; set; }
        string ConnectionString { get; set; }
        public DatabaseDroid() { }

        public void init()
        {
            string pathDir=Application.Context.FilesDir.AbsolutePath;
            var databasePath = Path.Combine(pathDir, "database.sqlite");
            //var pathDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);            
            //var databasePath = Path.Combine(pathDir, "database.sqlite");

            ConnectionString = string.Format("Data Source =" + databasePath);

            using (Connection = new SqliteConnection(ConnectionString))
            {
                Connection.Open();

                string createTable = @"
                CREATE TABLE IF NOT EXISTS[ContactsTable](
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT,
                Address TEXT,
                Phone TEXT,
                Email TEXT,
                URL  TEXT,                  
                Age TEXT,                      
                Description TEXT
                );";

                using (var cmd = new SqliteCommand(createTable, Connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int insert(params string[] value)
        {
            string insertString = @"
                INSERT INTO[ContactsTable](                
                Name, Address, Phone, Email, URL, Age, Description
                )VALUES (
                @Name, @Address, @Phone, @Email, @URL, @Age, @Description
                );";

            using (Connection = new SqliteConnection(ConnectionString))
            {
                Connection.Open();
                using (var cmd = new SqliteCommand(insertString, Connection))
                {
                    cmd.Parameters.AddWithValue("@Name", value[0]);
                    cmd.Parameters.AddWithValue("@Address", value[1]);
                    cmd.Parameters.AddWithValue("@Phone", value[2]);
                    cmd.Parameters.AddWithValue("@Email", value[3]);
                    cmd.Parameters.AddWithValue("@URL", value[4]);
                    cmd.Parameters.AddWithValue("@Age", value[5]);
                    cmd.Parameters.AddWithValue("@Description", value[6]);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}