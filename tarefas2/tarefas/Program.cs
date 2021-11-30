using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace tarefas
{
    class Program
    {
        //public MySqlConnection conexao;

        static void Main(string[] args)
        {
            /*MySqlConnection conexao;

            conexao = new MySqlConnection("server=localhost;database=tarefas;uid=root");
            try
            {

                conexao.Open();
            } catch(Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Nao foi possivel conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }*/
            //MySqlCommand cmd;

            string[] vet = new string[50];

            string opcao;
           

            cadastro cadastro = new cadastro();
            anotacoes anotacoes = new anotacoes();

            
            menu menu = new menu();
           
            do
            {     
                opcao = menu.Menu();
                switch (opcao)
                {
                    case "1":
                       
                        Console.WriteLine("Adicionar tarefa");
                        cadastro.cad();
                        
                        break;
                    case "2":
                        Console.WriteLine("Checar tarefas");
                        
                        cadastro.chec();


                        Console.ReadKey();

                        break;
                    case "3":
                        Console.WriteLine("Concluir tarefa");
                       
                        cadastro.conc();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Alterar tarefa");
                        cadastro.alt();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Descrever tarefa");
                        cadastro.desc();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Descrever tarefa");
                        anotacoes.ano();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Descrever tarefa");
                        anotacoes.checaano();
                        Console.ReadKey();
                        break;
                    case "Q":
                        Console.WriteLine("Encerrando o programa");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != "Q");
          
        }
    }
}
