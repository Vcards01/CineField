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
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao,Quantidade)VALUES('Rei Leão','Desenho de longa metragem','Simba e seus amigos embarcam em grandes aventuras pela savana.','1:30',10);");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao,Quantidade)VALUES('Velozes e Furiosos 3','Ação','Sean Boswell é um piloto de rua que desafia seu rival e bate o carro no fim da corrida. Então, Sean decide se mudar para o Japão em companhia de seu pai para evitar a prisão nos Estados Unidos, já que os rachas não são nada populares com as autoridades','2:05',30);");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao,Quantidade)VALUES('Senhor dos anéis 2: O Retorno do rei','Aventura','Aragorn, Légolas, e Gimli tentam evitar o ataque a Gondor... Enquanto o Frodo continua sendo inútil','2:55',1);");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao,Quantidade)VALUES('O Grito','Terror','Uma enfermeira americana que mora e trabalha em Tóquio é exposta a uma maldição misteriosa em que um espírito se apodera da pessoa, desencadeando um violento surto de raiva, antes de clamar sua vida e passar à próxima vítima.','2:02',40);");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao,Quantidade)VALUES('Homens de Preto','Ação','Kay e Jay se unem para proporcionar uma melhor linha de defesa contra uma sedutora e desafiadora missão para os MIB: proteger a Terra. Enquanto investigam um crime, Jay descobre um enredo arquitetado por Serleena, uma Kylothian monstro que se disfarça como uma modelo terráquea.','2:10',15);");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao,Quantidade)VALUES('Vingadores: Guerra Infinita','Ação','Homem de Ferro, Thor, Hulk e os Vingadores se unem para combater seu inimigo mais poderoso, o maligno Thanos. Em uma missão para coletar todas as seis pedras infinitas, Thanos planeja usá-las para infligir sua vontade maléfica sobre a realidade.','2:20',23);");
            sql.AppendLine("Insert into Filme(Nome,Genero,Sinopse,Duracao,Quantidade)VALUES('Mulan','Desenho de longa metragem','Temendo que seu pai adoentado seja convocado para servir o exército chinês, Mulan (Ming-Na Wen) se disfarça de homem e treina com os colegas. Acompanhada de seu dragão Mushu (Eddie Murphy), ela usa sua inteligência para ajudar a combater a invasão Hun e se apaixona por um charmoso capitão.','2:20',10);");
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
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(1,1,'12:00',20,1000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(2,1,'15:00',20,1000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(3,3,'12:00',40,1500);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(4,4,'22:00',50,1000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(5,5,'15:00',60,2000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(6,2,'21:00',30,1500);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(7,5,'12:00',60,2000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(1,2,'12:00',30,1000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(2,4,'12:00',50,1000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(4,1,'21:00',20,1000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(4,3,'20:00',40,1500);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(4,2,'18:00',30,1000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(5,5,'16:00',60,2000);");
            sql.AppendLine("Insert into Sessao(Filme,Sala,Horario,Lugares,Pentrada)VALUES(7,2,'17:00',30,1000);");
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
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco,Quantidade)VALUES('Coca-Cola','Refrigerante',600,5);");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco,Quantidade)VALUES('Fanta Laranja','Refrigerante',600,6);");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco,Quantidade)VALUES('Fanta Uva','Refrigerante',600,3);");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco,Quantidade)VALUES('Pipoca Doce','Pipoca',500,8);");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco,Quantidade)VALUES('Pipoca Salgada','Pipoca',500,5);");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco,Quantidade)VALUES('Suflair','Chocolate',400,8);");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco,Quantidade)VALUES('Kit-Kat','Chocolate',400,9);");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco,Quantidade)VALUES('7belo','Bala',10,3);");
            sql.AppendLine("Insert into Produtos(Nome,Tipo,Preco,Quantidade)VALUES('Halls','Bala',100,5);");
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

