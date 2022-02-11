using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar() {

            /*
             Estrutura que contém expressão para retorno true ou false composta por sentenças que afirmarão ou negarão 
            a expressão inicial
             */

            bool bomComportamento = true;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N)? ");
            entrada = Console.ReadLine();

            if (entrada == "S" || entrada == "s")
                bomComportamento = true;

            //Outras formas de escrever a mesma sentença:

            //bomComportamento = entrada == "S" || entrada == "s";
            //bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
