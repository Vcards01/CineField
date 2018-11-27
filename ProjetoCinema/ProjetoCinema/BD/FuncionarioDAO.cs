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
    class FuncionarioDAO
    {
        public void Create(Funcionario f)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Insert into Funcionario(Nome,Cpf,Idade,Senha,Sexo)VALUES('{0}','{1}','{2}','{3}','{4}');", f.Nome, f.Cpf, f.Idade,f.Senha,f.Sexo);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public Funcionario Read(long cpf)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Funcionario WHERE Cpf={0};", cpf);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = bd.ExecuteQuery(cmd);
            DataRow dr = ds.Tables[0].Rows[0];
            Funcionario f = RowToApp(dr);
            return f;
        }
        public void Update(Funcionario f)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("UPDATE Funcionario set Nome ='{0}',Cpf='{1}',Idade='{2}',Senha='{3}', Sexo='{4}' where Cpf='{5}' ;", f.Nome, f.Cpf, f.Idade, f.Senha,f.Sexo,f.Cpf);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public void Delete(long cpf)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Delete from Funcionario where Cpf='{0}';", cpf);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public List<Funcionario> ListAll()
        {
            List<Funcionario> funcionario = new List<Funcionario>();

            String sql = string.Format("SELECT * FROM Funcionario;");
            SQLiteCommand com = new SQLiteCommand(sql);
            DataSet ds = DataBase.GetInstance().ExecuteQuery(com);
            foreach (DataRow dr in ds.Tables[0].Rows)
                funcionario.Add(RowToApp(dr));


            return funcionario;
        }
        private Funcionario RowToApp(DataRow dr)
        {
            Funcionario f = new Funcionario();
            f.Nome = dr["Nome"].ToString();
            f.Cpf = long.Parse(dr["Cpf"].ToString());
            f.Idade = int.Parse(dr["Idade"].ToString());
            f.Senha = dr["Senha"].ToString();
            f.Sexo = dr["Sexo"].ToString();
            return f;
        }
        public Funcionario FindByName(string nome)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Funcionario WHERE Nome = '{0}';", nome);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = bd.ExecuteQuery(cmd);
            DataRow dr = ds.Tables[0].Rows[0];
            Funcionario f = RowToApp(dr);
            return f;
        }
    }
}
