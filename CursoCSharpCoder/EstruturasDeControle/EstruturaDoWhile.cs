using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar() {
            string entrada;

            do {
                Console.WriteLine("Qual seu nome? ");
                entrada = Console.ReadLine();

                Console.WriteLine("Bem vindo(a) {0}", entrada);
                Console.WriteLine("Deseja inserir um novo nome? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");

            Console.WriteLine("Até a próxima!");
        }
    }
}
