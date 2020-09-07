using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdade_poo
{
    public class Pessoa //objeto que for do tipo pessoa
    {
		private int anoNascimento; //caracteristica

		public int AnoNascimento
		{
			get { return this.anoNascimento; }
			set { this.anoNascimento = value; }
		}

		private String nome;

		public String Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		//executa duas acoes a de exibir dados e calcular idade

		public void Exibirdados() //exibir os dados e poder interargir
		{
			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Ano de nascimento: " + this.AnoNascimento); //pegar o valor da propriedade nao da variavel
			int idade = this.CalcularIdade(); //recebe o retorno de calcular idade no caso a idade vai para idade
			Console.WriteLine("Idade: " +idade);
		}

		private int CalcularIdade() //criar uma acao que so a classe pessoa pode interagir
		{
			DateTime data = DateTime.Now; //Pegar a data do sistema atual
			int ano = data.Year;
			int idade = ano - this.AnoNascimento;
			return idade;
		}
	}
}
