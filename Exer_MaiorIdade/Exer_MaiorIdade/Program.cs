using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;

            Console.WriteLine("Encontra a pessoa mais velha");

            //leitura de dados da primeira pessoa
            Console.Write("Digite o 1 nome: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();

            Console.Write("Digite a 1 idade: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            //leitura de dados da segunda pessoa
            Console.Write("Digite o 2 nome: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();

            Console.Write("Digite a 2 idade: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            //leitura de dados da terceira pessoa
            Console.Write("Digite o 3 nome: ");
            String nome = Console.ReadLine(); //feito diferente

            Console.Write("Digite a 3 idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            p3 = new Pessoa(nome, idade); //incluir ja no construtor


            //logica
            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else
            {
                if ((p2.Idade > p1.Idade) && (p2.Idade > p3.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é: ");
                    p2.ExibirDados();
                }
                else
                {
                    if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é: ");
                        p3.ExibirDados();
                    }
                    else
                    {
                        if ((p1.Idade == p2.Idade) && (p1.Idade > p3.Idade))
                        {
                            Console.WriteLine("A duas pessoas mais velhas são: ");
                            p1.ExibirDados();
                            p2.ExibirDados();
                        }
                        else
                        {
                            if ((p1.Idade == p2.Idade) && (p1.Idade < p3.Idade))
                            {
                                Console.WriteLine("A pessoa mais velha é: ");
                                p3.ExibirDados();
                            }
                            else
                            {
                                if ((p2.Idade == p3.Idade) && (p2.Idade > p1.Idade))
                                {
                                    Console.WriteLine("A duas pessoas mais velhas são: ");
                                    p2.ExibirDados();
                                    p3.ExibirDados();
                                }
                                else
                                {
                                    if ((p2.Idade == p3.Idade) && (p2.Idade < p1.Idade))
                                    {
                                        Console.WriteLine("A pessoa mais velha é: ");
                                        p1.ExibirDados();
                                    }
                                    else
                                    {
                                        if ((p1.Idade == p3.Idade) && (p1.Idade > p2.Idade))
                                        {
                                            Console.WriteLine("A duas pessoas mais velhas e são: ");
                                            p1.ExibirDados();
                                            p3.ExibirDados();
                                        }
                                        else
                                        {
                                            if ((p1.Idade == p3.Idade) && (p1.Idade < p2.Idade))
                                            {
                                                Console.WriteLine("A pessoa mais velha é: ");
                                                p2.ExibirDados();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Toas as pessoas possuem a mesma idade. ");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }  

            Console.ReadKey();
        }
    }
}
