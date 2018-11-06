using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace aps.Dominio
{
    public class Tela
    {
        


        public static void NewClient()//
        {
            Console.Clear();
            Console.WriteLine("digite o nome: ");
            string Name = Console.ReadLine();
            Console.WriteLine("digite o sobrenome: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("digite o idade: ");
            string Age = Console.ReadLine();
            Console.WriteLine("digite o sexo: ");
            string Sexy = Console.ReadLine();
            Console.WriteLine("digite o estado civil: ");
            string Civilstade = Console.ReadLine();

            Client Newcl = new Client(Name, LastName, Age, Sexy, Civilstade);

            Client.Clientlt.Add(Newcl);

            ArquivoTxt.Save();
        }
        public static void ShowClients(){
            Console.Clear();
            Client.Clientlt.Sort();
            List<char> preview = new List<char>();
            char opcao = ' ';
            int cont = 0;
            char comparar = ' ';

            for (int i = 0; i < Client.Clientlt.Count;i++){
                char[] PrimeiraLetra = Client.Clientlt[i].Name.ToCharArray();
                comparar = PrimeiraLetra[0];

                if (i == 0 || opcao != comparar){
                    opcao = PrimeiraLetra[0];
                    preview.Add(opcao);
                }
                comparar = ' ';
                PrimeiraLetra = null;
            }
            for (int i = 0; i < preview.Count;i++){
                Console.Write(preview[i] + "(" + i + ") | ");
                if(i%10 == 0 && i != 0){
                    Console.WriteLine();
                }
                cont++;
            }
            Console.WriteLine("TODOS(" + cont + ")");

            try
            {
                int op = int.Parse(Console.ReadLine());
                if (op == cont)
                {
                    for (int i = 0; i < Client.Clientlt.Count; i++)
                    {
                        Console.WriteLine(Client.Clientlt[i].preview());
                    }
                }
                else
                {
                    cont = 0;
                    for (int i = 0; i < Client.Clientlt.Count; i++)
                    {

                        char[] PrimeiraLetra = Client.Clientlt[i].Name.ToCharArray();
                        comparar = PrimeiraLetra[0];
                        if (preview[op] == comparar)
                        {
                            cont++;
                            Console.WriteLine("(" + (cont) + ")");
                            Console.WriteLine(Client.Clientlt[i]);
                            if (cont == 10)
                            {
                                Console.ReadKey();

                            }
                        }
                    }
                }
            }catch(Exception e){
                Console.WriteLine("ERRO Nº\n" + e.Message);
            }


        }
        public static void alterar()//
        {
            for (int i = 0; i < Client.Clientlt.Count; i++)
            {

                Console.WriteLine("(" + (i + 1) + ")");
                Console.WriteLine(Client.Clientlt[i]);
            }

            try
            {
                Console.Write("Digite o codigo do cadastro: ");
                int op = int.Parse(Console.ReadLine());
                op -= 1;
                Console.WriteLine(Client.Clientlt[op]);
                Console.WriteLine("Digite a op q deseja alterar");
                Console.WriteLine("(0)Todo|(1)nome|(2)sobrenome|(3)Idade|(4)Sexo|(5)Estado civil");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        string name, lastname, age, sex, stagecivil;

                        Console.Write("Nome: ");
                        name = Console.ReadLine();
                        Console.Write("Sobrenome: ");
                        lastname = Console.ReadLine();
                        Console.Write("Idade: ");
                        age = Console.ReadLine();
                        Console.Write("Sexo: ");
                        sex = Console.ReadLine();
                        Console.Write("estado civil: ");
                        stagecivil = Console.ReadLine();

                        Client.Clientlt[op] = new Client(name, lastname, age, sex, stagecivil);

                        Console.WriteLine("confirmar(s/n)");
                        Console.WriteLine(Client.Clientlt[op]);
                        char confirmacao = char.Parse(Console.ReadLine());

                        if (confirmacao == 's' || confirmacao == 'S')
                        {
                            ArquivoTxt.Save();
                        }
                        else
                        {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }




                        break;
                    case 1://alterar nome
                        string name_Alt;

                        Console.Write("Nome: ");
                        name_Alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(name_Alt, Client.Clientlt[op].LastName, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil);


                        Console.WriteLine("confirmar(s/n)");
                        Console.WriteLine(Client.Clientlt[op]);
                        char confirmacao_nome = char.Parse(Console.ReadLine());

                        if (confirmacao_nome == 's' || confirmacao_nome == 'S')
                        {
                            ArquivoTxt.Save();
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }
                        else
                        {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }

                        break;
                    case 2:
                        string Sobrenome_Alt;

                        Console.Write("Sobrenome: ");
                        Sobrenome_Alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Sobrenome_Alt, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil);


                        Console.WriteLine("confirmar(s/n)");
                        Console.WriteLine(Client.Clientlt[op]);
                        char confirmacao_Sobrenome = char.Parse(Console.ReadLine());

                        if (confirmacao_Sobrenome == 's' || confirmacao_Sobrenome == 'S')
                        {
                            ArquivoTxt.Save();
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }
                        else
                        {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }

                        break;
                    case 3:
                        string namealt;

                        Console.Write("Nome: ");
                        namealt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(namealt, Client.Clientlt[op].LastName, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil);


                        Console.WriteLine("confirmar(s/n)");
                        Console.WriteLine(Client.Clientlt[op]);
                        char confir = char.Parse(Console.ReadLine());

                        if (confir == 's' || confir == 'S')
                        {
                            ArquivoTxt.Save();
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }
                        else
                        {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}

