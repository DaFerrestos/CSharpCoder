using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.TopicosAvancados
{
    /*
     Tipos dinâmicos permitem alternância de tipo de dado.   
     */
    class Dynamics
    {
        public static void Executar() {

            //No caso abaixo a variável foi inicializada como string
            //e depois alterada para um int que pôde ser incrementado:

            dynamic meuObjeto = "teste";
            meuObjeto = 12;

            meuObjeto++;
            Console.WriteLine(meuObjeto);
        
        }
    }
}
