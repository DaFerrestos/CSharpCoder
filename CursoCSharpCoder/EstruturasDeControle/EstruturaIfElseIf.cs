using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar() {

            /*
            Estrutura que contém expressão para retorno true ou false composta por sentenças que afirmarão ou negarão 
            a expressão inicial. Neste caso, tanto a afirmação quanto a negação refletem algum retorno e esta opção atende a expressões que 
            podem combinar diversas sentenças, muitas possibilidades
            */

            Console.Write("Digite a nota: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de honra!");
            } else if(nota >= 7.0) {
                Console.WriteLine("Aprovado!");

            } else if (nota >= 5.0) {
                Console.WriteLine("Recuperação!");
            } else {
                Console.WriteLine("Reprovado, até a próxima!");
            }

            Console.WriteLine("Fim...");
        }
    }
}
