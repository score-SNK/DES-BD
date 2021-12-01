using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace tarefas
{
    class anotacoes
    {
        public MySqlConnection conexao;

        string sql;

        public string[] anot = new string[50];
        public string anota;
        public string[] nom = new string[50];
        public string nomm;
        public int u;
        public int b;
        public int op;

        public string ch;


        public void ano()
        {
            MySqlConnection conexao;


            conexao = new MySqlConnection("server=localhost;database=tarefas;uid=root");
            try
            {

                conexao.Open();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Nao foi possivel conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;

            Console.WriteLine("Adicione um titulo para a nota");
            nomm = Console.ReadLine();

            Console.WriteLine("Adicione uma anotoção");
            anota = Console.ReadLine();
            

            anot[u] = anota;
            nom[u] = nomm;

            //sql = "insert into nottarefas values('" + vetorcpf[i] + "','" + vetorcep[i] + "','"+vetor[i]+"')";
            sql = "insert into nota(notad, notat) values(@anota, @nomm)";
            //sql = "insert into nottarefa values(@cpf, @cep, @nome)";
            cmd = new MySqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@anota", anota);
            cmd.Parameters.AddWithValue("@nomm", nomm);

            cmd.ExecuteNonQuery();

            u++;

            Console.WriteLine("Anotoção adicionada");

        }

        public void sele()
        {
            MySqlConnection conexao;

            Console.WriteLine("Escolha a tarefa a ser checada");

            conexao = new MySqlConnection("server=localhost;database=tarefas;uid=root");
            try
            {

                conexao.Open();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Nao foi possivel conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;

            string sqlselect = "select * from nota";
            cmd = new MySqlCommand(sqlselect, conexao);
            //cmd.Parameters.AddWithValue("@i", i);
            cmd.CommandText = sqlselect;
            MySqlDataReader resultado = cmd.ExecuteReader();



            while (resultado.Read())
            {
                Console.WriteLine("   ");
                //Console.WriteLine("id:" + resultado["b"]);
                Console.WriteLine("titulo da nota:" + resultado["notat"]);
                // Console.WriteLine("descriçao da nota:" + resultado["notad"]);

            }

            conexao.Close();
        }

        public void checaano()
        {
           // Console.WriteLine("Escolha o cadastro a ser checado");
            sele();
            ch = Console.ReadLine();
            

            conexao = new MySqlConnection("server=localhost;database=tarefas;uid=root");
            try
            {

                conexao.Open();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Nao foi possivel conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;

            string sqlselect = "select * from nota where notat=@ch";
            cmd = new MySqlCommand(sqlselect, conexao);
            cmd.Parameters.AddWithValue("@ch", ch);
            cmd.CommandText = sqlselect;
            MySqlDataReader resultado = cmd.ExecuteReader();



            while (resultado.Read())
            {
                Console.WriteLine("   ");
                //Console.WriteLine("id:" + resultado["b"]);
                Console.WriteLine("titulo da nota:" + resultado["notat"]);
                Console.WriteLine("descriçao da nota:" + resultado["notad"]);

            }


            /*MySqlCommand cmd;
            cmd = new MySqlCommand(sql, conexao);

            string sqlselect = "select * from nottarefa where i=@opit";
            cmd = new MySqlCommand(sqlselect, conexao);
            cmd.Parameters.AddWithValue("@opit", opit);
            cmd.CommandText = sqlselect;
            MySqlDataReader resultado = cmd.ExecuteReader();



            while (resultado.Read())
            {
                Console.WriteLine("   ");
                Console.WriteLine("id:" + resultado["i"]);
                Console.WriteLine("descriçao da tarefa:" + resultado["tarefad"]);
                //Console.WriteLine("prazo:" + resultado["tarefap"]);
            }*/

            /*Console.WriteLine("Selecione uma anotação para ser acessada:");

            for (int b = 0; b < u; b++)
            {

                Console.WriteLine("Nota: " + b + " // " + nom[b]);

            }

            op = int.Parse(Console.ReadLine());

            if (op >= 0 && op < 50)
            {
      
                
                    Console.WriteLine("Titulo: " + nom[op]);
                    Console.WriteLine("Descrição: " + anot[op]);

                

            }
            else
            {
                Console.WriteLine("entrada invalida");
                Console.ReadLine();
            }*/

        }
    }
}
