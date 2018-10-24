
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using aps.Dominio;

namespace aps_Formulario
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int op = 0;

                    
            do
            {
                Console.Clear();
                Console.WriteLine("digite \n(1)novo cadastro \n(2)todos os cadastros \n(3)alterar \n(0)sair");
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("erro inesperado\n" + e.Message);
                    op = 999;
                    Console.ReadKey();
                }

                switch (op)
                {
                    case 0:
                        Console.Write("programa finalizado");
                        break;
                    case 1:// novo cadastro

						aps.Dominio.Tela.NewClient();

                        
                        Console.ReadKey();
                        break;

                    case 2: // MOSTRAS TODOS OS CADATROS CEM ORDEM CRECENTE
                        Console.Clear();
                    
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("alteraçao");
                        
                        Console.ReadKey();

                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;


                }
            } while (op != 0);




            //Arquivo.mostrar();

        }
    }
}
