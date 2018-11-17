using System;
using System.Collections.Generic;

namespace aps.Dominio {
    public class Tela {



        public static void NewClient()//novo client
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
            Console.WriteLine("digite o naturalidade: ");
            string Natural = Console.ReadLine();
            Console.WriteLine("digite o procedencia: ");
            string proced = Console.ReadLine();
            Console.WriteLine("digite o proficao: ");
            string Profissao = Console.ReadLine();
            Console.Clear();
            Console.Write("\n\nENDERECO\n\n");
            Console.WriteLine("digite o endereço: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("digite o cep: ");
            string cep = Console.ReadLine();
            Console.WriteLine("digite o estado: ");
            string estado = Console.ReadLine();


            Client Newcl = new Client(Name, LastName, Age, Sexy, Civilstade, Natural, proced, Profissao, endereco, cep, estado);

            Client.Clientlt.Add(Newcl);

            ArquivoTxt.Save();
        }
        public static void acerssarcadastro(int codigoAcesso) {//ACessa o client
            Console.Clear();
            Console.WriteLine(Client.Clientlt[(codigoAcesso - 1)]);
            
        }
        public static void excluir(int codigoAcesso) {//exclui o client
            Console.Clear();
            Console.WriteLine(Client.Clientlt[(codigoAcesso - 1)]);
            Console.Write("deseja excluir?(S|N)");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's'||resposta == 'S') {
                Client.Clientlt.Remove(Client.Clientlt[(codigoAcesso - 1)]);
                ArquivoTxt.Save();
            }
        }
        public static void ShowClients() {//mostra o client
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
                                Console.WriteLine("\ndeseja alterar Cadastro? (S|N)");
                                char Resposta = char.Parse(Console.ReadLine());
                                if (Resposta == 's' || Resposta == 'S') {
                                    Console.Clear();
                                    alterar(contAcesso);
                                }
                                 i = Client.Clientlt.Count;
                            }
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
                                Console.WriteLine("\n(0)ALTERAR|(1)EXCLUIR|(5)MENU");
                                char Resposta = char.Parse(Console.ReadLine());
                                if (Resposta == '0' ) {
                                    Console.Clear();
                                    alterar(contAcesso);
                                }
                                else if(Resposta == '1') {
                                    Console.Clear();
                                    excluir(contAcesso);

                                }
                                i = Client.Clientlt.Count;
                            }
                        }
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine("ERRO Nº1\n" + e.Message);
            }


        }
        public static void alterar(int op)//ALTERA CADASTRO
        {     
            try {
                op -= 1;
                Console.WriteLine(Client.Clientlt[op]);
                Console.WriteLine("Digite a op q deseja alterar");
                Console.WriteLine("(0)Todo|(1)nome|(2)sobrenome|(3)Idade|(4)Estado civil|(5)Profissao|(6)Endereco");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 0:
                        string name, lastname, age, sex, stagecivil , nat, proce, profi, end, cep, est;

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
                        Console.Clear();
                        Console.Write("\n\nENDERECO\n\n");
                        Console.Write("Endereço: ");
                        end = Console.ReadLine();
                        Console.Write("Cep: ");
                        cep = Console.ReadLine();
                        Console.Write("Estado: ");
                        est = Console.ReadLine();

                        Client.Clientlt[op] = new Client(name, lastname, age, sex, stagecivil, nat, proce, profi, end, cep, est);

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

                        Client.Clientlt[op] = new Client(name_Alt, Client.Clientlt[op].LastName, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Client.Clientlt[op].Profissao, Client.Clientlt[op].endereco, Client.Clientlt[op].cep, Client.Clientlt[op].estado);


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

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Sobrenome_Alt, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Client.Clientlt[op].Profissao, Client.Clientlt[op].endereco, Client.Clientlt[op].cep, Client.Clientlt[op].estado);


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

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Client.Clientlt[op].LastName, idade_Alt, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Client.Clientlt[op].Profissao, Client.Clientlt[op].endereco, Client.Clientlt[op].cep, Client.Clientlt[op].estado);

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
                    case 4://ALTERA ESTADO CIVIL
                        string EstCiv_alt;

                        Console.Write("Estado Civil: ");
                        EstCiv_alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Client.Clientlt[op].LastName, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, EstCiv_alt, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Client.Clientlt[op].Profissao, Client.Clientlt[op].endereco, Client.Clientlt[op].cep, Client.Clientlt[op].estado);

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
                    case 5://ALTERA PROFISSAO
                        string Profissao_Alt;
                        Console.Write("Profissao: ");
                        Profissao_Alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Client.Clientlt[op].LastName, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Profissao_Alt, Client.Clientlt[op].endereco, Client.Clientlt[op].cep, Client.Clientlt[op].estado);


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
                    case 6://ALTERA ENDERECO
                        string end_Alt, cep_alt, est_Alt;

                        Console.Write("Endereço: ");
                        end_Alt = Console.ReadLine();
                        Console.Write("Cep: ");
                        cep_alt = Console.ReadLine();
                        Console.Write("Estado: ");
                        est_Alt = Console.ReadLine();

                        Client.Clientlt[op] = new Client(Client.Clientlt[op].Name, Client.Clientlt[op].LastName, Client.Clientlt[op].Idade, Client.Clientlt[op].Sexo, Client.Clientlt[op].EstadoCivil, Client.Clientlt[op].Naturalidade, Client.Clientlt[op].Procedencia, Client.Clientlt[op].Profissao, end_Alt, cep_alt, est_Alt);

                        char confirmacao_endAlt = char.Parse(Console.ReadLine());

                        if (confirmacao_endAlt == 's' || confirmacao_endAlt == 'S') {
                            ArquivoTxt.Save();
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }
                        else {
                            Client.Clientlt.Clear();
                            ArquivoTxt.Read();
                        }

                        break;
                    default:
                        break;
                }
            }
            catch (Exception e) {
                Console.WriteLine("ERRO Nº2\n" + e.Message);
            }
        }
    }
}

