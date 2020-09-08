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
            Pokemon p = new Pokemon();
            p.Nome = "Bulbasauro";
            p.Descricao = "Bulbasauro é um pokemon tipo planta...";
            p.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}
