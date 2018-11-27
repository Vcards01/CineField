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
                CreateFilme();
                CreateSala();
                CreateSessao();
                CreateProdutos();
                CreateVendas();
                CreateFuncionario();
                CreateCaixa();


            }
        }
            public void CreateFilme()
        {
            DataBase bd = DataBase.GetInstance();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Filme([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("[Nome] VARCHAR(70),");
            sql.AppendLine("[Genero] VARCHAR(20),");
            sql.AppendLine("[Sinopse] VARCHAR(20),");
            sql.AppendLine("[Duracao] VARCHAR(20),");
            sql.AppendLine("[Quantidade] INTEGER);");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
            bd.ExecuteNonQuery(cmd);
        }
        public void CreateSala()
        {
            DataBase bd = DataBase.GetInstance();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Sala([Codigo] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("[QtdLugares] INTEGER,");
            sql.AppendLine("[Nome] VARCHAR(20));");
            sql.AppendLine("Insert into Sala(QtdLugares,Nome)VALUES(20,'Sala Azul');");
            sql.AppendLine("Insert into Sala(QtdLugares,Nome)VALUES(30,'Sala Verde');");
            sql.AppendLine("Insert into Sala(QtdLugares,Nome)VALUES(40,'Sala Vermelha');");
            sql.AppendLine("Insert into Sala(QtdLugares,Nome)VALUES(50,'Sala Branca');");
            sql.AppendLine("Insert into Sala(QtdLugares,Nome)VALUES(60,'Sala VIP');");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
            bd.ExecuteNonQuery(cmd);
        }
        public void CreateSessao()
        {
           
            DataBase bd = DataBase.GetInstance();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Sessao([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("[Filme] INTEGER,");
            sql.AppendLine("[Sala]  INTEGER,");
            sql.AppendLine("[Horario] VARCHAR(20),");
            sql.AppendLine("[Lugares] INTEGER,");
            sql.AppendLine("[PEntrada] INTEGER);");
            
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
            bd.ExecuteNonQuery(cmd);
        }
        public void CreateProdutos()
        {

            DataBase bd = DataBase.GetInstance();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Produtos([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("[Nome] VARCHAR(30),");
            sql.AppendLine("[Tipo] VARCHAR(20),");
            sql.AppendLine("[Preco] DOUBLE,");
            sql.AppendLine("[Quantidade] DOUBLE);");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
            bd.ExecuteNonQuery(cmd);
        }
        public void CreateVendas()
        {

            DataBase bd = DataBase.GetInstance();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Venda([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("[Valor] INTEGER,");
            sql.AppendLine("[Data] VARCHAR(20),");
            sql.AppendLine("[Hora] VARCHAR(20));");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(20,'24/11/2018','12:00');");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(100,'24/11/2018','13:00');");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(50,'24/11/2018','14:30');");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(120,'24/11/2018','19:00');");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(20,'25/11/2018','10:00');");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(20,'25/11/2018','21:00');");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(20,'25/11/2018','21:30');");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(20,'26/11/2018','20:00');");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(20,'26/11/2018','18:00');");
            sql.AppendLine("Insert into Venda(Valor,Data,Hora)VALUES(20,'26/11/2018','17:00');");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
            bd.ExecuteNonQuery(cmd);
            
        }

        public void CreateFuncionario()
        {
            DataBase bd = DataBase.GetInstance();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Funcionario([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("[Nome] VARCHAR(30),");
            sql.AppendLine("[Cpf] INTEGER,");
            sql.AppendLine("[Idade] INTEGER,");
            sql.AppendLine("[Senha] VARCHAR(30),");
            sql.AppendLine("[Sexo] VARCHAR(20));");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
            bd.ExecuteNonQuery(cmd);
        }
        private void CreateCaixa()
        {
            DataBase bd = DataBase.GetInstance();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Caixa([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("[Data] VARCHAR(30),");
            sql.AppendLine("[Inicial] INTEGER(3,4),");
            sql.AppendLine("[Atual] INTEGER(3,4),");
            sql.AppendLine("[Lucro] INTEGER(3,4));");
            sql.AppendLine("Insert into Caixa(Data,Inicial,Atual,Lucro)VALUES('26/11/2018',10,0,0);");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
            bd.ExecuteNonQuery(cmd);
        }
       

    }
    }

