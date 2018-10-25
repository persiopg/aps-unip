using System;
using System.IO;
using System.Collections.Generic;
namespace aps.Dominio
{
    public class ArquivoTxt
    {

		private static string local = "/home/persio/Área de Trabalho/eu";
		private static string local1 = "/home/persio/Área de Trabalho/eu1";

		public static void Save(){
			try{
				using (StreamWriter Sv = File.AppendText(local1))
				{
					Client.Clientlt.Sort();
					for (int i = 0; i < Client.Clientlt.Count; i++)
					{
						Sv.WriteLine(Client.Clientlt[i].salvarCadsatroTxt().ToUpper());
					}

				}	

                File.Delete(local);
                FileInfo name = new FileInfo(local1);
                name.MoveTo(local);
				Client.Clientlt.Clear();
				Read();
			}
			catch(IOException e){
                Console.WriteLine("erro na leitura do arquivo");
                Console.WriteLine(e.Message);
            } 
            
		}
		public static void Read(){
			try{
				using(StreamReader Read = File.OpenText(local)){
					while(!Read.EndOfStream){

                        
						string line = Read.ReadLine();
						line.TrimEnd();
						string[] Clients = line.Split('.');

						Client TempCl = new Client(Clients[0], Clients[1], Clients[2], Clients[3], Clients[4]);

						Client.Clientlt.Add(TempCl);
					}
				}
			}
			catch(IOException e){
                Console.WriteLine("erro na leitura do arquivo");
                Console.WriteLine(e.Message);
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
				switch(opcao){
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

						if (confirmacao == 's')
						{
							Save();
						}
						else
						{
							Client.Clientlt.Clear();
							Read();
						}

                        


						break;
					case 1:
                        
                        break;
					case 2:

                        break;
					case 3:

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
