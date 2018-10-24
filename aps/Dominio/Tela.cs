using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace aps.Dominio
{
	public class Tela
	{

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

	}
}

