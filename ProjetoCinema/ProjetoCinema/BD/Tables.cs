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
            DataBase bd = DataBase.GetInstance();
            //StringBuilder sql = new StringBuilder();
            //string sql = string.Format("Insert into Filme(Nome, Genero, Sinopse, Duracao)VALUES('Rei Leão', 'Desenho de longa metragem', 'Simba e seus amigos procuram vingar a morte de Mufasa', '1:29'");
           // sql.AppendLine("Insert into Filme(Nome, Genero, Sinopse, Duracao)VALUES('Irmão Urso', 'Desenho de longa metragem', 'Kenai é um bravo jovem índio com uma aversão especial por ursos. Quando seu irmão Sitka é morto por um, Kenai mata o urso, mas é magicamente transformado em um deles. Para piorar a situação, seu outro irmão, Denahi, jura matar o urso que Kenai se tornou.', '1:25')");
           // sql.AppendLine("Insert into Filme(Nome, Genero, Sinopse, Duracao)VALUES('Procurando Nemo', 'Desenho de longa metragem', 'Em seu primeiro dia de aula, esquecendo os conselhos do pai superprotetor, Nemo é capturado por um mergulhador e acaba no aquário de um dentista. Enquanto Nemo tenta bolar um plano para escapar, seu pai cruza o oceano para resgatá-lo.', '1:41')");
           // sql.AppendLine("Insert into Filme(Nome, Genero, Sinopse, Duracao)VALUES('Rei Leão', 'Desenho de longa metragem', 'Simba e seus amigos procuram vingar a morte de Mufasa', '1:29')");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString());
            bd.ExecuteNonQuery(cmd);
        }

    }
    }

