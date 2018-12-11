using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.BD
{
    class SessaoDAO
    {
            public void Create(Sessão s)
            {
                DataBase bd = DataBase.GetInstance();
                string sql = string.Format("Insert into Sessao(Filme,Sala,Horario,Lugares,PEntrada,Qingresso)VALUES('{0}','{1}','{2}',{3},{4},{5});", s.Filme.Id, s.Sala.Id, s.Horario ,s.LugaresDisponiveis,s.PrecoEntrada,0);
                SQLiteCommand cmd = new SQLiteCommand(sql);
                bd.ExecuteNonQuery(cmd);
            }
            public Sessão Read(int id)
            {
                DataBase bd = DataBase.GetInstance();
                string sql = string.Format("SELECT * FROM Sessao WHERE Id={0};", id);
                SQLiteCommand cmd = new SQLiteCommand(sql);
                DataSet ds = bd.ExecuteQuery(cmd);
                DataRow dr = ds.Tables[0].Rows[0];
                Sessão s = RowToApp(dr);
                return s;
            }
            public void Update(Sessão s)
            {
                DataBase bd = DataBase.GetInstance();
                string sql = string.Format("UPDATE Sessao set Filme ={0},Sala={1},Horario='{2}',Lugares={3},PEntrada={4} where Id={5} ;", s.Filme.Id,s.Sala.Id,s.Horario.ToString(), s.LugaresDisponiveis, s.PrecoEntrada,s.Id);
                SQLiteCommand cmd = new SQLiteCommand(sql);
                bd.ExecuteNonQuery(cmd);
            }
            public void Delete(int id)
            {
                DataBase bd = DataBase.GetInstance();
                string sql = string.Format("Delete from Sessao where Id={0};", id);
                SQLiteCommand cmd = new SQLiteCommand(sql);
                bd.ExecuteNonQuery(cmd);
            }
            public List<Sessão> ListAll()
            {
                List<Sessão> sessoes = new List<Sessão>();

                String sql = string.Format("SELECT * FROM Sessao;");
                SQLiteCommand com = new SQLiteCommand(sql);
                DataSet ds = DataBase.GetInstance().ExecuteQuery(com);
                foreach (DataRow dr in ds.Tables[0].Rows)
                   sessoes.Add(RowToApp(dr));


                return sessoes;
            }
            public List<Sessão> FindByFilme(int id)
            {
                List<Sessão> s = new List<Sessão>();
                DataBase bd = DataBase.GetInstance();
                string sql = string.Format("SELECT * FROM Sessao WHERE Filme={0};", id);
                SQLiteCommand cmd = new SQLiteCommand(sql);
                DataSet ds = DataBase.GetInstance().ExecuteQuery(cmd);
                foreach (DataRow dr in ds.Tables[0].Rows)
                s.Add(RowToApp(dr));

                return s;
            }
        public List<Sessão> FindBySala(int id)
        {
            List<Sessão> s = new List<Sessão>();
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Sessao WHERE Sala={0};", id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = DataBase.GetInstance().ExecuteQuery(cmd);
            foreach (DataRow dr in ds.Tables[0].Rows)
                s.Add(RowToApp(dr));

            return s;
        }
        public void updateQI(Sessão s)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("UPDATE Sessao set QIngresso ='{0}' where Id='{1}' ;",s.IngressosVendidos1, s.Id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }

        public Sessão RowToApp(DataRow dr)
            {
                FilmeDAO DAOf = new FilmeDAO();
                SalaDAO DAOs = new SalaDAO();
                Sessão s = new Sessão();
                s.Id = int.Parse(dr["Id"].ToString());
                s.Filme = DAOf.Read(int.Parse(dr["Filme"].ToString()));
                s.Sala = DAOs.Read(int.Parse(dr["Sala"].ToString()));
                s.Horario = dr["Horario"].ToString();
                s.LugaresDisponiveis=(int.Parse(dr["Lugares"].ToString()));
                s.PrecoEntrada = (float.Parse(dr["PEntrada"].ToString()));
                s.IngressosVendidos1 = (int.Parse(dr["QIngresso"].ToString()));
                
                
                return s;
            }
        }
    }
