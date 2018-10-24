using System;
using System.IO;
using System.Collections.Generic;
namespace aps.Dominio
{
    public class ArquivoTxt
    {

		private static string local = "/home/persio/Área de Trabalho/eu";

		public static void Save(Client Cl){
			try{
				using (StreamWriter Sv = File.AppendText(local))
				{


					if (Client.Clientlt.Count != 0)
					{
						Client.Clientlt.Sort();
						for (int i = 0; i < Client.Clientlt.Count; i++)
						{
							Sv.WriteLine(Client.Clientlt[i].salvarCadsatroTxt());
						}
						Sv.WriteLine(Cl.salvarCadsatroTxt().ToUpper());
					}
					else
					{
						Sv.WriteLine(Cl.salvarCadsatroTxt().ToUpper());
					}
				}			
			}
			catch(IOException e){
                Console.WriteLine("erro na leitura do arquivo");
                Console.WriteLine(e.Message);
            } 
            
		}
		public void Read(){
			try{
				using(StreamReader Read = File.OpenText(local)){
					while(!Read.EndOfStream){
						string line = Read.ReadLine();

							string[] Clients = line.Split('.');

						/*string Name = Clients[0];
						string LastName = Clients[1];
						string Age = Clients[2];
						string Sexy = Clients[3];
						string CivilStade = Clients[4];
                        

						Client TempCl = new Client(Name, LastName, Age, Sexy, CivilStade);

						Client.Clientlt.Add(TempCl);*/
						for (int i = 0; i < 5; i++)
						{
							Console.WriteLine(Clients[i]);
						}

						Clients = null;
					}
				}
			}
			catch(IOException e){
                Console.WriteLine("erro na leitura do arquivo");
                Console.WriteLine(e.Message);
            } 
		}
    }
}
