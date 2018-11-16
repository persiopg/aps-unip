using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace aps.Dominio {
    public class Tela {



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
            Console.WriteLine("digite o estado civil: ");
            string Natural = Console.ReadLine();
            Console.WriteLine("digite o estado civil: ");
            string proced = Console.ReadLine();
            Console.WriteLine("digite o estado civil: ");
            string Profissao = Console.ReadLine();

            Client Newcl = new Client(Name, LastName, Age, Sexy, Civilstade, Natural, proced, Profissao);

            Client.Clientlt.Add(Newcl);

            ArquivoTxt.Save();
        }
        public static void acerssarcadastro(int codigoAcesso) {            
            Console.Clear();
            Console.WriteLine(Client.Clientlt[(codigoAcesso - 1)]);
            
        }
        public static void ShowClients() {
            Console.Clear();

            Client.Clientlt.Sort();
            List<char> preview = new List<char>();
            char opcao = ' ';
            int cont = 0, contAcesso = 0;
            char comparar = ' ';

            for (int i = 0; i < Client.Clientlt.Count; i++) {
                char[] PrimeiraLetra = Client.Clientlt[i].Name.ToCharArray();
                comparar = PrimeiraLetra[0];

                if (i == 0 || opcao != comparar) {
                    opcao = PrimeiraLetra[0];
                    preview.Add(opcao);
                }
                comparar = ' ';
                PrimeiraLetra = null;
            }
            for (int i = 0; i < preview.Count; i++) {
                Console.Write(preview[i] + "(" + i + ") | ");
                if (i % 10 == 0 && i != 0) {
                    Console.WriteLine();
                }
                cont++;
            }
            Console.WriteLine("TODOS(" + cont + ")");

            try {
                int op = int.Parse(Console.ReadLine());
                if (op == cont) {
                    for (int i = 0; i < Client.Clientlt.Count; i++) {
                        Console.WriteLine("(" + (i + 1) + ")");
                        Console.WriteLine(Client.Clientlt[i].preview());
                        if ((i + 1) % 10 == 0 || (i + 1) == Client.Clientlt.Count) {

                            Console.WriteLine("deseja acessar alugum cadastro?(s/n)");
                            opcao = char.Parse(Console.ReadLine());
                            if (opcao == 'S' || opcao == 's') {
                                Console.Write("digite o codigo do cadastro:");
                                contAcesso = int.Parse(Console.ReadLine());
                                acerssarcadastro(contAcesso);
                                 i = Client.Clientlt.Count;
                            }
                            Console.ReadKey();
                        }


                    }
                }
                else {
                    cont = 0;
                    for (int i = 0; i < Client.Clientlt.Count; i++) {

                        char[] PrimeiraLetra = Client.Clientlt[i].Name.ToCharArray();
                        comparar = PrimeiraLetra[0];
                        if (preview[op] == comparar) {
                            cont++;
                            Console.WriteLine("(" + (i + 1) + ")");
                            Console.WriteLine(Client.Clientlt[i].preview());

                        }
                        if ((cont + 1) % 10 == 0 || (i + 1) == Client.Clientlt.Count) {

                            Console.WriteLine("deseja acessar alugum cadastro?(s/n)");
                            opcao = char.Parse(Console.ReadLine());
                            if (opcao == 'S' || opcao == 's') {
                                Console.Write("digite o codigo do cadastro:");
                                contAcesso = int.Parse(Console.ReadLine());
                                acerssarcadastro(contAcesso);
                                i = Client.Clientlt.Count;
                            }
                            Console.ReadKey();
                        }
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine("ERRO Nº1\n" + e.Message);
            }


        }
        public static void alterar(int op)//
        {     
            try {
                op -= 1;
                Console.WriteLine(Client.Clientlt[op]);
                Console.WriteLine("Digite a op q deseja alterar");
                Console.WriteLine("(0)Todo|(1)nome|(2)sobrenome|(3)Idade|(4)Estado civil|(5)Profissao");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 0:
                        string name, lastname, age, sex, stagecivil , nat, proce, profi;

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
                        Console.Write("Naturalidade: ");
                        nat = Console.ReadLine();
                        Console.Write("Procedencia: ");
                        proce = Console.ReadLine();
                        Console.Write("Profissao: ");
                        profi = Console.ReadLine();


                        Client.Clientlt[op] = new Client(name, lastname, age, sex, stagecivil, nat, proce, profi);

                        Console.WriteLine("CONFIRMAR(s/n)\n");
                        Console.WriteLine(Client.Clientlt[op]);
                        char confirmacao = char.Parse(Console.ReadLine());

                        if (confirmacao == 's' || confirmacao == 'S') {
                            ArquivoTxt.Save();
                        }
                        else {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }




                        break;
                    case 1://alterar nome
                        string name_Alt;

                        Console.Write("Nome: ");
                        name_Alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(name_Alt, Client.Clientlt[op].LastName, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Client.Clientlt[op].Profissao);


                        Console.Clear();
                        Console.WriteLine("CONFIRMAR(s/n)\n");
                        Console.WriteLine(Client.Clientlt[op]);
                        char confirmacao_nome = char.Parse(Console.ReadLine());

                        if (confirmacao_nome == 's' || confirmacao_nome == 'S') {
                            ArquivoTxt.Save();
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }
                        else {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }

                        break;
                    case 2://alterar sobrenome
                        string Sobrenome_Alt;

                        Console.Write("Sobrenome: ");
                        Sobrenome_Alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Sobrenome_Alt, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Client.Clientlt[op].Profissao);


                        Console.Clear();
                        Console.WriteLine("CONFIRMAR(s/n)\n");
                        Console.WriteLine(Client.Clientlt[op]);
                        char confirmacao_Sobrenome = char.Parse(Console.ReadLine());

                        if (confirmacao_Sobrenome == 's' || confirmacao_Sobrenome == 'S') {
                            ArquivoTxt.Save();
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }
                        else {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }

                        break;
                    case 3://alterar idade
                        string idade_Alt;

                        Console.Write("idade: ");
                        idade_Alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Client.Clientlt[op].LastName, idade_Alt, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Client.Clientlt[op].Profissao);

                        Console.Clear();
                        Console.WriteLine("CONFIRMAR(s/n)\n");
                        Console.WriteLine(Client.Clientlt[op]);
                        char confirmacao_idade = char.Parse(Console.ReadLine());

                        if (confirmacao_idade == 's' || confirmacao_idade == 'S') {
                            ArquivoTxt.Save();
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }
                        else {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }

                        break;
                    case 4:
                        string EstCiv_alt;

                        Console.Write("Estado Civil: ");
                        EstCiv_alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Client.Clientlt[op].LastName, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, EstCiv_alt, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Client.Clientlt[op].Profissao);

                        Console.Clear();
                        Console.WriteLine("CONFIRMAR(s/n)\n");
                        Console.WriteLine(Client.Clientlt[op]);
                        char confirmacao_EstCiv = char.Parse(Console.ReadLine());

                        if (confirmacao_EstCiv == 's' || confirmacao_EstCiv == 'S') {
                            ArquivoTxt.Save();
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }
                        else {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }

                        break;
                    case 5:
                        string Profissao_Alt;
                        Console.Write("Profissao: ");
                        Profissao_Alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Client.Clientlt[op].LastName, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Profissao_Alt);


                        char confirmacao_ProfAlt = char.Parse(Console.ReadLine());

                        if (confirmacao_ProfAlt == 's' || confirmacao_ProfAlt == 'S') {
                            ArquivoTxt.Save();
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }
                        else {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }

                        break;
                }

            }
            catch (Exception e) {
                Console.WriteLine("ERRO Nº2\n" + e.Message);
            }



        }
    }
}

