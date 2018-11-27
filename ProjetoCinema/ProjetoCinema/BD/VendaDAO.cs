using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.BD
{
    class VendaDAO
    {
        public void Create(Venda v)
        {
            DataBase bd = DataBase.GetInstance();
            string sql = string.Format("INSERT INTO Venda(Data,Hora,Valor)VALUES('{0}','{1}',{2});",v.Data,v.Hora, v.Valor1);
            SQLiteCommand cmd = new SQLiteCommand(sql);
            bd.ExecuteNonQuery(cmd);
        }
        public List<Venda> ListAll()
        {
            List<Venda> vendas = new List<Venda>();

            String sql = string.Format("SELECT * FROM Venda");
            SQLiteCommand com = new SQLiteCommand(sql);
            DataSet ds = DataBase.GetInstance().ExecuteQuery(com);
            foreach (DataRow dr in ds.Tables[0].Rows)
               vendas.Add(RowToApp(dr));


            return vendas;
        }
        private Venda RowToApp(DataRow dr)
        {
           Venda v = new Venda();
            v.IdVenda = int.Parse(dr["Id"].ToString());
            v.Valor1 = double.Parse(dr["Valor"].ToString());
            v.Data = dr["Data"].ToString();
            v.Hora =dr["Hora"].ToString();
            return v;
        }
    }
}
