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

            //Pokemon p = pokedex.Pokemons[1];
            //p.ExibirDadosPokemon();

            //pokedex.ListarPokemoons(); lista o pokemom - 3 comandos

            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                if(resp == 1)
                {
                    pokedex.ListarPokemoons();
                }
                Console.ReadKey();
                Console.Clear();
            }

            //Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("Pokedex - Agenda Pookemon :) ");
            Console.WriteLine("Escolha uma opcao: ");
            Console.WriteLine("0 - Sair da Pokedex");
            Console.WriteLine("1 - Listar todos os pokemons");
            Console.Write("Resposta: ");
           
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
