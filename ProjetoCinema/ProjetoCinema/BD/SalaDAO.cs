using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.BD
{
    class SalaDAO
    {
        public void Create(Sala s)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Insert into Sala(QtdLugares)VALUES({1});",s.QtddLugares);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public Sala Read(int id)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Sala WHERE Codigo={0};", id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = bd.ExecuteQuery(cmd);
            DataRow dr = ds.Tables[0].Rows[0];
            Sala s = RowToApp(dr);
            return s;
        }
        public void Update(Sala s)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("UPDATE Sala set QtdLugares={0} where Codigo={1} ;",s.QtddLugares,s.Id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public void Delete(int id)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Delete from Sala where Codigo={0};", id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public List<Sala> ListAll()
        {
            List<Sala> salas = new List<Sala>();

            String sql = string.Format("SELECT * FROM Sala");
            SQLiteCommand com = new SQLiteCommand(sql);
            DataSet ds = DataBase.GetInstance().ExecuteQuery(com);
            foreach (DataRow dr in ds.Tables[0].Rows)
                salas.Add(RowToApp(dr));


            return salas;
        }
        private Sala RowToApp(DataRow dr)
        {
            Sala s = new Sala();
            s.Id = int.Parse(dr["Codigo"].ToString());
            s.QtddLugares = int.Parse(dr["QtdLugares"].ToString());
            return s;
        }

    }
}
