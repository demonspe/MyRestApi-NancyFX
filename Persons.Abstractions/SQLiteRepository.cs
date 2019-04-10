using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Abstractions
{
    public class SQLiteRepository
    {
        private static SQLiteConnection _dbConnection;
        static SQLiteConnection OpenDb()
        {
            var dbFilePath = "./TPersonsDb.sqlite";
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }
            _dbConnection = new SQLiteConnection(string.Format(
                "Data Source={0};Version=3;", dbFilePath));
            _dbConnection.Open();

            return _dbConnection;
        }

        static void CloseDb()
        {
            _dbConnection?.Close();
        }

        static void SeedDatabase()
        {
            // Create a Persons table
            _dbConnection.Execute(@"
            CREATE TABLE IF NOT EXISTS [Persons] (
                [Id] BLOB PRIMARY KEY,
                [Name] NVARCHAR(64) NOT NULL,
                [BirthDay] TIMESTAMP 
            )");
        }
    }
}
