using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar() {

            //utilizada para percorrer elementos sem necessidade de validações anteriores

            var palavra = "Paz";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }
        
        }
    }
}
