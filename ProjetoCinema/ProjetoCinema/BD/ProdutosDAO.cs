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
    class ProdutosDAO
    {         
        public void Create(Produtos p)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Insert into Produtos(Nome,Tipo,Preco)VALUES('{0}','{1}','{2}');", p.Nome, p.Tipo, p.Preco);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public Produtos Read(int id)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Produtos WHERE Id={0};", id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = bd.ExecuteQuery(cmd);
            DataRow dr = ds.Tables[0].Rows[0];
            Produtos p = RowToApp(dr);
            return p;
        }
        public void Update(Produtos p)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("UPDATE Produtos set Nome ='{0}',Tipo='{1}',Preco='{2}' where Id='{3}' ;",p.Nome, p.Tipo,p.Preco,p.Id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public void Delete(int id)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Delete from Produtos where Id='{0}';", id );
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public List<Produtos> ListAll()
        {
            List<Produtos> produtos = new List<Produtos>();

            String sql = string.Format("SELECT * FROM Produtos");
            SQLiteCommand com = new SQLiteCommand(sql);
            DataSet ds = DataBase.GetInstance().ExecuteQuery(com);
            foreach (DataRow dr in ds.Tables[0].Rows)
                produtos.Add(RowToApp(dr));


            return produtos;
        }
        private Produtos RowToApp(DataRow dr)
        {
            Produtos p = new Produtos();
            p.Id = int.Parse(dr["Id"].ToString());
            p.Nome = dr["Nome"].ToString();
            p.Tipo = dr["Tipo"].ToString();
            p.Preco = double.Parse(dr["Preco"].ToString());
            
            return p;
        }
        public Produtos FindByName(string nome)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Produtos WHERE Nome = '{0}';", nome);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = bd.ExecuteQuery(cmd);
            DataRow dr = ds.Tables[0].Rows[0];
            Produtos p = RowToApp(dr);
            return p;
        }
    }
}
