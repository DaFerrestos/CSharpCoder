using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar() {

            int intervalo = 50;
            Console.WriteLine("Números pares entre 1 e {0}", intervalo);

            for (int i = 1; i < 50; i++) { 
            if(i % 2 == 1) {
                    continue;//enquanto a condição não for atendida completamente o laço se repetirá.
                }
                Console.WriteLine(i);
            }
        
        }
    }
}
