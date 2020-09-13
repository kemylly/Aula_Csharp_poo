using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_App
{
    public class Pokedex //agenda
    {
		public Pokedex()
		{
			this.InicializaLista();
		}

		private List<Pokemon_plus> pokemons;  // uma propriedade utiliza um objeto como referencia

		public List<Pokemon_plus> Pokemons
		{
			get 
			{ 
				return pokemons; 
			}
		}

		private void InicializaLista()
		{
			//Instanciar a lista
			this.pokemons = new List<Pokemon_plus>();

			Pokemon_plus p = new Pokemon_plus("Bulbasauro", "Pokemon tipo planta", 60); //objeto do tipo pokemon
			this.pokemons.Add(p);

			p = new Pokemon_plus("Pikachu", "Pokemon tipo raio", 100);
			this.pokemons.Add(p);

			p = new Pokemon_plus("Chamander", "Pokemon tipo fogo", 90);
			this.pokemons.Add(p);

			p = new Pokemon_plus("Pichu", "Pokemon tipo raio", 75);
			this.pokemons.Add(p);

			p = new Pokemon_plus("Raiuchu", "Pokemon tipo raio", 80);
			this.pokemons.Add(p);

			p = new Pokemon_plus("Squirtle", "Pokemon tipo agua", 65);
			this.pokemons.Add(p);

			p = new Pokemon_plus("Mew", "Lendario psiquico", 100);
			this.pokemons.Add(p);

			p = new Pokemon_plus("Zubat", "Pokemon tipo Poçao", 60);
			this.pokemons.Add(p);

			p = new Pokemon_plus("Electabuzz", "Pokemon tipo  Electric" , 85);
			this.pokemons.Add(p);

			p = new Pokemon_plus("Venusaur", "Pokemon tipo planta", 70);
			this.pokemons.Add(p);
		}

		public void ListarPokemoons()
		{
			for (int i = 0; i < this.Pokemons.Count; i++) //count conta quantos elementos tem
			{
				//this.Pokemons[i].ExibirDadosPokemon(); Comando unico para tudo
				Pokemon p = this.Pokemons[i];
				p.ExibirDadosPokemon();
			}
		}
	}
}
