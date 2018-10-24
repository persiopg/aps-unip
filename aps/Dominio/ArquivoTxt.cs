using System;
using System.IO;
using System.Collections.Generic;
namespace aps.Dominio
{
    public class ArquivoTxt
    {

		private static string local = "/home/persio/Área de Trabalho/eu";
        private static string local1 = "/home/persio/Área de Trabalho/eu1";

		public static void Save(Client Cl){
			try{
				using (StreamWriter Sv = File.AppendText(local1))
				{


					if (Client.Clientlt.Count != 0)
					{
						for (int i = 0; i < Client.Clientlt.Count; i++)
						{
							Sv.WriteLine(Client.Clientlt[i].salvarCadsatroTxt());
						}
						Sv.WriteLine(Cl.salvarCadsatroTxt());
					}
					else
					{
						Sv.WriteLine(Cl.salvarCadsatroTxt());
					}
				}			
			}
			catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

		}
    }
}
