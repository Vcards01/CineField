using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.BD
{
    class Tables
    {
        public void CreateTable()
        {
            if (!File.Exists("database"))
            {
                DataBase bd = DataBase.GetInstance();
                SQLiteConnection.CreateFile("database");
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS Filme([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[Nome] VARCHAR(70),");
                sql.AppendLine("[Genero] VARCHAR(20),");
                sql.AppendLine("[Sinopse] VARCHAR(20),");
                sql.AppendLine("[Duracao] VARCHAR(20));");
                sql.AppendLine("CREATE TABLE IF NOT EXISTS Sala([Codigo] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[QtdLugares] INTEGER);");
                SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
                bd.ExecuteNonQuery(cmd);
                


            }
        }
    }
}
