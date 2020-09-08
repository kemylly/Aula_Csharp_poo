using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pokemon p = new Pokemon();
            // Pokemon p1 = new Pokemon();
            //Pokemon p = new Pokemon("Bulbasauro", "Bulbasauro é um pokemon tipo planta..."); //culpa da sobrecarga

            // p.Nome = "Bulbasauro";
            //p.Descricao = "Bulbasauro é um pokemon tipo planta...";

            //p.ExibirDadosPokemon(true);

            Pokedex pokedex = new Pokedex();
            Pokemon p = pokedex.Pokemons[1];

            p.ExibirDadosPokemon();

            Console.ReadKey();
        }
    }
}
