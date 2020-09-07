using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagem_poo
{
    public class Mensagem
    {
        //String TextoMensagem; //normalmente uma variavel representa um objeto / caracteristicas
        //naturamente ela vem encapsulada / escondida

        //public String TextoMensagem; //publico
        private String TextoMensagem;

        //private e public
        public void ExibirMensagem() //void nao retorna nada
        {
            Console.WriteLine(this.TextoMensagem); //this é interagindo com ele mesmo
        }

        public String getTextoMensagem()
        {
            return this.TextoMensagem;
        }

        public void setTextoMensagem(String valor)
        {
            this.TextoMensagem = valor.ToUpper(); // deiixar todos maisculo
        }
    }
}
