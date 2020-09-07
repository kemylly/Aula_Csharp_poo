﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_MaiorIdade
{
    public class Pessoa
    {
		//construtores
		public Pessoa()
		{
			this.Nome = "";
			this.Idade = 0;
		}

		public Pessoa(String nome, int idade)
		{
			this.Nome = nome;
			this.Idade = idade;
		}


		//propriedades
		private String nome;

		public String Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		private int idade;

		public int Idade {
			get { 
				return idade; 
			} 
			set
			{
				if  (value >= 0)
				{
					idade = value;
				}
				else
				{
					this.idade = 0;
				}
			}
		}


		//metodos / acoes
		public void ExibirDados()
		{
			Console.WriteLine("Nome: " + this.Nome); //vou escrever isso na tela quando for chamado
			Console.WriteLine("Idade: " + this.Idade);
		}
	}
}
