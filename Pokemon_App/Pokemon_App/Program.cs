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
                    Console.ReadKey();
                }
                if(resp == 2)
                {
                    pokedex.ListarPokemoons();

                    Console.WriteLine(" ");
                    Console.Write("Digite o codigo do pokemon escolhido: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    
                    //pegar o pokemon do player
                    Pokemon_plus pPlayer = pokedex.Pokemons[codigo];

                    //definir o pokemon do pc
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    Pokemon_plus pPC = pokedex.Pokemons[codigo];

                    Console.Clear();

                    //batalhar
                    Console.WriteLine("Dados do seu pokemon:");
                    //Console.WriteLine("Nivel de poder: " + pPlayer.Poder);
                    pPlayer.ExibirDadosPokemonPlus();

                    Console.WriteLine(" ");

                    Console.WriteLine("Dados do pokemon PC:");
                    //Console.WriteLine("Nivel de poder: " + pPlayer.Poder);
                    pPC.ExibirDadosPokemonPlus();

                    if (pPlayer.Poder > pPC.Poder)
                    {

                        //Console.Clear();

                        Console.WriteLine(" ");
                        Console.WriteLine(" *** Winner :) ***  ");

                        Console.ReadKey();
                    }
                    else if (pPlayer.Poder == pPC.Poder)
                    {

                        Console.WriteLine(" ");
                        Console.WriteLine(" *** Empate :/ ***  ");

                        Console.ReadKey();
                    }

                    else
                    {
                        //Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine(" *** Game over :( *** ");

                        Console.ReadKey();
                    }
                    
                    
                }

                //Console.ReadKey();
                Console.Clear();
            }

            //Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("Pokemon - Agenda e jogo Pookemon :) ");
            Console.WriteLine("Escolha uma opcao: ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Listar todos os pokemons da pokedex");
            Console.WriteLine("2 - Batalhar");
            Console.Write("Resposta: ");
            

            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
