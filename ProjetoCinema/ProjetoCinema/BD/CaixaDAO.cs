using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCinema.Model;
using System.Data;

namespace ProjetoCinema.BD
{
  public  class CaixaDAO
    {
        
        public void Create(Caixa x )
        {
            
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Insert into Caixa(Data,Inicial,Atual,Lucro)VALUES('{0}',{1},{2},{3});", x.Data,x.ValorInicial,x.ValorAtual,x.Lucro);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public Caixa Read(int id)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Sala WHERE id={0};", id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = bd.ExecuteQuery(cmd);
            DataRow dr = ds.Tables[0].Rows[0];
            Caixa x = RowToApp(dr);
            return x;
        }
        public void Update(Caixa x)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("UPDATE Caixa set Data='{0}',Inicial={1},Atual={2},Lucro={3} where Id={4} ;",x.Data,x.ValorInicial,x.ValorAtual,x.Lucro,x.Id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public void Delete(int id)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("Delete from Caixa where Id={0};", id);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public List<Caixa> ListAll()
        {
            List<Caixa> caixas = new List<Caixa>();

            String sql = string.Format("SELECT * FROM Caixa");
            SQLiteCommand com = new SQLiteCommand(sql);
            DataSet ds = DataBase.GetInstance().ExecuteQuery(com);
            foreach (DataRow dr in ds.Tables[0].Rows)
                caixas.Add(RowToApp(dr));


            return caixas;
        }
        public Caixa FindbyDate(string data)
        {
            Caixa x = null;
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("SELECT * FROM Caixa WHERE Data='{0}';", data);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            DataSet ds = bd.ExecuteQuery(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                x = RowToApp(dr);
            }
             return x;
        }
        private Caixa RowToApp(DataRow dr)
        {
            Caixa x = new Caixa();
            x.Id = int.Parse(dr["Id"].ToString());
            x.Data =(dr["Data"].ToString());
            x.ValorInicial = float.Parse(dr["Inicial"].ToString());
            x.ValorAtual = float.Parse(dr["Atual"].ToString());
            x.Lucro = float.Parse(dr["Lucro"].ToString());
            return x;
        }
       
    }
}
