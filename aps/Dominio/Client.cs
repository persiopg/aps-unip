using System;
using System.Collections.Generic;
using System.Globalization;

namespace aps.Dominio
{

    public class Client : IComparable
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public char Clas(){

            char[] vetn = Name.Split();

            return vetn[0];
        }

		public Client(string nome, string sobre, string ida, string sex, string est)
        {
            this.Name = nome;
            this.LastName = sobre;
            this.Idade = ida;
            this.Sexo = sex;
            this.EstadoCivil = est;
        }

		public static List<Client> Clientlt = new List<Client>();

        public int CompareTo(object obj)
        {
			Client outro = (Client)obj;
            int resultado = Name.CompareTo(outro.Name);
            if (resultado != 0)
            {
                return resultado;
            }
            else
            {
                return Idade.CompareTo(outro.Idade);
            }

        }

		public string preview(){

			return " Nome:\t\t" + Name +
				"\n Sobrenome:\t" + LastName;
		}


        public string salvarCadsatroTxt()
        {
            return Name + "." + LastName + "." + Idade + "." + Sexo + "." + EstadoCivil;
        }

        public override string ToString()
        {
            return " Nome:\t\t" + Name +
                "\n Sobrenome:\t" + LastName +
                "\n Idade:\t\t" + Idade +
                "\n Sexo:\t\t" + Sexo +
                "\n Estado Civil:\t" + EstadoCivil +
                "\n";
        }


    }
}

