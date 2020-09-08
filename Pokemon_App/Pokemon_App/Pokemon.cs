using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_App
{
    public class Pokemon

    {
		public Pokemon() //construtor
		{
			this.Nome = "";
			this.Descricao = "";
		}

		public Pokemon(String nome, String descricao) //construtor com sobrecarga, pois recebe os parametros
		{
			this.Nome = nome;
			this.Descricao = descricao;
		}

		private String nome;  //propriedade

		public String Nome
		{
			get 
			{ 
				return nome; 
			}
			set
			{
				String texto = value.ToUpper();
				nome = texto; 
			}
		}

		private String descricao;   //armazena o valor propriedade descricao

		public String Descricao  //representa a caracteristica Descricao do pokemon
		{
			get { return descricao; }
			set 
			{ 
				this.descricao = value.ToLower(); 
			}
		}

		public void ExibirDadosPokemon()  //metodos
		{
			Console.WriteLine("Nome do Pokemon: " + this.Nome);
			Console.WriteLine("Descricao do Pokemon: " + this.Descricao);
		}
	}
}
