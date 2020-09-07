using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagem_poo
{
    public class Mensagem
    {
        // parte 1

        //String TextoMensagem; //normalmente uma variavel representa um objeto / caracteristicas
        //naturamente ela vem encapsulada / escondida

        //public String TextoMensagem; //publico 1
        //private String TextoMensagem; 2

        //private e public
        //public void ExibirMensagem() //void nao retorna nada
        // {
        //   Console.WriteLine(this.TextoMensagem); //this é interagindo com ele mesmo
        //}

        // public String getTextoMensagem()
        // {
        //   return this.TextoMensagem;
        // }

        // public void setTextoMensagem(String valor)
        // {
        //   this.TextoMensagem = valor.ToUpper(); // deiixar todos maisculo
        // }
        

        
        // parte 2
        
        
        private String textoMensagem; // so o objeto consegue interagir com ele

        public String TextoMensagem // criei uma propriedade / caracteristica
            //que guarda na texto mensagem oo seu valor
        {
            get // pegar um valor para uma propriedade
            {
                return this.textoMensagem;  //guardar 
            }

            set  // definir um valor para uma propriedade
            {
                this.textoMensagem = value.ToUpper(); //tratar os dados
            }
        }
        
        public void ExibirMensagem() 
        {
           Console.WriteLine(this.TextoMensagem); //estou escrevendo na tel a caracteristica
        }
    }
}
