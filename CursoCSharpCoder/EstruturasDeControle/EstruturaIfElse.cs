using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar() {

            /*
           Estrutura que contém expressão para retorno true ou false composta por sentenças que afirmarão ou negarão 
          a expressão inicial. Neste caso, tanto a afirmação quanto a negação refletem algum retorno.
           */

            double nota = 7.0 ;

            if (nota >= 70) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            } else {
                Console.WriteLine("Recuperação!");
            }
        }
    }
}
