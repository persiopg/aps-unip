
using System;
using aps.Dominio;

namespace aps_Formulario
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			ArquivoTxt.Read();

            int op = 0;
                    
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\tdigite \n\t(1)novo cadastro \n\t(2)todos os cadastros \n\t(0)sair");
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERRO Nº5\n" + e.Message);
                    op = int.MaxValue;
                    Console.ReadKey();
                }

                switch (op)
                {
                    case 0:
                        Console.Write("programa finalizado");
                        break;
                    case 1:// novo cadastro
						Tela.NewClient();                        
                        Console.ReadKey();
                        break;
                    case 2: // MOSTRAS TODOS OS CADATROS CEM ORDEM CRECENTE 
						Tela.ShowClients();                        
                        Console.ReadKey();
                        break;                  
                    default:
                        Console.WriteLine("opção invalida");
                        break;


                }
            } while (op != 0);
			ArquivoTxt.Save();

        }
    }
}
