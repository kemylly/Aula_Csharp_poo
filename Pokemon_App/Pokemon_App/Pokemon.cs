using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_App
{
    public class Pokemon
    {
		private String nome;  //propriedade

		public String Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		private String dadosPokemon;

		public String DadosPokemon
		{
			get { return dadosPokemon; }
			set { dadosPokemon = value; }
		}


	}
}
