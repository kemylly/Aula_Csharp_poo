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

		private List<Pokemon> pokemons;  // uma proprieda utiliza um objeto como referencia

		public List<Pokemon> Pokemons
		{
			get 
			{ 
				return pokemons; 
			}
		}

		private void InicializaLista()
		{
			//Instanciar a lista
			this.pokemons = new List<Pokemon>();

			Pokemon p = new Pokemon("Bulbasauro", "Pokemon tipo planta"); //objeto do tipo pokemon
			this.pokemons.Add(p);

			p = new Pokemon("Pikachu", "Pokemon tipo raio");
			this.pokemons.Add(p);

			p = new Pokemon("Chamander", "Pokemon tipo fogo");
			this.pokemons.Add(p);

			p = new Pokemon("Pichu", "Pokemon tipo raio");
			this.pokemons.Add(p);

			p = new Pokemon("Raiuchu", "Pokemon tipo raio");
			this.pokemons.Add(p);

			p = new Pokemon("Squirtle", "Pokemon tipo agua");
			this.pokemons.Add(p);

			p = new Pokemon("Mew", "Lendario psiquico");
			this.pokemons.Add(p);

			p = new Pokemon("Zubat", "Pokemon tipo Poçao");
			this.pokemons.Add(p);

			p = new Pokemon("Electabuzz", "Pokemon tipo  Electric ");
			this.pokemons.Add(p);

			p = new Pokemon("Venusaur", "Pokemon tipo planta");
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
