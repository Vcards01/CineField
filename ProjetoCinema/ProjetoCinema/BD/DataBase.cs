using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace ProjetoCinema
{
    class DataBase
    {
        private static SQLiteConnection connection;
        private static DataBase instance;
        
        private const string dbName = "database.db";

        private DataBase()
        {
            connection = new SQLiteConnection("Data Source=" + dbName);
        }

        public static DataBase GetInstance()
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }
               
        public void ExecuteNonQuery(SQLiteCommand cmd)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataSet ExecuteQuery(SQLiteCommand cmd)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            cmd.Connection = connection;
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);

            connection.Close();
            return ds;
        }
    }
}

