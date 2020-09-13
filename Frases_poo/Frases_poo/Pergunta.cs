using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frases_poo
{
    public class Pergunta
    {
		/*public String testA;
		private String testB;
		protected String testC; */

		public Pergunta() //construtor //armazenada em tempo de construcao
		{
			this.Texto = "";
			this.Resposta = "";
		}

		public Pergunta(String texto, String resposta)  //sobrecarga
		{
			this.Texto = texto;
			this.Resposta = resposta;
		}


		private String texto; //porpriedade texto
		public String Texto
		{
			get { return texto; }
			set { texto = value; }
		}

		public String Resposta { get; set; } //forma simplificada de propriedade
	}
}
