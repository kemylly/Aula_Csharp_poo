using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagem_poo
{
    class Program //classe
    {
        static void Main(string[] args) //objeto metodo que chama main e executa uma acao
        {
            //Console.WriteLine("Alo mundo");
            
            Mensagem msg1, msg2;
            
            msg1 = new Mensagem(); //construtor / criou o objeto / deu vida
            //msg1.TextoMensagem = "Alo mundo"; //metodos
            msg1.setTextoMensagem("Alo mundo");
            Console.WriteLine(msg1.getTextoMensagem());

            msg1.ExibirMensagem();
            //Console.WriteLine(msg1.TextoMensagem);

            //msg2 = new Mensagem();
            //msg2.TextoMensagem = "Segundo objeto";
            //msg2.ExibirMensagem();

            Console.ReadKey();
        }
    }
}
