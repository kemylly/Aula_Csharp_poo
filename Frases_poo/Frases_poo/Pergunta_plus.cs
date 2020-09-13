using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frases_poo  // trabalhar com herança
{
    public class Pergunta_plus:Pergunta //Herda tudo da da classe pergunta
    {
        public Pergunta_plus():base() //construtor é puxado pela heranca se por base
        {
            /*   this.Texto = "";
               this.Resposta = ""; */
            this.Dica = ""; 
        }

        public Pergunta_plus(String texto, String resposta, String dica):base(texto, resposta) //sobrecarga com herança
        {
            //this.Dica = "";
            this.Dica = dica;
        }

        public String Dica { get; set; } //propriedade
    }
}
