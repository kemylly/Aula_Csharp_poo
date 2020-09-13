using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_App
{
    public class Pokemon_plus:Pokemon  //hernaça
    {
		public Pokemon_plus() : base()//construtor sem parametro
		{
			this.Poder = 0; //inicializa com 0
		}

		public Pokemon_plus(String nome, String descricao, int poder):base(nome, descricao)  //utiliza o construtor da outra classe
		{
			this.Poder = poder;
		}

		private int poder;  //propriedade
		public int Poder
		{
			get { return poder; }
			set { poder = value; }
		}

		public void ExibirDadosPokemonPlus()
		{
			Console.WriteLine("Nome do Pokemon: " + this.Nome);
			Console.WriteLine("Descricao do Pokemon: " + this.Descricao);
			Console.WriteLine("Nivel de poder" + this.Poder);
		}
	}
}
