using System;
using System.Collections.Generic;

namespace aps.Dominio
{

    public class Client : IComparable
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Naturalidade { get; set; }
        public string Procedencia { get; set; }
       public string Profissao { get; set; }
        public string endereco { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }

		public Client(string nome, string sobre, string ida, string sex, string est, string nat, string proced, string prof, string end, string cep, string estado)
        {
            this.Name = nome;
            this.LastName = sobre;
            this.Idade = ida;
            this.Sexo = sex;
            this.EstadoCivil = est;
            this.Naturalidade = nat;
            this.Procedencia = proced;
            this.Profissao = prof;
            this.endereco = end;
            this.cep = cep;
            this.estado = estado;
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
                return -Idade.CompareTo(outro.Idade);
            }

        }

		public string preview(){

			return " Nome:\t\t" + Name +
				"\n Sobrenome:\t" + LastName+
                "\n";
		}


        public string salvarCadsatroTxt()
        {
            return Name + "." + LastName + "." + Idade + "." + Sexo + "." + EstadoCivil + "." + Naturalidade + "." + Procedencia + "." + Profissao + "." + endereco + "." + cep + "." + estado;
        }

        public override string ToString()
        {
            return " Nome:\t\t" + Name +
                "\n Sobrenome:\t" + LastName +
                "\n Idade:\t\t" + Idade +
                "\n Sexo:\t\t" + Sexo +
                "\n Estado Civil:\t" + EstadoCivil +
                "\n Naturalidade:\t" + Naturalidade +
                "\n Procedencia:\t" + Procedencia +
                "\n Profissao:\t" + Profissao +
                "\n Endereco:\t" + endereco +
                "\n Cep:\t\t" + cep +
                "\n Estado:\t" + estado;

        }


    }
}

