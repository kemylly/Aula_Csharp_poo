using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Frases_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pergunta p = new Pergunta();
            Pergunta_plus p = new Pergunta_plus();

            p.Texto = "Site sobre programação";
            p.Resposta = "https://www.site.com.br";
            p.Dica = "O mantenedor do site é site";

            Console.WriteLine("Tente adivinhar a pergunta");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.Write("Resposta: ");
            String resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabens voce acertou! ");
            }
            else
            {
                Console.WriteLine("Voce errou!");
                Console.WriteLine("A resposta era: " + p.Resposta);
            }

            Console.ReadKey();
        }
    }
}
