using System;
using System.IO;
using System.Collections.Generic;
namespace aps.Dominio
{
    public class ArquivoTxt
    {

		private static string local = "C:\\Users\\user\\Desktop\\aps-unip mono\\aps-unip\\test.txt";
		private static string local1 = "C:\\Users\\user\\Desktop\\aps-unip mono\\aps-unip\\test1.txt";

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
                Console.WriteLine("ERRO Nº3\n" + e.Message);
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
                Console.WriteLine("ERRO Nº4\n" + e.Message);
            } 
		}
		
    }
}
