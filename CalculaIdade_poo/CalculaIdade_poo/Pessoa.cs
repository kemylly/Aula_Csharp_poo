using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdade_poo
{
    public class Pessoa //objeto que for do tipo pessoa
    {

		public Pessoa(String nomePessoa, int anoNascimentoPessoa)  //4 modo de fazer / construtor com ou sem paramentro
		{
			this.Nome = nomePessoa; //pode  receber um valor fixo ou parametro
			this.AnoNascimento = anoNascimentoPessoa;
			this.CalcularIdade(); //define  a propriedade idade com os parametros
		}

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

		//coisa nova adicionada get e set de idade depois de finalizado
		private int idade;
							//adicionada essa propriedade
		public int Idade
		{
			get 
			{
				//this.CalcularIdade();  //terceiro jeito de fazer
				return this.idade;  //entrega para quem precisar
			}  
			
			//set { this.idade = value; } // nao preciso dele nao posso guardar um valor
		}


		//executa duas acoes a de exibir dados e calcular idade
		public void Exibirdados() //exibir os dados e poder interargir
		{
			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Ano de nascimento: " + this.AnoNascimento); //pegar o valor da propriedade nao da variavel

			//int idade = this.CalcularIdade(); //recebe o retorno de calcular idade no caso a idade vai para idade
			this.CalcularIdade(); //segundo jeito
			
			//Console.WriteLine("Idade: " +idade);
			Console.WriteLine("Idade: " + this.Idade);  //segundo jeito
		}

		//private int CalcularIdade() //criar uma acao que so a classe pessoa pode interagir
		private void CalcularIdade() //segundo modo de fazer
		{
			DateTime data = DateTime.Now; //Pegar a data do sistema atual
			int ano = data.Year;
			
			//int idade = ano - this.AnoNascimento;   //primeiro jeito
			this.idade = ano - this.AnoNascimento;
			
			//return idade; primeiro jeito
		}
	}
}
