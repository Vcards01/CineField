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
        private int flag;

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
            sql.AppendLine("[Duracao] VARCHAR(20));");
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
            sql.AppendLine("[PInteira] INTEGER,");
            sql.AppendLine("[PMeia] INTEGER);");
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
            sql.AppendLine("[Preco] DOUBLE);");
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
           
        public void addInformation()
        { 
            if (flag != 1)
            {
            DataBase bd = DataBase.GetInstance();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao)VALUES('Rei Leão','Desenho de longa metragem','Simba e seus amigos embarcam em grandes aventuras pela savana.','1:30');");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao)VALUES('Velozes e Furiosos 3','Ação','Tokyo Drift, será que aquele cara vai conseguir se tornar um Drift King?.','2:05');");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao)VALUES('Senhor dos anéis 2: O Retorno do rei','Aventura','Aragorn, Légolas, e Gimli tentam evitar o ataque a Gondor.','2:55');");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao)VALUES('O Grito','Terror','Não gosto de filme de terror.','2:02');");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao)VALUES('Homens de Preto','Ação','Caçadores de Alienígenas de uma associoação secreta.','2:10');");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao)VALUES('Vingadores: Guerra Infinita','Ação','Thanos quer recuperar as pedras do infinito... e coisas do tipo','2:20');");

            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco)VALUES('Coca','refri', '2.00');");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco)VALUES('Pepsi','refri','2.00');");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco)VALUES('Bala de goma', 'doce', '3.50');");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco)VALUES('pipoca', 'pipoca', '5.00');");
            //sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco)VALUES('');");
            //sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco)VALUES('');");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
            bd.ExecuteNonQuery(cmd);
            flag = 1;
            }
        }
    }
}

