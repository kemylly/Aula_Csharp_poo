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
            Console.WriteLine("Programa que calcula a idade de um usuario");  //desde o primeiro jeito
                                                                              //Pessoa p = new Pessoa();  //construtor / desde o primeiro jeito

            //Pessoa p = new Pessoa("kemylly", 2002); //quarto modo p2
            //p.Exibirdados();  //quarto modo p2
            // Console.WriteLine(p.Nome); // quarto modo de fazer p1

            /* //primeiro jeiro de exibir
            Console.Write("Digite seu nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Digite seu Ano de Nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(p.Idade); //terceiro jeito de fazer
            //p.Exibirdados();  //chamo os metodos
            */

            Console.Write("Digite seu nome: ");
            String Nome = Console.ReadLine();

            Console.Write("Digite seu Ano de Nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Pessoa p;
            p = new Pessoa(Nome, ano);
            
            p.Exibirdados();  //chamo os metodos


            Console.ReadKey();  //para o  programa / basico
        }
    }
}
