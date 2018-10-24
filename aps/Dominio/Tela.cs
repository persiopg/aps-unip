using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace aps.Dominio
{
	public class Tela
	{
		ArquivoTxt tt = new ArquivoTxt();
		public static void NewClient()
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

			aps.Dominio.ArquivoTxt.Save(Newcl);
		}
		public static void ShowClients(){
			Console.Clear();
			for (int i = 0;i < Client.Clientlt.Count;i++){
				Console.WriteLine("(" + (i + 1) + ")");
				Console.WriteLine(Client.Clientlt[i]);
			}
		}
	}
}

