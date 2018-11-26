using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using ProjetoCinema;

namespace ProjetoCinema.BD
{
    class FilmeDAO
    {
        SessaoDAO DAO = new SessaoDAO();
        public void Create(Filme f)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Insert into Filme(Nome,Genero,Sinopse,Duracao)VALUES('{0}','{1}','{2}','{3}');", f.Nome, f.Genero, f.Sinopse,f.Duracao);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public Filme Read(int id)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Filme WHERE Id={0};", id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = bd.ExecuteQuery(cmd);
            DataRow dr = ds.Tables[0].Rows[0];
            Filme f = RowToApp(dr);
            return f;
        }
        public void Update(Filme f)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("UPDATE Filme set Nome='{0}',Genero='{1}',Sinopse='{2}',Duracao='{3}' where Id={4} ;", f.Nome, f.Genero, f.Sinopse, f.Duracao,f.Id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public void Delete(int id)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Delete from Filme where Id={0};", id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public List<Filme> ListAll()
        {
            List<Filme> filmes = new List<Filme>();

            String sql = string.Format("SELECT * FROM Filme");
            SQLiteCommand com = new SQLiteCommand(sql);
            DataSet ds = DataBase.GetInstance().ExecuteQuery(com);
            foreach (DataRow dr in ds.Tables[0].Rows)
                filmes.Add(RowToApp(dr));


            return filmes;
        }
        private Filme RowToApp(DataRow dr)
        {
            Filme f = new Filme();
            f.Id = int.Parse(dr["Id"].ToString());
            f.Nome = dr["Nome"].ToString();
            f.Sinopse = dr["Sinopse"].ToString();
            f.Genero = dr["Genero"].ToString();
            f.Duracao = dr["Duracao"].ToString();
            return f;
        }
        public Filme FindByName(string nome)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Filme WHERE Nome = '{0}';", nome);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = bd.ExecuteQuery(cmd);
            DataRow dr = ds.Tables[0].Rows[0];
            Filme f = RowToApp(dr);
            return f;
        }
    }
}
