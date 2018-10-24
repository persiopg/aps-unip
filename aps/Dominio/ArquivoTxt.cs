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
						Sv.WriteLine(Client.Clientlt[i].salvarCadsatroTxt());
					}

				}	

                File.Delete(local);
                FileInfo name = new FileInfo(local1);
                name.MoveTo(local);
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
						/*for (int i = 0; i < 5; i++)
						{
							Console.WriteLine(Clients[i]);
						}

						Clients = null;*/
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
