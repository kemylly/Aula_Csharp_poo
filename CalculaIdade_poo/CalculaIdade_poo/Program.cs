using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdade_poo
{
    class Program  //classe principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de um usuario");
            Pessoa p = new Pessoa();

            Console.Write("Digite seu nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Digite seu Ano de Nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(p.Idade); //terceiro jeito de fazer
            //p.Exibirdados();  //chamo os metodos

            Console.ReadKey();
        }
    }
}
